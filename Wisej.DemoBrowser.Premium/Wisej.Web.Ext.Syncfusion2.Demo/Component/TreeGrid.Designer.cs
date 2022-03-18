namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	partial class TreeGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeGrid));
            this.treeGrid1 = new Wisej.Web.Ext.Syncfusion2.TreeGrid();
            this.checkBoxResizing = new Wisej.Web.CheckBox();
            this.checkBoxReordering = new Wisej.Web.CheckBox();
            this.checkBoxDragAndDrop = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://ej2.syncfusion.com/javascript/documentation/treegrid/getting-started/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://ej2.syncfusion.com/javascript/documentation/api/treegrid/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDragAndDrop);
            this.groupBox1.Controls.Add(this.checkBoxResizing);
            this.groupBox1.Controls.Add(this.checkBoxReordering);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxReordering, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxResizing, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBoxDragAndDrop, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeGrid1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://ej2.syncfusion.com/demos/#/bootstrap5/tree-grid/treegrid-overview.html";
            // 
            // treeGrid1
            // 
            this.treeGrid1.Dock = Wisej.Web.DockStyle.Fill;
            this.treeGrid1.Location = new System.Drawing.Point(8, 8);
            this.treeGrid1.Name = "treeGrid1";
            this.treeGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeGrid1.Options"))));
            this.treeGrid1.Size = new System.Drawing.Size(1073, 542);
            this.treeGrid1.TabIndex = 0;
            this.treeGrid1.Text = "treeGrid1";
            // 
            // checkBoxResizing
            // 
            this.checkBoxResizing.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.checkBoxResizing.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxResizing.Location = new System.Drawing.Point(28, 86);
            this.checkBoxResizing.Name = "checkBoxResizing";
            this.checkBoxResizing.Size = new System.Drawing.Size(132, 24);
            this.checkBoxResizing.TabIndex = 6;
            this.checkBoxResizing.Text = "Allow resizing";
            // 
            // checkBoxReordering
            // 
            this.checkBoxReordering.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxReordering.Location = new System.Drawing.Point(28, 56);
            this.checkBoxReordering.Name = "checkBoxReordering";
            this.checkBoxReordering.Size = new System.Drawing.Size(146, 24);
            this.checkBoxReordering.TabIndex = 5;
            this.checkBoxReordering.Text = "Allow reordering";
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(28, 27);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(170, 24);
            this.checkBoxDragAndDrop.TabIndex = 9;
            this.checkBoxDragAndDrop.Text = "Allow drag-and-drop";
            // 
            // TreeGrid
            // 
            this.Name = "TreeGrid";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion2.TreeGrid treeGrid1;
        private CheckBox checkBoxDragAndDrop;
        private CheckBox checkBoxResizing;
        private CheckBox checkBoxReordering;
    }
}
