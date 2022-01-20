
namespace Wisej.DemoBrowser.Common.Components
{
    partial class Card
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
            this.button = new Wisej.Web.Button();
            this.panel1 = new Wisej.Web.Panel();
            this.panel3 = new Wisej.Web.Panel();
            this.labelContent = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.labelTitle = new Wisej.Web.Label();
            this.pictureBox = new Wisej.Web.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = Wisej.Web.DockStyle.Bottom;
            this.button.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/arrow-circle-right.svg";
            this.button.Location = new System.Drawing.Point(0, 116);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(296, 24);
            this.button.TabIndex = 0;
            this.button.Text = "Sample text";
            this.button.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Dock = Wisej.Web.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new Wisej.Web.Padding(20);
            this.panel1.Size = new System.Drawing.Size(296, 116);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelContent);
            this.panel3.Dock = Wisej.Web.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(84, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 44);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Dock = Wisej.Web.DockStyle.Fill;
            this.labelContent.Location = new System.Drawing.Point(0, 0);
            this.labelContent.Name = "labelContent";
            this.labelContent.Padding = new Wisej.Web.Padding(5);
            this.labelContent.Size = new System.Drawing.Size(192, 44);
            this.labelContent.TabIndex = 0;
            this.labelContent.Text = "Sample Content";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Dock = Wisej.Web.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(84, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 32);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = Wisej.Web.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new Wisej.Web.Padding(5);
            this.labelTitle.Size = new System.Drawing.Size(192, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Sample Title";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = Wisej.Web.DockStyle.Left;
            this.pictureBox.ImageSource = "resource.wx/Wisej.Ext.FontAwesome/user.svg";
            this.pictureBox.Location = new System.Drawing.Point(20, 20);
            this.pictureBox.Margin = new Wisej.Web.Padding(10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(64, 76);
            // 
            // Card
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button);
            this.CssStyle = "border-radius: 8px;";
            this.Name = "Card";
            this.Size = new System.Drawing.Size(296, 140);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Web.Button button;
        private Web.Panel panel1;
        private Web.PictureBox pictureBox;
        private Web.Panel panel3;
        private Web.Panel panel2;
        private Web.Label labelContent;
        private Web.Label labelTitle;
    }
}
