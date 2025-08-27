namespace Wisej.DemoBrowser.GoogleMaps
{
	partial class HeatMap
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
            this.SuspendLayout();
            // 
            // googleMap1
            // 
            this.googleMap1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)));
            this.googleMap1.Dock = Wisej.Web.DockStyle.Fill;
            this.googleMap1.Location = new System.Drawing.Point(16, 16);
            this.googleMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"zoom\":13,\"center\":{\"Lng\":-122.433523,\"Lat\":37.774546}}")));
            this.googleMap1.Size = new System.Drawing.Size(1390, 442);
            this.googleMap1.Appear += new System.EventHandler(this.googleMap1_Appear);
            // 
            // HeatMap
            // 
            this.Name = "HeatMap";
            this.Padding = new Wisej.Web.Padding(16);
            this.ResumeLayout(false);

		}

		#endregion
	}
}
