
namespace Wisej.DemoBrowser.Common.Components
{
	partial class OverviewDocItem
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
			this.labelItemName = new Wisej.Web.Label();
			this.buttonDocsLink = new Wisej.Web.Button();
			this.pictureBoxIcon = new Wisej.Web.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// labelItemName
			// 
			this.labelItemName.Dock = Wisej.Web.DockStyle.Fill;
			this.labelItemName.Font = new System.Drawing.Font("default", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelItemName.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.labelItemName.Location = new System.Drawing.Point(98, 8);
			this.labelItemName.Name = "labelItemName";
			this.labelItemName.Size = new System.Drawing.Size(189, 49);
			this.labelItemName.TabIndex = 4;
			this.labelItemName.Text = "ItemName";
			this.labelItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonDocsLink
			// 
			this.buttonDocsLink.BackColor = System.Drawing.Color.FromName("@activeCaptionText");
			this.buttonDocsLink.Dock = Wisej.Web.DockStyle.Right;
			this.buttonDocsLink.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.buttonDocsLink.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/book.svg";
			this.buttonDocsLink.Location = new System.Drawing.Point(287, 8);
			this.buttonDocsLink.Name = "buttonDocsLink";
			this.buttonDocsLink.Padding = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonDocsLink.Size = new System.Drawing.Size(155, 49);
			this.buttonDocsLink.TabIndex = 5;
			this.buttonDocsLink.Text = "Documentation";
			this.buttonDocsLink.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.buttonDocsLink.Click += new System.EventHandler(this.buttonDocsLink_Click);
			// 
			// pictureBoxIcon
			// 
			this.pictureBoxIcon.Dock = Wisej.Web.DockStyle.Left;
			this.pictureBoxIcon.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
			this.pictureBoxIcon.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/pie-chart.svg";
			this.pictureBoxIcon.Location = new System.Drawing.Point(8, 8);
			this.pictureBoxIcon.Name = "pictureBoxIcon";
			this.pictureBoxIcon.Padding = new Wisej.Web.Padding(8);
			this.pictureBoxIcon.Size = new System.Drawing.Size(90, 49);
			this.pictureBoxIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// OverviewDocItem
			// 
			this.Controls.Add(this.labelItemName);
			this.Controls.Add(this.buttonDocsLink);
			this.Controls.Add(this.pictureBoxIcon);
			this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;";
			this.Name = "OverviewDocItem";
			this.Padding = new Wisej.Web.Padding(8);
			this.Size = new System.Drawing.Size(450, 65);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public Web.Label labelItemName;
		public Web.Button buttonDocsLink;
		public Web.PictureBox pictureBoxIcon;
	}
}
