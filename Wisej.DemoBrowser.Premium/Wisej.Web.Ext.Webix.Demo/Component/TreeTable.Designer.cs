namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TreeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeTable));
            this.treeTable1 = new Wisej.Web.Ext.Webix.TreeTable();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeTable1);
            // 
            // treeTable1
            // 
            this.treeTable1.Dock = Wisej.Web.DockStyle.Fill;
            this.treeTable1.Location = new System.Drawing.Point(8, 8);
            this.treeTable1.Name = "treeTable1";
            this.treeTable1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeTable1.Options"))));
            this.treeTable1.Size = new System.Drawing.Size(1073, 542);
            this.treeTable1.TabIndex = 11;
            this.treeTable1.Text = "treeTable1";
            // 
            // TreeTable
            // 
            this.Name = "TreeTable";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.TreeTable treeTable1;
	}
}
