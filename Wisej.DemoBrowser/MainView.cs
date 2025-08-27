﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using Wisej.Core;
using Wisej.DemoBrowser.Controls;
using Wisej.Web;

namespace Wisej.DemoBrowser
{
	public partial class MainView : Page
	{

		#region Properties

		/// <summary>
		/// The current search results.
		/// </summary>
		private List<TreeNode> CategoryNodes = new List<TreeNode>();

		/// <summary>
		/// The default URL for the source code.
		/// </summary>
		private string BASE_SOURCE_CODE_URL = "https://github.com/";

		/// <summary>
		/// The default URL for the documentation.
		/// </summary>
		private string BASE_DOCS_URL = "https://docs.wisej.com/docs/";

		#endregion

		#region Constructor

		public MainView()
		{
			InitializeComponent();
		}

		#endregion

		private void MainView_Load(object sender, EventArgs e)
		{
			var hash = Application.Hash;
			Application.HashChanged += this.Application_HashChanged;

			this.treeViewComponents.Nodes.Clear();
			PopulateTestList();

			if (Application.Browser.Device == "Mobile" || Application.Browser.Size.Width < 1200)
				this.panelComponents.Collapsed = true;

#if NETCOREAPP
			LoadUnreferencedWisejAssemblies();
#endif

			if (this.treeViewComponents.Nodes.Count > 0)
				this.treeViewComponents.SelectedNode = this.treeViewComponents.Nodes[0];

			if (!string.IsNullOrEmpty(hash))
				SelectNode(hash);

			if (!this.panelComponents.Collapsed)
				this.panelComponents.ShowHeader = false;
		}

		/// <summary>
		/// Load Wisej-related assemblies that aren't referenced in the main project.
		/// </summary>
		private void LoadUnreferencedWisejAssemblies()
		{
			var directory = Path.GetDirectoryName(Application.ExecutablePath);
			var assemblies = Directory.GetFiles(directory, "Wisej.*.dll");
			foreach (var assembly in assemblies)
				Application.LoadAssembly(Path.Combine(directory, assembly));
		}

		private void Application_HashChanged(object sender, HashChangedEventArgs e)
		{
			SelectNode(e.Hash);
		}

		private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			Application.LoadTheme(this.comboBoxTheme.Text);
		}

		/// <summary>
		/// Populates the TreeView with the available demos.
		/// </summary>
		private void PopulateTestList()
		{
			var text = File.ReadAllText(Path.Combine(Application.MapPath("DemoBrowser.json")));
			var data = Core.WisejSerializer.Parse(text);

			foreach (Core.DynamicObject.Member category in data)
			{
				// create category node.
				var categoryName = category.Name;
				var controls = (dynamic)category.Value;

				var categoryNode = new TreeNode
				{
					Text = categoryName,
					Name = categoryName,
				};

				categoryNode.UserData.Type = "Category";

				foreach (Core.DynamicObject.Member control in controls)
				{
					// create control node.
					var controlName = control.Name;
					var demos = (dynamic)control.Value;

					if (controlName == "Overview")
						continue;

					var controlNode = new TreeNode
					{
						Name = controlName,
						Text = controlName,
						HideNodeImage = demos.Count == 0,
					};
					controlNode.UserData.Type = "Control";

					// apply the "features" image to the category and control.
					var imageSource = demos["Features"]?.imageSource ?? "";
					var imageIndex = AppendImage(imageSource);

					categoryNode.ImageIndex = imageIndex;
					categoryNode.SelectedImageIndex = imageIndex;

					controlNode.ImageIndex = imageIndex;
					controlNode.SelectedImageIndex = imageIndex;

					categoryNode.Nodes.Add(controlNode);

					foreach (Core.DynamicObject.Member demo in demos)
					{
						// create demo node.
						var demoName = demo.Name;
						var demoContent = (dynamic)demo.Value;
						TreeNode demoNode = null;

						// replace "Features" node with control-node.
						if (demoName == "Features")
						{
							demoNode = controlNode;
						}
						else
						{
							demoNode = new TreeNode
							{
								Text = demoName,
								Name = demoName,
							};
							controlNode.Nodes.Add(demoNode);
						}
						demoNode.Tag = new
						{
							Title = demoName,
							Info = demoContent,
							Control = controlName,
							Category = categoryName,
							Hash = $"#{categoryName}/{controlName}/{demoName}".Replace(" ", "%20")
					};

						// apply the "features" image.
						var demoImageSource = ((dynamic)demo.Value)?.imageSource ?? "";
						var demoImageIndex = AppendImage(demoImageSource);

						demoNode.ImageIndex = demoImageIndex;
						demoNode.SelectedImageIndex = demoImageIndex;

						demoNode.UserData.Type = "Demo";
					}
				}
				this.CategoryNodes.Add(categoryNode);
				this.treeViewComponents.Nodes.Add(categoryNode);
			}
		}

