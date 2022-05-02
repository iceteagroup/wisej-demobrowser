namespace Wisej.DemoBrowser.FlowLayoutPanel
{
    partial class PersonCard
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
            this.pictureBoxPhoto = new Wisej.Web.PictureBox();
            this.labelName = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Anchor = Wisej.Web.AnchorStyles.None;
            this.pictureBoxPhoto.Anonymous = true;
            this.pictureBoxPhoto.CssStyle = "border-radius: 100px;\r\nborder: 2px solid gray;";
            this.pictureBoxPhoto.Location = new System.Drawing.Point(36, 18);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPhoto.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // labelName
            // 
            this.labelName.Anonymous = true;
            this.labelName.AutoEllipsis = true;
            this.labelName.Dock = Wisej.Web.DockStyle.Bottom;
            this.labelName.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelName.Location = new System.Drawing.Point(8, 124);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(157, 28);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Doe, John";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonCard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.labelName);
            this.CssStyle = "box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;\r\ntransition: left 1s, top 1s;";
            this.Cursor = Wisej.Web.Cursors.Hand;
            this.Name = "PersonCard";
            this.Padding = new Wisej.Web.Padding(8);
            this.Size = new System.Drawing.Size(173, 160);
            this.Load += new System.EventHandler(this.PersonCard_Load);
            this.Click += new System.EventHandler(this.PersonCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.PictureBox pictureBoxPhoto;
        private Web.Label labelName;
    }
}
