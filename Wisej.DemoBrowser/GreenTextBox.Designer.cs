namespace Wisej.DemoBrowser
{
	partial class GreenTextBox
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

		#region Wisej.NET Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxGreen = new Wisej.Web.TextBox();
			this.SuspendLayout();
			//
			// textBoxGreen
			//
			this.textBoxGreen.Anchor = Wisej.Web.AnchorStyles.None;
			this.textBoxGreen.BackColor = System.Drawing.Color.Green;
			this.textBoxGreen.LabelText = "Green TextBox";
			this.textBoxGreen.Location = new System.Drawing.Point(456, 263);
			this.textBoxGreen.Name = "textBoxGreen";
			this.textBoxGreen.Size = new System.Drawing.Size(304, 53);
			this.textBoxGreen.TabIndex = 0;
			this.textBoxGreen.Watermark = "TEST!!!";
			//
			// GreenTextBox
			//
			this.Controls.Add(this.textBoxGreen);
			this.Name = "GreenTextBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.TextBox textBoxGreen;
	}
}
