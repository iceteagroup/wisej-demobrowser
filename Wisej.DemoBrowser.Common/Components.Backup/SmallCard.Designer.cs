
namespace Wisej.DemoBrowser.Common.Components
{
    partial class SmallCard
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
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.labelContent = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.button = new Wisej.Web.Button();
            this.pictureBox = new Wisej.Web.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(434, 72);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelContent);
            this.panel2.Dock = Wisej.Web.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(59, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new Wisej.Web.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(319, 32);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // labelContent
            // 
            this.labelContent.AutoEllipsis = true;
            this.labelContent.AutoSize = true;
            this.labelContent.Dock = Wisej.Web.DockStyle.Fill;
            this.labelContent.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContent.Location = new System.Drawing.Point(10, 0);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(309, 32);
            this.labelContent.TabIndex = 0;
            this.labelContent.Text = "Sample Content";
            this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelContent.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button);
            this.panel3.Dock = Wisej.Web.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(378, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 32);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // button
            // 
            this.button.Dock = Wisej.Web.DockStyle.Fill;
            this.button.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/angle-right.svg";
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(36, 32);
            this.button.TabIndex = 0;
            this.button.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBox.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/check.svg";
            this.pictureBox.Location = new System.Drawing.Point(20, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(39, 32);
            // 
            // SmallCard
            // 
            this.Controls.Add(this.panel1);
            this.Name = "SmallCard";
            this.Size = new System.Drawing.Size(434, 72);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.PictureBox pictureBox;
        private Web.Label labelContent;
        private Web.Panel panel3;
        public Web.Button button;
    }
}
