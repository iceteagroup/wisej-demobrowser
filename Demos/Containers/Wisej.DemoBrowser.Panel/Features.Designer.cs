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
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoShow = Wisej.Web.PanelAutoShowMode.OnPointerOver;
			this.panel1.BackColor = System.Drawing.Color.FromName("@controlLight");
			this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel1.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = Wisej.Web.DockStyle.Left;
			this.panel1.HeaderPosition = Wisej.Web.HeaderPosition.Left;
			this.panel1.Location = new System.Drawing.Point(50, 50);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Wisej.Web.Padding(40);
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(295, 354);
			this.panel1.TabIndex = 0;
			this.panel1.TabStop = true;
			this.panel1.Text = "Panel";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(40, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 272);
			this.label1.TabIndex = 0;
			this.label1.Text = "HeaderPosition and HeaderAlignment Left with AutoShow OnPointerOver\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Honeydew;
			this.panel2.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel2.CollapseSide = Wisej.Web.HeaderPosition.Right;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = Wisej.Web.DockStyle.Left;
			this.panel2.HeaderAlignment = Wisej.Web.HorizontalAlignment.Right;
			this.panel2.HeaderPosition = Wisej.Web.HeaderPosition.Right;
			this.panel2.Location = new System.Drawing.Point(365, 50);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new Wisej.Web.Padding(40);
			this.panel2.ShowHeader = true;
			this.panel2.Size = new System.Drawing.Size(315, 354);
			this.panel2.TabIndex = 1;
			this.panel2.TabStop = true;
			this.panel2.Text = "Panel";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = Wisej.Web.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(40, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(205, 272);
			this.label3.TabIndex = 2;
			this.label3.Text = "HeaderPosition and HeaderAlignment Right with AutoShow OnClick";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.SeaShell;
			this.panel3.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panel3.CollapseSide = Wisej.Web.HeaderPosition.Left;
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = Wisej.Web.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(700, 50);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new Wisej.Web.Padding(40);
			this.panel3.ShowHeader = true;
			this.panel3.Size = new System.Drawing.Size(354, 354);
			this.panel3.TabIndex = 2;
			this.panel3.TabStop = true;
			this.panel3.Text = "Collapse Left";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = Wisej.Web.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(40, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 244);
			this.label2.TabIndex = 1;
			this.label2.Text = "HeaderAlignment Center and HeaderPosition Top with AutoShow OnClick";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Left;
			this.spacer1.Location = new System.Drawing.Point(345, 50);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(20, 354);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Left;
			this.spacer2.Location = new System.Drawing.Point(680, 50);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(20, 354);
			// 
			// Features
			// 
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(1086, 454);
			this.Name = "Features";
			this.Padding = new Wisej.Web.Padding(50);
			this.Size = new System.Drawing.Size(1086, 454);
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
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
	}
}
