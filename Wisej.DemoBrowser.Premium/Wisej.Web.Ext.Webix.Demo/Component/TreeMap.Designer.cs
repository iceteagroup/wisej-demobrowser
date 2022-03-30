namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class TreeMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeMap));
            this.treeMap1 = new Wisej.Web.Ext.Webix.TreeMap();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.treeMap1);
            // 
            // treeMap1
            // 
            this.treeMap1.Anchor = Wisej.Web.AnchorStyles.None;
            this.treeMap1.Location = new System.Drawing.Point(294, 79);
            this.treeMap1.Name = "treeMap1";
            this.treeMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("treeMap1.Options"))));
            this.treeMap1.Size = new System.Drawing.Size(500, 400);
            this.treeMap1.TabIndex = 11;
            this.treeMap1.Text = "treeMap1";
            // 
            // TreeMap
            // 
            this.Name = "TreeMap";
            this.Load += new System.EventHandler(this.TreeMap_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.TreeMap treeMap1;
	}
}
