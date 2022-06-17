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
            Wisej.Web.ImageListEntry imageListEntry1 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.apple.png", "apple");
            Wisej.Web.ImageListEntry imageListEntry2 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.banana.png", "banana");
            Wisej.Web.ImageListEntry imageListEntry3 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.carrot.png", "carrot");
            Wisej.Web.ImageListEntry imageListEntry4 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.cucumber.png", "cucumber");
            Wisej.Web.ImageListEntry imageListEntry5 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.milk.png", "milk");
            Wisej.Web.ImageListEntry imageListEntry6 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.orange.png", "orange");
            Wisej.Web.ImageListEntry imageListEntry7 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.yogurt.png", "yogurt");
            Wisej.Web.ImageListEntry imageListEntry8 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.dairy.png", "dairy");
            Wisej.Web.ImageListEntry imageListEntry9 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.fruit.png", "fruit");
            Wisej.Web.ImageListEntry imageListEntry10 = new Wisej.Web.ImageListEntry("resource.wx/Wisej.DemoBrowser.TreeView.Images.vegetables.png", "vegetables");
            Wisej.Web.TreeNode treeNode1 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode2 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode3 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode4 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode5 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode6 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode7 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode8 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode9 = new Wisej.Web.TreeNode();
            Wisej.Web.TreeNode treeNode10 = new Wisej.Web.TreeNode();
            this.imageList1 = new Wisej.Web.ImageList(this.components);
            this.labelSelection = new Wisej.Web.Label();
            this.treeView1 = new Wisej.Web.TreeView();
            this.comboBoxSelectionMode = new Wisej.Web.ComboBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.Images.AddRange(new Wisej.Web.ImageListEntry[] {
            imageListEntry1,
            imageListEntry2,
            imageListEntry3,
            imageListEntry4,
            imageListEntry5,
            imageListEntry6,
            imageListEntry7,
            imageListEntry8,
            imageListEntry9,
            imageListEntry10});
            // 
            // labelSelection
            // 
            this.labelSelection.Anchor = Wisej.Web.AnchorStyles.None;
            this.labelSelection.AutoSize = true;
            this.labelSelection.Location = new System.Drawing.Point(697, 101);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(28, 18);
            this.labelSelection.TabIndex = 12;
            this.labelSelection.Text = "One";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = Wisej.Web.AnchorStyles.None;
            this.treeView1.Location = new System.Drawing.Point(697, 125);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode2.Name = "Node4";
            treeNode2.Text = "Orlando";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Miami";
            treeNode4.Name = "Node9";
            treeNode4.Text = "Jacksonville";
            treeNode1.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            treeNode1.Text = "Florida";
            treeNode5.Name = "Node1";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Columbus";
            treeNode7.Name = "Node10";
            treeNode7.Text = "Cleveland";
            treeNode5.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode6,
            treeNode7});
            treeNode5.Text = "Ohio";
            treeNode8.Name = "Node2";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Arlington";
            treeNode8.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode9});
            treeNode8.Text = "Texas";
            treeNode10.Name = "Node3";
            treeNode10.Text = "California";
            this.treeView1.Nodes.AddRange(new Wisej.Web.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode8,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(262, 248);
            this.treeView1.TabIndex = 9;
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
            this.comboBoxSelectionMode.Size = new System.Drawing.Size(190, 53);
            this.comboBoxSelectionMode.TabIndex = 13;
            this.comboBoxSelectionMode.Text = "One";
            this.comboBoxSelectionMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectionMode_SelectedIndexChanged);
            // 
            // SelectionModes
            // 
            this.Controls.Add(this.comboBoxSelectionMode);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelSelection);
            this.MinimumSize = new System.Drawing.Size(513, 282);
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
