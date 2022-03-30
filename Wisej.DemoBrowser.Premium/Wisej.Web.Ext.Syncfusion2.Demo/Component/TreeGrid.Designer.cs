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
            this.flowLayoutPanel1.SuspendLayout();
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
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeGrid1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxDragAndDrop);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxReordering);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxResizing);
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
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxResizing, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxResizing, true);
            this.checkBoxResizing.Location = new System.Drawing.Point(3, 89);
            this.checkBoxResizing.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxResizing.Name = "checkBoxResizing";
            this.checkBoxResizing.Size = new System.Drawing.Size(212, 24);
            this.checkBoxResizing.TabIndex = 6;
            this.checkBoxResizing.Text = "Allow Resizing";
            // 
            // checkBoxReordering
            // 
            this.checkBoxReordering.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxReordering, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxReordering, true);
            this.checkBoxReordering.Location = new System.Drawing.Point(3, 46);
            this.checkBoxReordering.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
            this.checkBoxReordering.Name = "checkBoxReordering";
            this.checkBoxReordering.Size = new System.Drawing.Size(212, 24);
            this.checkBoxReordering.TabIndex = 5;
            this.checkBoxReordering.Text = "Allow Reordering";
            // 
            // checkBoxDragAndDrop
            // 
            this.checkBoxDragAndDrop.Appearance = Wisej.Web.Appearance.Switch;
            this.flowLayoutPanel1.SetFillWeight(this.checkBoxDragAndDrop, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.checkBoxDragAndDrop, true);
            this.checkBoxDragAndDrop.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDragAndDrop.Name = "checkBoxDragAndDrop";
            this.checkBoxDragAndDrop.Size = new System.Drawing.Size(212, 24);
            this.checkBoxDragAndDrop.TabIndex = 9;
            this.checkBoxDragAndDrop.Text = "Allow Drag-and-Drop";
            // 
            // TreeGrid
            // 
            this.Name = "TreeGrid";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
