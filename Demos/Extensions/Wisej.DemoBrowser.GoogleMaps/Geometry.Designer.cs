namespace Wisej.DemoBrowser.GoogleMaps
{
	partial class Geometry
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
			this.googleMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"zoom\":4,\"center\":{\"lat\":34,\"lng\":-40.605}}")));
			this.googleMap1.Appear += new System.EventHandler(this.googleMap1_Appear);
			// 
			// Drawing
			// 
			this.Name = "Drawing";
			this.Load += new System.EventHandler(this.Geometry_Load);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
