using Wisej.Web;

namespace Wisej.DemoBrowser.ChatControl.Controls
{
	public partial class LinkMessageControl
	{
		#region Initialization

		private PictureBox pictureBoxPreview;
		private Label labelLinkName;

		private void InitializeComponent()
		{
			this.pictureBoxPreview = new Wisej.Web.PictureBox();
			this.labelLinkName = new Wisej.Web.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxPreview
			// 
			this.pictureBoxPreview.Anonymous = true;
			this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
			this.pictureBoxPreview.Dock = Wisej.Web.DockStyle.Fill;
			this.pictureBoxPreview.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxPreview.Name = "pictureBoxPreview";
			this.pictureBoxPreview.Size = new System.Drawing.Size(300, 150);
			this.pictureBoxPreview.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// labelLinkName
			// 
			this.labelLinkName.Anonymous = true;
			this.labelLinkName.Dock = Wisej.Web.DockStyle.Bottom;
			this.labelLinkName.ForeColor = System.Drawing.Color.FromName("@activeCaptionText");
			this.labelLinkName.Location = new System.Drawing.Point(0, 150);
			this.labelLinkName.Name = "labelLinkName";
			this.labelLinkName.Size = new System.Drawing.Size(300, 50);
			this.labelLinkName.TabIndex = 1;
			this.labelLinkName.Text = "Undefined";
			this.labelLinkName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LinkMessageControl
			// 
			this.Controls.Add(this.pictureBoxPreview);
			this.Controls.Add(this.labelLinkName);
			this.Cursor = Wisej.Web.Cursors.Hand;
			this.MinimumSize = new System.Drawing.Size(150, 0);
			this.Name = "LinkMessageControl";
			this.Size = new System.Drawing.Size(300, 200);
			this.Click += new System.EventHandler(this.LinkMessageControl_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
	}
}
