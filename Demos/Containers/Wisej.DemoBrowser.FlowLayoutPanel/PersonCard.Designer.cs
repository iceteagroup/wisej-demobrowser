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
            this.labelSubject = new Wisej.Web.Label();
            this.labelName = new Wisej.Web.Label();
            this.labelTime = new Wisej.Web.Label();
            this.checkBoxMark = new Wisej.Web.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Anonymous = true;
            this.pictureBoxPhoto.CssStyle = "border-radius: 100px;\r\nborder: 2px solid gray;";
            this.pictureBoxPhoto.Location = new System.Drawing.Point(11, 5);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPhoto.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // labelSubject
            // 
            this.labelSubject.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.labelSubject.Anonymous = true;
            this.labelSubject.AutoEllipsis = true;
            this.labelSubject.Location = new System.Drawing.Point(11, 62);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(278, 25);
            this.labelSubject.TabIndex = 4;
            this.labelSubject.Text = "Some subject...";
            this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.labelName.Anonymous = true;
            this.labelName.AutoEllipsis = true;
            this.labelName.Location = new System.Drawing.Point(67, 5);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new Wisej.Web.Padding(8, 0, 32, 0);
            this.labelName.Size = new System.Drawing.Size(126, 50);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Doe, John";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.labelTime.Anonymous = true;
            this.labelTime.Location = new System.Drawing.Point(208, 5);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(56, 50);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "7:28 AM";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxMark
            // 
            this.checkBoxMark.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxMark.Location = new System.Drawing.Point(270, 19);
            this.checkBoxMark.Name = "checkBoxMark";
            this.checkBoxMark.Size = new System.Drawing.Size(30, 23);
            this.checkBoxMark.TabIndex = 6;
            this.checkBoxMark.CheckedChanged += new System.EventHandler(this.checkBoxMark_CheckedChanged);
            // 
            // PersonCard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.checkBoxMark);
            this.CssStyle = "box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;";
            this.Cursor = Wisej.Web.Cursors.Hand;
            this.Name = "PersonCard";
            this.Padding = new Wisej.Web.Padding(8);
            this.Size = new System.Drawing.Size(300, 98);
            this.Load += new System.EventHandler(this.PersonCard_Load);
            this.Click += new System.EventHandler(this.PersonCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Web.PictureBox pictureBoxPhoto;
        private Web.Label labelSubject;
        private Web.Label labelName;
        private Web.Label labelTime;
        private Web.CheckBox checkBoxMark;
    }
}
