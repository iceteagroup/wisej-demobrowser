using Wisej.Web;

namespace Wisej.DemoBrowser.ChatControl.Windows
{
	partial class VideoPreviewWindow
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
			this.video1 = new Wisej.Web.Video();
			this.SuspendLayout();
			// 
			// video1
			// 
			this.video1.Dock = Wisej.Web.DockStyle.Fill;
			this.video1.Location = new System.Drawing.Point(0, 0);
			this.video1.Name = "video1";
			this.video1.Size = new System.Drawing.Size(598, 351);
			this.video1.TabIndex = 0;
			this.video1.Volume = 0.5D;
			// 
			// VideoPreviewWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(598, 351);
			this.Controls.Add(this.video1);
			this.Name = "VideoPreviewWindow";
			this.Text = "VideoPreviewWindow";
			this.ResumeLayout(false);

		}

		#endregion

		private Video video1;
	}
}