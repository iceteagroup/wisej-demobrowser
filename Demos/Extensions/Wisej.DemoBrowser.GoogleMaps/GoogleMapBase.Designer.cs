namespace Wisej.DemoBrowser.GoogleMaps
{
	partial class GoogleMapBase
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
			this.googleMap1 = new Wisej.Web.Ext.GoogleMaps.GoogleMap();
			this.SuspendLayout();
			// 
			// googleMap1
			// 
			this.googleMap1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.googleMap1.Location = new System.Drawing.Point(325, 29);
			this.googleMap1.Name = "googleMap1";
			this.googleMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"zoom\":4,\"center\":{\"lat\":0,\"lng\":0}}")));
			this.googleMap1.Size = new System.Drawing.Size(772, 417);
			this.googleMap1.TabIndex = 0;
			this.googleMap1.Text = "googleMap1";
			// 
			// GoogleMapBase
			// 
			this.Controls.Add(this.googleMap1);
			this.Name = "GoogleMapBase";
			this.Load += new System.EventHandler(this.GoogleMapBase_Load);
			this.ResumeLayout(false);

		}

		#endregion

		public Web.Ext.GoogleMaps.GoogleMap googleMap1;
	}
}
