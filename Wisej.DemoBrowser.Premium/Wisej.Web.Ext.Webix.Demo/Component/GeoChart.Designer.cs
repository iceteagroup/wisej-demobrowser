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
			this.SuspendLayout();
			// 
			// geoChart1
			// 
			this.geoChart1.Anchor = Wisej.Web.AnchorStyles.None;
			this.geoChart1.Location = new System.Drawing.Point(515, 38);
			this.geoChart1.Name = "geoChart1";
			this.geoChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("geoChart1.Options"))));
			this.geoChart1.Size = new System.Drawing.Size(500, 400);
			this.geoChart1.TabIndex = 0;
			this.geoChart1.Text = "geoChart1";
			// 
			// GeoChart
			// 
			this.Controls.Add(this.geoChart1);
			this.Name = "GeoChart";
			this.Controls.SetChildIndex(this.geoChart1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Webix.GeoChart geoChart1;
	}
}
