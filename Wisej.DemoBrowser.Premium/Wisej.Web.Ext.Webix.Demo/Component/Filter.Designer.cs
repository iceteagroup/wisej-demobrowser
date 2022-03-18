namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Filter
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
            this.filter1 = new Wisej.Web.Ext.Webix.Filter();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.filter1);
            // 
            // filter1
            // 
            this.filter1.Anchor = Wisej.Web.AnchorStyles.None;
            this.filter1.Location = new System.Drawing.Point(294, 79);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(500, 400);
            this.filter1.TabIndex = 0;
            this.filter1.Text = "filter1";
            // 
            // Filter
            // 
            this.Name = "Filter";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Filter filter1;
	}
}
