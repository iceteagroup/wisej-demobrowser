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
			this.SuspendLayout();
			// 
			// treeTable1
			// 
			this.treeTable1.Anchor = Wisej.Web.AnchorStyles.None;
			this.treeTable1.Location = new System.Drawing.Point(465, 38);
			this.treeTable1.Name = "treeTable1";
			this.treeTable1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeTable1.Options"))));
			this.treeTable1.Size = new System.Drawing.Size(600, 400);
			this.treeTable1.TabIndex = 11;
			this.treeTable1.Text = "treeTable1";
			// 
			// TreeTable
			// 
			this.Controls.Add(this.treeTable1);
			this.Name = "TreeTable";
			this.Controls.SetChildIndex(this.treeTable1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.TreeTable treeTable1;
	}
}
