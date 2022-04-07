namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class GeoChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoChart));
            this.geoChart1 = new Wisej.Web.Ext.Webix.GeoChart();
            this.checkBoxRemoveMissed = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://docs.webix.com/desktop__geochart.html";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery?search=#geochart";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.geochart.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.geoChart1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRemoveMissed);
            // 
            // geoChart1
            // 
            this.geoChart1.Dock = Wisej.Web.DockStyle.Fill;
            this.geoChart1.Location = new System.Drawing.Point(8, 8);
            this.geoChart1.Name = "geoChart1";
            this.geoChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("geoChart1.Options"))));
            this.geoChart1.Size = new System.Drawing.Size(1073, 542);
            this.geoChart1.TabIndex = 0;
            this.geoChart1.Text = "geoChart1";
            // 
            // checkBoxRemoveMissed
            // 
            this.checkBoxRemoveMissed.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxRemoveMissed.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxRemoveMissed.AutoSize = false;
            this.checkBoxRemoveMissed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRemoveMissed.Location = new System.Drawing.Point(3, 3);
            this.checkBoxRemoveMissed.Name = "checkBoxRemoveMissed";
            this.checkBoxRemoveMissed.Size = new System.Drawing.Size(212, 26);
            this.checkBoxRemoveMissed.TabIndex = 4;
            this.checkBoxRemoveMissed.Text = "Remove Missed";
            // 
            // GeoChart
            // 
            this.Name = "GeoChart";
            this.Load += new System.EventHandler(this.GeoChart_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.GeoChart geoChart1;
        private CheckBox checkBoxRemoveMissed;
    }
}
