using System;
using System.IO;
using System.Text;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDiagram : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejDiagram()
		{
			InitializeComponent();
		}

		private void ejDiagram1_Appear(object sender, EventArgs e)
		{
			LoadData();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			LoadData();

			this.ejDiagram1.Options.enableContextMenu = this.checkBox2.Checked;
			this.ejDiagram1.Options.constraints = this.checkBox1.Checked ? 6 : 0;
			this.ejDiagram1.Options.enableAutoScroll = this.checkBox3.Checked;
			this.ejDiagram1.Options.bridgeDirection = this.comboBox2.SelectedItem.ToString().ToLower();
			this.ejDiagram1.Options.layout = new
			{
				type = this.comboBox1.SelectedItem.ToString().ToLower()
			};

			this.ejDiagram1.Update();
		}

		private void LoadData()
		{
			switch (this.comboBox1.Text)
			{
				case "None": LoadFlowchart(); break;
				case "HierarchicalTree": LoadHierarchicalTree(); break;
				case "OrganizationalChart": LoadOrganizationalChart(); break;
			}
		}

		private void LoadFlowchart()
		{
			var nodes = new object[] {
				new { name = "node1", offsetX = 400, offsetY = 30, fillColor = "#C44E5F", labels = new[] { new { text = "Start" } }, shape = "terminator" },
				new { name = "node2", offsetX = 400, offsetY = 100, fillColor = "#5e5f5f", labels = new[] { new { text = "Design" } }, shape = "process",
					ports = new[] {
						new { name = "designPort", offset = new { x = 0, y = 0.5 } }
					}
				},
				new { name = "node3", offsetX = 400, offsetY = 180, fillColor = "#5e5f5f", labels = new[] { new { text = "Coding" } }, shape = "process",
					ports = new[] {
						new { name = "codingPort", offset = new { x = 0, y = 0.5 } }
					}
				},
				new { name = "node4", offsetX = 400, offsetY = 260, fillColor = "#5e5f5f", labels = new[] { new { text = "Testing" } }, shape = "process" },
				new { name = "node5", offsetX = 400, offsetY = 340, fillColor = "#4eab8b", labels = new[] { new { text = "Errors?" } }, shape = "decision" },
				new { name = "node6", offsetX = 400, offsetY = 450, fillColor = "#c44e5f", labels = new[] { new { text = "End" } }, shape = "terminator" },
				new { name = "node7", width = 120, offsetX = 220, offsetY = 180, fillColor = "#4eab8b", labels = new[] { new { text = "Design Error?" } },type = "flow",shape = "decision",
					ports = new object[] {
						new { name = "porterror", offset = new { x = 0.5, y = 0 } },
						new { name = "portcoding", offset = new { x = 1, y = 0.5 } },
						new { name = "portdesign", offset = new { x = 0.5, y = 1 } }
					}
				}
			};

			var connectors = new object[] {
				new { name= "connector1", sourceNode= "node1", targetNode= "node2" },
				new { name= "connector2", sourceNode= "node2", targetNode= "node3" },
				new { name= "connector3", sourceNode= "node3", targetNode= "node4" },
				new { name= "connector4", sourceNode= "node4", targetNode= "node5" },
				new { name= "connector5", sourceNode= "node5", targetNode= "node6", labels= new object[]{new{ text= "No", fillColor= "white" }}},
				new { name= "connector6", sourceNode= "node5", targetNode= "node7", segments= new object[]{new{ type= "orthogonal", length= 150, direction= "left" }},labels= new object[]{new{ text= "Yes", fillColor= "white" }}},
				new {name= "connector7", sourceNode= "node7", targetNode= "node3", sourcePort= "portcoding", targetPort= "codingPort",segments= new object[]{new{ type= "orthogonal", length= 10, direction= "left" }},labels= new object[]{new{ text= "No", fillColor= "white" }}},
				new {name= "connector8", sourceNode= "node7", targetNode= "node2", sourcePort= "porterror", targetPort= "designPort", labels= new object[]{new{ text= "Yes", fillColor= "white" }}}
			};

			this.ejDiagram1.Options.nodes = nodes;
			this.ejDiagram1.Options.connectors = connectors;
			this.ejDiagram1.Options.dataSourceSettings = new { };
			this.ejDiagram1.Options.nodeTemplate = "";
			this.ejDiagram1.Options.layout = new { type = "none" };

			this.ejDiagram1.Options.defaultSettings.node = new
			{
				width = 90,
				height = 40,
				type = "flow",
				borderColor = "black",
				fillColor = "transparent",
				labels = new object[] {
					new { fontColor="white", fontSize=12, bold= false, margin= new { left=0, right=0, top=0 },
	 					textAlign= "center", alignment= "center", horizontalAlignment= "center", verticalAlignment= "center"}
				}
			};
		}

		private void LoadHierarchicalTree()
		{
			var data = new object[] {
				new { Name =  "Diagram", fillColor = "#916DAF" },
				new { Name =  "Layout", fillColor= "#88C65C", Category = "Diagram" },
				new { Name =  "Tree Layout", fillColor= "#88C65C", Category = "Layout" },
				new { Name =  "Organizational Chart", fillColor= "#88C65C", Category = "Layout" },
				new { Name =  "Hierarchical Tree", fillColor= "#88C65C", Category = "Tree Layout" },
				new { Name =  "Radial Tree", fillColor= "#88C65C", Category = "Tree Layout" },
				new { Name =  "Mind Map", fillColor= "#88C65C", Category = "Hierarchical Tree" },
				new { Name =  "Family Tree", fillColor= "#88C65C", Category = "Hierarchical Tree" },
				new { Name =  "Management", fillColor= "#88C65C", Category = "Organizational Chart" },
				new { Name =  "Human Resource", fillColor= "#88C65C", Category = "Management" },
				new { Name =  "University", fillColor= "#88C65C", Category = "Management" },
				new { Name =  "Business", fillColor= "#88C65C", Category = "Management" }
			};

			this.ejDiagram1.Options.nodes = new object[0];
			this.ejDiagram1.Options.connectors = new object[0];
			this.ejDiagram1.Options.nodeTemplate = "nodeTemplate";
			this.ejDiagram1.Options.dataSourceSettings = new { id = "Name", parent = "Category", dataSource = data };
			this.ejDiagram1.Options.layout = new { type = "hierarchicaltree", horizontalSpacing = 25, verticalSpacing = 35, marginX = 3, marginY = 3 };

			this.ejDiagram1.Options.defaultSettings.node = new
			{
				width = 100,
				height = 40,
				type = "flow",
				borderColor = "black",
				fillColor = "#88C65C",
				labels = new object[] {
					new { fontColor="white", fontSize=12, bold= false, margin= new { left=10, right=10, top=0 },
						textAlign= "center", alignment= "center", horizontalAlignment= "center", verticalAlignment= "center" }
				}
			};
		}

		private void LoadOrganizationalChart()
		{
			this.ejDiagram1.Options.nodes = new object[0];
			this.ejDiagram1.Options.connectors = new object[0];
			this.ejDiagram1.Options.nodeTemplate = "nodeTemplate";
			this.ejDiagram1.Options.layout = new { type = "organizationalchart", horizontalSpacing = 25, verticalSpacing = 35, marginX = 3, marginY = 50 };

			this.ejDiagram1.Options.defaultSettings.node = new
			{
				width = 140,
				height = 50,
				type = "image",
				borderColor = "transparent",
				fillColor = "transparent",
				labels = new object[] {
					new { fontColor="black", horizontalAlignment= "left", verticalAlignment= "top",
						  margin= new { left= -17, top= -17 }, fontSize= 11, bold= true, fontFamily= "Segoe UI" },
					new { fontColor="black", horizontalAlignment= "left", verticalAlignment= "top",
						  margin= new { left= -17, top= -2 }, fontSize= 10, fontFamily= "Segoe UI"}
				}
			};

			using (var stream = new StreamReader(Application.MapPath("Data\\OrganizationalChart.json")))
			{
				var json = stream.ReadToEnd();
				this.ejDiagram1.Options.dataSourceSettings = new { id = "Id", parent = "ReportingPerson", dataSource = JSON.Parse(json) };
			}

		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var data = await this.ejDiagram1.Instance.saveAsync();
			var json = data.ToString();

			Application.Download(new MemoryStream(Encoding.UTF8.GetBytes(json)), "diagram.json");
		}

		private void buttonLoad_Uploaded(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 1)
			{
				using (var stream = new StreamReader(e.Files[0].InputStream))
				{
					var json = stream.ReadToEnd();
					this.ejDiagram1.Instance.load(JSON.Parse(json));
				}
			}
		}
	}
}
