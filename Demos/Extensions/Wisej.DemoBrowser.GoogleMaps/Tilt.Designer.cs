namespace Wisej.DemoBrowser.GoogleMaps
{
	partial class Tilt
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
			this.buttonLeft = new Wisej.Web.Button();
			this.buttonRight = new Wisej.Web.Button();
			this.buttonUp = new Wisej.Web.Button();
			this.buttonDown = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// googleMap1
			// 
			this.googleMap1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"center\":{\"lat\":37.7893719,\"lng\":-122.3942},\"zoom\":17,\"heading\":320,\"tilt\":60,\"m" +
        "apId\":\"90f87356969d889c\"}")));
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonLeft.Location = new System.Drawing.Point(51, 199);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(200, 35);
			this.buttonLeft.TabIndex = 1;
			this.buttonLeft.Text = "Rotate Left";
			this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = Wisej.Web.AnchorStyles.Left;
			this.buttonRight.Location = new System.Drawing.Point(51, 240);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(200, 35);
			this.buttonRight.TabIndex = 2;
			this.buttonRight.Text = "Rotate Right";
			this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonUp.Location = new System.Drawing.Point(1171, 199);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(200, 35);
			this.buttonUp.TabIndex = 3;
			this.buttonUp.Text = "Tilt Up";
			this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = Wisej.Web.AnchorStyles.Right;
			this.buttonDown.Location = new System.Drawing.Point(1171, 240);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(200, 35);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.Text = "Tilt Down";
			this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
			// 
			// Tilt
			// 
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonLeft);
			this.Name = "Tilt";
			this.Load += new System.EventHandler(this.Tilt_Load);
			this.Controls.SetChildIndex(this.buttonLeft, 0);
			this.Controls.SetChildIndex(this.buttonRight, 0);
			this.Controls.SetChildIndex(this.buttonUp, 0);
			this.Controls.SetChildIndex(this.buttonDown, 0);
			this.Controls.SetChildIndex(this.googleMap1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonLeft;
		private Web.Button buttonRight;
		private Web.Button buttonUp;
		private Web.Button buttonDown;
	}
}
