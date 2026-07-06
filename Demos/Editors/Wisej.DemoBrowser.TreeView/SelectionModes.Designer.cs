namespace Wisej.DemoBrowser.TreeView
{
	partial class SelectionModes
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Wisej.Web.ImageListEntry imageListEntry21 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.apple.png", "apple");
            Wisej.Web.ImageListEntry imageListEntry22 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.banana.png", "banana");
            Wisej.Web.ImageListEntry imageListEntry23 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.carrot.png", "carrot");
            Wisej.Web.ImageListEntry imageListEntry24 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.cucumber.png", "cucumber");
            Wisej.Web.ImageListEntry imageListEntry25 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.milk.png", "milk");
            Wisej.Web.ImageListEntry imageListEntry26 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.orange.png", "orange");
            Wisej.Web.ImageListEntry imageListEntry27 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.yogurt.png", "yogurt");
            Wisej.Web.ImageListEntry imageListEntry28 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.dairy.png", "dairy");
            Wisej.Web.ImageListEntry imageListEntry29 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.fruit.png", "fruit");
            Wisej.Web.ImageListEntry imageListEntry30 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.vegetables.png", "vegetables");
            Wisej.Resources.ComponentResourceManager resources = new Wisej.Resources.ComponentResourceManager(typeof(SelectionModes));
            Wisej.Web.TreeNode treeNode21 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode22 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode23 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode24 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode25 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode26 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode27 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode28 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode29 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode30 = new Wisej.Web.TreeNode();
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.labelSelection = new Wisej.Web.Label();
            this.treeView1 = new Wisej.Web.TreeView();
            this.comboBoxSelectionMode = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.Images.AddRange(new Wisej.Web.ImageListEntry[] {
            imageListEntry21,
            imageListEntry22,
            imageListEntry23,
            imageListEntry24,
            imageListEntry25,
            imageListEntry26,
            imageListEntry27,
            imageListEntry28,
            imageListEntry29,
            imageListEntry30});
            // 
            // labelSelection
            // 
            this.labelSelection.Anchor = Wisej.Web.AnchorStyles.None;
            this.labelSelection.AutoSize = true;
            this.labelSelection.Location = new System.Drawing.Point(697, 101);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(35, 19);
            this.labelSelection.TabIndex = 1;
            this.labelSelection.Text = "One";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.treeView1.Location = new System.Drawing.Point(697, 125);
            this.treeView1.Name = "treeView1";
            treeNode21.Name = "Node0";
            treeNode22.Name = "Node4";
            treeNode22.Text = "Orlando";
            treeNode23.Name = "Node8";
            treeNode23.Text = "Miami";
            treeNode24.Name = "Node9";
            treeNode24.Text = "Jacksonville";
            treeNode21.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            treeNode21.Text = "Florida";
            treeNode25.Name = "Node1";
            treeNode26.Name = "Node6";
            treeNode26.Text = "Columbus";
            treeNode27.Name = "Node10";
            treeNode27.Text = "Cleveland";
            treeNode25.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode26,
            treeNode27});
            treeNode25.Text = "Ohio";
            treeNode28.Name = "Node2";
            treeNode29.Name = "Node7";
            treeNode29.Text = "Arlington";
            treeNode28.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode29});
            treeNode28.Text = "Texas";
            treeNode30.Name = "Node3";
            treeNode30.Text = "California";
            this.treeView1.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode21,
            treeNode25,
            treeNode28,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(262, 248);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new Wisej.Web.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // comboBoxSelectionMode
            // 
            this.comboBoxSelectionMode.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxSelectionMode.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxSelectionMode.Items.AddRange(new object[] {
            "One",
            "None",
            "MultiSimple",
            "MultiExtended"});
            this.comboBoxSelectionMode.LabelText = "Selection Mode";
            this.comboBoxSelectionMode.Location = new System.Drawing.Point(464, 212);
            this.comboBoxSelectionMode.Name = "comboBoxSelectionMode";
            this.comboBoxSelectionMode.Size = new System.Drawing.Size(190, 54);
            this.comboBoxSelectionMode.TabIndex = 0;
            this.comboBoxSelectionMode.Text = "One";
            this.comboBoxSelectionMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionMode_SelectedIndexChanged);
            // 
            // SelectionModes
            // 
            this.Controls.Add(this.comboBoxSelectionMode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelSelection);
            this.Name = "SelectionModes";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.ImageList imageList1;
		private Web.Label labelSelection;
		private Web.TreeView treeView1;
        private Web.ComboBox comboBoxSelectionMode;
    }
}
