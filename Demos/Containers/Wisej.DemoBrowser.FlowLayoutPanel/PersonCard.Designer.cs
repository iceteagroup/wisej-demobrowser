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
            this.pbPhoto = new Wisej.Web.PictureBox();
            this.panel1 = new Wisej.Web.Panel();
            this.lblName = new Wisej.Web.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.Dock = Wisej.Web.DockStyle.Left;
            this.pbPhoto.Location = new System.Drawing.Point(8, 8);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(52, 43);
            this.pbPhoto.SizeMode = Wisej.Web.PictureBoxSizeMode.Cover;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(60, 8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(6);
            this.panel1.Size = new System.Drawing.Size(332, 43);
            this.panel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = Wisej.Web.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("defaultBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblName.Location = new System.Drawing.Point(6, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(320, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PersonCard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(215, 215, 215);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbPhoto);
            this.CssStyle = "border-radius: 8px;";
            this.Name = "PersonCard";
            this.Padding = new Wisej.Web.Padding(8);
            this.Size = new System.Drawing.Size(400, 59);
            this.Load += new System.EventHandler(this.PersonCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.PictureBox pbPhoto;
        private Web.Panel panel1;
        private Web.Label lblName;
    }
}