		/// <summary>
		/// Appends the image to the imagelist.
		/// </summary>
		/// <param name="imageSource"></param>
		/// <returns></returns>
		private int AppendImage(string imageSource)
		{
			this.imageList1.Images.Add(new ImageListEntry(imageSource));
			return this.imageList1.Images.Count - 1;
		}

		/// <summary>
		/// Selects a node if the given path exists.
		/// </summary>
		/// <param name="path"></param>
		private void SelectNode(string path)
		{
			if (string.IsNullOrEmpty(path))
            {
				this.treeViewComponents.SelectedNode = this.treeViewComponents.Nodes.First();
				return;
            }

			try
			{
				var nodePath = WebUtility.UrlDecode(path).Split(this.treeViewComponents.PathSeparator.ToCharArray());
				var categoryNode = this.CategoryNodes.First(n => n.Text == nodePath[0]);
				var controlNode = categoryNode.Nodes[nodePath[1]];

				TreeNode demoNode = null;
				if (nodePath.Length > 2)
					demoNode = controlNode.Nodes[nodePath[2]];

				if (demoNode == null)
					demoNode = controlNode;

				this.treeViewComponents.SelectedNode = demoNode;
			}
			catch
			{
				Web.AlertBox.Show("Unknown Demo.", MessageBoxIcon.Error, showProgressBar: true);
			}
		}

		/// <summary>
		/// Shows the view for the selected node.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void treeViewComponents_AfterSelect(object sender, TreeViewEventArgs e)
		{
			var node = this.treeViewComponents.SelectedNode;
			if (node.Tag == null)
			{
				if (node.Nodes.Count > 0)
					this.treeViewComponents.SelectedNode = node.Nodes[0];
			}
			else
			{
				ProcessNodeSelection(node);
			}
		}

		/// <summary>
		/// Processes the demo data for the given node.
		/// </summary>
		/// <param name="node">The demo node.</param>
		private void ProcessNodeSelection(TreeNode node)
		{
			var container = this.panelDemo;
			container.Controls.Clear(true);

			var data = (dynamic)node.Tag;
			var category = data.Category;
			var control = data.Control;
			var title = data.Title;
			var info = data.Info;

			// retrieve the localized description or default to english.
			var culture = Application.CurrentCulture.TwoLetterISOLanguageName;
			var description = info[$"description-{culture}"] ?? info["description-en"];

			var fullyQualifiedName = (string)info.assembly ?? null;
			if (fullyQualifiedName != null)
			{
				var components = fullyQualifiedName.Split(',');
				var assemblyName = components[1].Trim();
				var typeName = components[0].Trim();

				var directory = Path.GetDirectoryName(Application.ExecutablePath);
				var path = Path.Combine(directory, assemblyName);
				var assembly = Application.LoadAssembly(path);
				var type = assembly.GetTypes().Where(t => t.Name == typeName).ToArray()[0] ?? null;

				var demoInstance = (Control)Activator.CreateInstance(type);

				demoInstance.UserData.args = node.UserData.args;
				demoInstance.Dock = DockStyle.Fill;

				container.Controls.Add(demoInstance);

				container.Text = title;
				Application.Hash = data.Hash;

				this.labelNavigationControl.Text = control;
				this.labelNaivgationCategory.Text = category;
				this.labelDescription.Text = description ?? "";
				this.labelNavigationDemo.Text = title ?? demoInstance.Name;
				this.pictureBoxControl.ImageSource = info?.imageSource ?? "";
				this.labelTitle.Text = $"{control} {title ?? demoInstance.Name}";

				this.buttonRelevantLinks.Tag = info.relevantLinks;
			}
		}

		#region Links

