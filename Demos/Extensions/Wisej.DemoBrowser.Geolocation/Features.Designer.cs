namespace Wisej.DemoBrowser.Geolocation
{
	partial class Features
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
			this.components = new System.ComponentModel.Container();
			this.geolocation1 = new Wisej.Ext.Geolocation.Geolocation(this.components);
			this.buttonLocation = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// geolocation1
			// 
			this.geolocation1.MaximumAge = ((long)(-1));
			this.geolocation1.Timeout = ((long)(15000));
			// 
			// buttonLocation
			// 
			this.buttonLocation.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonLocation.Location = new System.Drawing.Point(611, 220);
			this.buttonLocation.Name = "buttonLocation";
			this.buttonLocation.Size = new System.Drawing.Size(200, 35);
			this.buttonLocation.TabIndex = 0;
			this.buttonLocation.Text = "Get Location";
			this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
			// 
			// Features
			// 
			this.Controls.Add(this.buttonLocation);
			this.Name = "Features";
			this.ResumeLayout(false);

		}

		#endregion

		private Ext.Geolocation.Geolocation geolocation1;
		private Web.Button buttonLocation;
	}
}
