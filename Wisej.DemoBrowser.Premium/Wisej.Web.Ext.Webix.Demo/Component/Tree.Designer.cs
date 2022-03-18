namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Tree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tree));
            this.tree1 = new Wisej.Web.Ext.Webix.Tree();
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tree1);
            // 
            // tree1
            // 
            this.tree1.Anchor = Wisej.Web.AnchorStyles.None;
            this.tree1.Location = new System.Drawing.Point(418, 162);
            this.tree1.Name = "tree1";
            this.tree1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("tree1.Options"))));
            this.tree1.Size = new System.Drawing.Size(253, 235);
            this.tree1.TabIndex = 0;
            this.tree1.Text = "tree1";
            // 
            // Tree
            // 
            this.Name = "Tree";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Tree tree1;
	}
}