		private void buttonDocs_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://docs.wisej.com/", "_blank");
		}

		private void buttonAPI_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://docs.wisej.com/api", "_blank");
		}

		private void buttonSupport_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://www.wisej.com/support", "_blank");
		}

		private void buttonMWW_Click(object sender, EventArgs e)
		{
			Application.Navigate("http://www.madewithwisej.com", "_blank");
		}

		private void buttonContact_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://www.wisej.com/contact-us", "_blank");
		}

		private void buttonFreeTrial_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://wisej.com/developer-licenses/", "_blank");
		}

		private void buttonBuy_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://wisej.com/developer-licenses/", "_blank");
		}

		/// <summary>
		/// Open the relevant source code.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonSourceCode_Click(object sender, EventArgs e)
		{
			var tag = (dynamic)this.treeViewComponents.SelectedNode.Tag;
			Application.Navigate(tag?.Info?.sourceUrl ?? BASE_SOURCE_CODE_URL, "_blank");
		}

		/// <summary>
		/// Open the relevant documentation.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonDocumentation_Click(object sender, EventArgs e)
		{
			var tag = (dynamic)this.treeViewComponents.SelectedNode.Tag;
			Application.Navigate(tag?.Info.docsUrl ?? BASE_DOCS_URL, "_blank");
		}

		#endregion

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			this.textBoxSearch.Focus();
		}

		private void buttonCollapse_Click(object sender, EventArgs e)
		{
			this.panelComponents.Collapsed = !this.panelComponents.Collapsed;
		}

		private void panelComponents_PanelExpanded(object sender, EventArgs e)
		{
			this.panelComponents.ShowHeader = false;
		}

		private void panelComponents_PanelCollapsed(object sender, EventArgs e)
		{
			this.panelComponents.ShowHeader = true;
		}

		#region Search Implementation

		/// <summary>
		/// Selects the previous demo node.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonPrevious_Click(object sender, EventArgs e)
		{
			this.treeViewComponents.SelectedNode = GetPreviousDemo();
		}

		private TreeNode GetPreviousDemo()
		{
			if (this.treeViewComponents.Nodes.Count == 0)
				return null;

			var node = this.treeViewComponents.SelectedNode ?? this.treeViewComponents.Nodes[0];
			var previousNode = node.PrevNode ?? node.Parent?.PrevNode?.LastNode ?? this.treeViewComponents.Nodes[0];

			if (previousNode?.UserData.type == "Category")
				previousNode = previousNode.LastNode;

			return previousNode ?? this.treeViewComponents.Nodes.Last();
		}

		/// <summary>
		/// Select the next demo node.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonNext_Click(object sender, EventArgs e)
		{
			this.treeViewComponents.SelectedNode = GetNextDemo();
		}

		private TreeNode GetNextDemo()
		{
			if (this.treeViewComponents.Nodes.Count == 0)
				return null;

			var node = this.treeViewComponents.SelectedNode ?? this.treeViewComponents.Nodes[0];
			var nextNode = node.NextNode ?? node.Parent?.NextNode?.FirstNode;
			if (nextNode?.UserData.type == "Category")
				nextNode = nextNode.FirstNode;

			return nextNode ?? this.treeViewComponents.Nodes[0] ?? null;
		}

		private void SearchForPhrase(string phrase)
		{
			var isSearch = !String.IsNullOrEmpty(phrase.Trim(' '));
			if (isSearch)
			{
				this.treeViewComponents.Nodes.Clear();

				foreach (var node in this.CategoryNodes)
					ProcessNodesContain(node.Nodes, phrase);

				if (this.treeViewComponents.Nodes.Count > 0)
					this.treeViewComponents.SelectedNode = this.treeViewComponents.Nodes[0];
				else
					this.treeViewComponents.SelectedNode = null;
			}
			else
			{
				ResetDemoList();
			}

			this.textBoxSearch.Tools["back"].Visible = isSearch;
			this.textBoxSearch.Tools["clear"].Visible = isSearch;
			this.textBoxSearch.Tools["forward"].Visible = isSearch;
		}

		private void ResetDemoList()
        {
			this.treeViewComponents.Nodes.Clear();
			this.treeViewComponents.Nodes.AddRange(this.CategoryNodes.ToArray());
		}

		/// <summary>
		/// Simple method that recursively searches for a phrase from a given root node.
		/// </summary>
		/// <param name="node">The root node.</param>
		/// <param name="phrase">The search phrase.</param>
		private void ProcessNodesContain(TreeNodeCollection nodes, string phrase)
		{
			foreach (var node in nodes)
				if (node.Text.ToUpper().Contains(phrase.ToUpper()))
					this.treeViewComponents.Nodes.Add((TreeNode)node.Clone());
		}

		private void textBoxSearch_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "previous":
					this.treeViewComponents.SelectedNode = GetPreviousDemo();
					break;

				case "next":
					this.treeViewComponents.SelectedNode = GetNextDemo();
					break;

				case "search":
					SearchForPhrase(this.textBoxSearch.Text);
					break;
			}
		}

		/// <summary>
		/// Navigate to the next or previous search result.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBoxSearch_ToolClick(object sender, ToolClickEventArgs e)
		{
			switch (e.Tool.Name)
			{
				case "forward":
					this.treeViewComponents.SelectedNode = GetNextDemo();
					break;

				case "back":
					this.treeViewComponents.SelectedNode = GetPreviousDemo();
					break;

				case "clear":
					this.textBoxSearch.Text = "";
					SearchForPhrase(this.textBoxSearch.Text);
					break;
			}
		}

		#endregion

		private void pictureBoxLogo_Click(object sender, EventArgs e)
		{
			Application.Navigate("https://wisej.com/", "_blank");
		}

		private void buttonRelevantLinks_Click(object sender, EventArgs e)
		{
			if (this._popup == null)
				this._popup = new LinksPopup();

			var links = (DynamicObject[])this.buttonRelevantLinks.Tag;
			if (links != null && links.Length > 0)
			{
				this._popup.Populate(links);
				this._popup.ShowPopup(this.buttonRelevantLinks);
			}
		}
		private LinksPopup _popup = null;
	}
}
