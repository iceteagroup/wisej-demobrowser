namespace Wisej.DemoBrowser.Controls
{
	partial class LinksPopup
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
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.AutoSize = true;
			this.flexLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flexLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(97, 105, 108);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flexLayoutPanel1.MinimumSize = new System.Drawing.Size(200, 20);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(200, 20);
			this.flexLayoutPanel1.Spacing = 1;
			this.flexLayoutPanel1.TabIndex = 0;
			// 
			// LinksPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.flexLayoutPanel1);
			this.CssStyle = "border: 1px solid #D2D8DB;";
			this.Name = "LinksPopup";
			this.Size = new System.Drawing.Size(200, 20);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.FlexLayoutPanel flexLayoutPanel1;
	}
}
