namespace Wisej.DemoBrowser.Panel
{
    partial class Features
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
            this.label1 = new Wisej.Web.Label();
            this.panel2 = new Wisej.Web.Panel();
            this.label3 = new Wisej.Web.Label();
            this.panel3 = new Wisej.Web.Panel();
            this.label2 = new Wisej.Web.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = Wisej.Web.DockStyle.Left;
            this.panel1.HeaderPosition = Wisej.Web.HeaderPosition.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShowHeader = true;
            this.panel1.Size = new System.Drawing.Size(237, 474);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            this.panel1.Text = "Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = Wisej.Web.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 472);
            this.label1.TabIndex = 0;
            this.label1.Text = "HeaderPosition and HeaderAlignment Left";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.panel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel2.CollapseSide = Wisej.Web.HeaderPosition.Right;
            this.panel2.Controls.Add(this.label3);
            this.panel2.HeaderAlignment = Wisej.Web.HorizontalAlignment.Right;
            this.panel2.HeaderPosition = Wisej.Web.HeaderPosition.Right;
            this.panel2.Location = new System.Drawing.Point(280, 47);
            this.panel2.Name = "panel2";
            this.panel2.ShowHeader = true;
            this.panel2.Size = new System.Drawing.Size(862, 380);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            this.panel2.Text = "Panel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = Wisej.Web.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(832, 378);
            this.label3.TabIndex = 2;
            this.label3.Text = "HeaderPosition and HeaderAlignment Right";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel3.CollapseSide = Wisej.Web.HeaderPosition.Right;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = Wisej.Web.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1185, 0);
            this.panel3.Name = "panel3";
            this.panel3.ShowHeader = true;
            this.panel3.Size = new System.Drawing.Size(237, 474);
            this.panel3.TabIndex = 2;
            this.panel3.TabStop = true;
            this.panel3.Text = "Collapse Right";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = Wisej.Web.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 444);
            this.label2.TabIndex = 1;
            this.label2.Text = "HeaderAlignment Center and HeaderPosition Top";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Features
            // 
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Panel panel1;
        private Web.Panel panel2;
        private Web.Panel panel3;
        private Web.Label label1;
        private Web.Label label3;
        private Web.Label label2;
    }
}
