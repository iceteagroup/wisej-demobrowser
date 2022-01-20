
namespace Wisej.DemoBrowser.Common.Components
{
	partial class OverviewSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverviewSample));
            this.labelTitle = new Wisej.Web.Label();
            this.label1Description = new Wisej.Web.Label();
            this.pictureBoxIcon = new Wisej.Web.PictureBox();
            this.buttonExplore = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.labelTitle.Location = new System.Drawing.Point(171, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new Wisej.Web.Padding(8);
            this.labelTitle.Size = new System.Drawing.Size(218, 31);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Sample Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1Description
            // 
            this.label1Description.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.label1Description.AutoSize = true;
            this.label1Description.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.label1Description.Location = new System.Drawing.Point(171, 45);
            this.label1Description.Name = "label1Description";
            this.label1Description.Padding = new Wisej.Web.Padding(8);
            this.label1Description.Size = new System.Drawing.Size(215, 276);
            this.label1Description.TabIndex = 9;
            this.label1Description.Text = resources.GetString("label1Description.Text");
            this.label1Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBoxIcon.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.pictureBoxIcon.ImageSource = "resource.wx/Wisej.DemoBrowser.Common/wisej.png";
            this.pictureBoxIcon.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Padding = new Wisej.Web.Padding(8);
            this.pictureBoxIcon.Size = new System.Drawing.Size(150, 109);
            this.pictureBoxIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // buttonExplore
            // 
            this.buttonExplore.Anchor = Wisej.Web.AnchorStyles.Right;
            this.buttonExplore.BackColor = System.Drawing.Color.FromName("@activeCaptionText");
            this.buttonExplore.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.buttonExplore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExplore.ImageSource = "icon-last";
            this.buttonExplore.Location = new System.Drawing.Point(395, 38);
            this.buttonExplore.Name = "buttonExplore";
            this.buttonExplore.Size = new System.Drawing.Size(142, 47);
            this.buttonExplore.TabIndex = 10;
            this.buttonExplore.Text = "Explore Sample";
            this.buttonExplore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExplore.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            this.buttonExplore.Click += new System.EventHandler(this.buttonExplore_Click);
            // 
            // OverviewSample
            // 
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1Description);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonExplore);
            this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;";
            this.Name = "OverviewSample";
            this.Padding = new Wisej.Web.Padding(8);
            this.Size = new System.Drawing.Size(550, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public Web.Label labelTitle;
		public Web.Label label1Description;
		public Web.PictureBox pictureBoxIcon;
		public Web.Button buttonExplore;
	}
}
