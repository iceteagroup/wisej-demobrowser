namespace Wisej.DemoBrowser.FluentUIThemes
{
    partial class AppointmentPlanner
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
            this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.flexLayoutPanel2 = new Wisej.Web.FlexLayoutPanel();
            this.label1 = new Wisej.Web.Label();
            this.linkLabel1 = new Wisej.Web.LinkLabel();
            this.flexLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flexLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexLayoutPanel1
            // 
            this.flexLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flexLayoutPanel1.Controls.Add(this.flexLayoutPanel2);
            this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            this.flexLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flexLayoutPanel1.Name = "flexLayoutPanel1";
            this.flexLayoutPanel1.Size = new System.Drawing.Size(1422, 474);
            this.flexLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.flexLayoutPanel1.SetFillWeight(this.pictureBox1, 45);
            this.pictureBox1.ImageSource = "https://upload.wikimedia.org/wikipedia/commons/9/9f/Fluent_UI.svg";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 468);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
            // 
            // flexLayoutPanel2
            // 
            this.flexLayoutPanel2.Controls.Add(this.label1);
            this.flexLayoutPanel2.Controls.Add(this.linkLabel1);
            this.flexLayoutPanel1.SetFillWeight(this.flexLayoutPanel2, 55);
            this.flexLayoutPanel2.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
            this.flexLayoutPanel2.Location = new System.Drawing.Point(649, 3);
            this.flexLayoutPanel2.Name = "flexLayoutPanel2";
            this.flexLayoutPanel2.Size = new System.Drawing.Size(770, 468);
            this.flexLayoutPanel2.TabIndex = 2;
            this.flexLayoutPanel2.VerticalAlign = Wisej.Web.VerticalAlignment.Middle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("default", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(3, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Fluent UI Themees";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.linkLabel1.LinkArea = new Wisej.Web.LinkArea(29, 14);
            this.linkLabel1.Location = new System.Drawing.Point(3, 246);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(764, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.Text = "Check out the latest demo by Clicking Here.";
            this.linkLabel1.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AppointmentPlanner
            // 
            this.Controls.Add(this.flexLayoutPanel1);
            this.Name = "AppointmentPlanner";
            this.Load += new System.EventHandler(this.Ignite_Load);
            this.flexLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flexLayoutPanel2.ResumeLayout(false);
            this.flexLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.FlexLayoutPanel flexLayoutPanel1;
        private Web.PictureBox pictureBox1;
        private Web.FlexLayoutPanel flexLayoutPanel2;
        private Web.Label label1;
        private Web.LinkLabel linkLabel1;
    }
}
