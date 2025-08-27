using Wisej.Web;

namespace Wisej.DemoBrowser.ChatControl
{
	partial class UserChat
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
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.labelName = new Wisej.Web.Label();
			this.labelLastMessage = new Wisej.Web.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anonymous = true;
			this.pictureBox1.CssStyle = "border-radius: 30px;";
			this.pictureBox1.ImageSource = "Images\\Andrea.jpg";
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 40);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
			// 
			// labelName
			// 
			this.labelName.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.labelName.Anonymous = true;
			this.labelName.AutoEllipsis = true;
			this.labelName.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelName.Location = new System.Drawing.Point(54, 8);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(166, 18);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Lou Smith";
			// 
			// labelLastMessage
			// 
			this.labelLastMessage.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.labelLastMessage.Anonymous = true;
			this.labelLastMessage.AutoEllipsis = true;
			this.labelLastMessage.Font = new System.Drawing.Font("@default", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelLastMessage.ForeColor = System.Drawing.Color.FromName("@gray-400");
			this.labelLastMessage.Location = new System.Drawing.Point(54, 26);
			this.labelLastMessage.Name = "labelLastMessage";
			this.labelLastMessage.Size = new System.Drawing.Size(166, 18);
			this.labelLastMessage.TabIndex = 4;
			this.labelLastMessage.Text = "Yesterday";
			// 
			// UserChat
			// 
			this.BackColor = System.Drawing.Color.FromName("@window");
			this.Controls.Add(this.labelLastMessage);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.pictureBox1);
			this.CssStyle = "border-radius: 6px;\r\nbox-shadow: 0 .125rem .25rem rgba(0,0,0,.075);";
			this.Cursor = Wisej.Web.Cursors.Hand;
			this.Name = "UserChat";
			this.Size = new System.Drawing.Size(233, 56);
			this.Appear += new System.EventHandler(this.UserChat_Appear);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureBox pictureBox1;
		private Label labelName;
		private Label labelLastMessage;
	}
}
