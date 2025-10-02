using Wisej.Web;

namespace Wisej.DemoBrowser.ChatControl.Controls
{
	public partial class FileMessageControl
	{
		#region Initialization

		private PictureBox pictureBox1;
		private System.ComponentModel.IContainer components;
		private Label labelFileName;

		private void InitializeComponent()
		{
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.labelFileName = new Wisej.Web.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anonymous = true;
			this.pictureBox1.AppearanceKey = "icon-light";
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.CssStyle = "border: 1px solid lightgray;";
			this.pictureBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.pictureBox1.ImageSource = "resource.wx/Wisej.Web.Ext.ChatControl/Images/Link.svg?color=#9B9B9B";
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new Wisej.Web.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 160);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// labelFileName
			// 
			this.labelFileName.Anonymous = true;
			this.labelFileName.Dock = Wisej.Web.DockStyle.Bottom;
			this.labelFileName.ForeColor = System.Drawing.Color.White;
			this.labelFileName.Location = new System.Drawing.Point(0, 160);
			this.labelFileName.Name = "labelFileName";
			this.labelFileName.Size = new System.Drawing.Size(300, 40);
			this.labelFileName.TabIndex = 3;
			this.labelFileName.Text = "Undefined";
			this.labelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FileMessageControl
			// 
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelFileName);
			this.Cursor = Wisej.Web.Cursors.Hand;
			this.MinimumSize = new System.Drawing.Size(150, 150);
			this.Name = "FileMessageControl";
			this.Size = new System.Drawing.Size(300, 200);
			this.Click += new System.EventHandler(this.FileMessageControl_Click);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
	}
}
