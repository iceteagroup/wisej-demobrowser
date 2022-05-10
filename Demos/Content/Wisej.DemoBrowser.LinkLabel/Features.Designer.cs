namespace Wisej.DemoBrowser.LinkLabel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.linkLabel1 = new Wisej.Web.LinkLabel();
			this.linkLabel2 = new Wisej.Web.LinkLabel();
			this.linkLabel3 = new Wisej.Web.LinkLabel();
			this.linkLabel4 = new Wisej.Web.LinkLabel();
			this.linkLabel5 = new Wisej.Web.LinkLabel();
			this.linkLabel6 = new Wisej.Web.LinkLabel();
			this.linkLabel7 = new Wisej.Web.LinkLabel();
			this.linkLabel8 = new Wisej.Web.LinkLabel();
			this.linkLabel9 = new Wisej.Web.LinkLabel();
			this.linkLabel10 = new Wisej.Web.LinkLabel();
			this.panel1 = new Wisej.Web.Panel();
			this.panel2 = new Wisej.Web.Panel();
			this.panel3 = new Wisej.Web.Panel();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(50, 76);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(176, 18);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.Text = "LinkBehavior = SystemDefault";
			this.linkLabel1.Click += new System.EventHandler(this.LinkLabel_Click);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkBehavior = Wisej.Web.LinkBehavior.AlwaysUnderline;
			this.linkLabel2.Location = new System.Drawing.Point(50, 126);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(188, 18);
			this.linkLabel2.TabIndex = 1;
			this.linkLabel2.Text = "LinkBehavior = AlwaysUnderline";
			this.linkLabel2.Click += new System.EventHandler(this.LinkLabel_Click);
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.LinkBehavior = Wisej.Web.LinkBehavior.NeverUnderline;
			this.linkLabel3.Location = new System.Drawing.Point(50, 176);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(183, 18);
			this.linkLabel3.TabIndex = 2;
			this.linkLabel3.Text = "LinkBehavior = NeverUnderline";
			this.linkLabel3.Click += new System.EventHandler(this.LinkLabel_Click);
			// 
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.LinkBehavior = Wisej.Web.LinkBehavior.NeverUnderline;
			this.linkLabel4.Location = new System.Drawing.Point(50, 226);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(176, 18);
			this.linkLabel4.TabIndex = 3;
			this.linkLabel4.Text = "LinkBehavior = SystemDefault\r\n";
			this.linkLabel4.Click += new System.EventHandler(this.LinkLabel_Click);
			// 
			// linkLabel5
			// 
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.Location = new System.Drawing.Point(55, 78);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(69, 18);
			this.linkLabel5.TabIndex = 4;
			this.linkLabel5.Text = "Color [Red]";
			// 
			// linkLabel6
			// 
			this.linkLabel6.ActiveLinkColor = System.Drawing.Color.Magenta;
			this.linkLabel6.AutoSize = true;
			this.linkLabel6.Location = new System.Drawing.Point(55, 175);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(98, 18);
			this.linkLabel6.TabIndex = 5;
			this.linkLabel6.Text = "Color [Magenta]";
			// 
			// linkLabel7
			// 
			this.linkLabel7.ActiveLinkColor = System.Drawing.Color.Peru;
			this.linkLabel7.AutoSize = true;
			this.linkLabel7.Location = new System.Drawing.Point(55, 123);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(73, 18);
			this.linkLabel7.TabIndex = 6;
			this.linkLabel7.Text = "Color [Peru]";
			// 
			// linkLabel8
			// 
			this.linkLabel8.ActiveLinkColor = System.Drawing.Color.OliveDrab;
			this.linkLabel8.AutoSize = true;
			this.linkLabel8.Location = new System.Drawing.Point(55, 225);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(104, 18);
			this.linkLabel8.TabIndex = 7;
			this.linkLabel8.Text = "Color [OliveDrap]";
			// 
			// linkLabel9
			// 
			this.linkLabel9.AllowHtml = true;
			this.linkLabel9.Location = new System.Drawing.Point(41, 125);
			this.linkLabel9.Name = "linkLabel9";
			this.linkLabel9.Size = new System.Drawing.Size(132, 23);
			this.linkLabel9.TabIndex = 8;
			this.linkLabel9.Text = "<a href=\"https://docs.wisej.com/docs/controls/content/linklabel\" style=\"color:gra" +
    "y;text-decoration:underline overline dotted red;\">AllowHTML = true &#x1F4AA;</a>" +
    "";
			// 
			// linkLabel10
			// 
			this.linkLabel10.ActiveLinkColor = System.Drawing.Color.Purple;
			this.linkLabel10.AutoSize = true;
			this.linkLabel10.LinkArea = new Wisej.Web.LinkArea(0, 4);
			this.linkLabel10.Location = new System.Drawing.Point(41, 177);
			this.linkLabel10.Name = "linkLabel10";
			this.linkLabel10.Size = new System.Drawing.Size(54, 18);
			this.linkLabel10.TabIndex = 9;
			this.linkLabel10.Text = "LinkArea";
			this.linkLabel10.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.linkLabel4);
			this.panel1.Controls.Add(this.linkLabel3);
			this.panel1.Controls.Add(this.linkLabel2);
			this.panel1.Controls.Add(this.linkLabel1);
			this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
			this.panel1.Location = new System.Drawing.Point(23, 23);
			this.panel1.Margin = new Wisej.Web.Padding(3, 3, 20, 3);
			this.panel1.MinimumSize = new System.Drawing.Size(250, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(290, 321);
			this.panel1.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.linkLabel8);
			this.panel2.Controls.Add(this.linkLabel7);
			this.panel2.Controls.Add(this.linkLabel6);
			this.panel2.Controls.Add(this.linkLabel5);
			this.flowLayoutPanel1.SetFillWeight(this.panel2, 1);
			this.panel2.Location = new System.Drawing.Point(336, 23);
			this.panel2.Margin = new Wisej.Web.Padding(3, 3, 20, 3);
			this.panel2.MinimumSize = new System.Drawing.Size(250, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(289, 321);
			this.panel2.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.linkLabel10);
			this.panel3.Controls.Add(this.linkLabel9);
			this.flowLayoutPanel1.SetFillWeight(this.panel3, 1);
			this.panel3.Location = new System.Drawing.Point(648, 23);
			this.panel3.Margin = new Wisej.Web.Padding(3, 3, 20, 3);
			this.panel3.MinimumSize = new System.Drawing.Size(250, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(289, 321);
			this.panel3.TabIndex = 12;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 51);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(20, 20, 0, 20);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(957, 367);
			this.flowLayoutPanel1.TabIndex = 13;
			// 
			// Features
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Features";
			this.Size = new System.Drawing.Size(1029, 447);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.LinkLabel linkLabel1;
        private Web.LinkLabel linkLabel2;
        private Web.LinkLabel linkLabel3;
        private Web.LinkLabel linkLabel4;
        private Web.LinkLabel linkLabel5;
        private Web.LinkLabel linkLabel6;
        private Web.LinkLabel linkLabel7;
        private Web.LinkLabel linkLabel8;
        private Web.LinkLabel linkLabel9;
        private Web.LinkLabel linkLabel10;
		private Web.Panel panel1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
		private Web.Panel panel2;
		private Web.Panel panel3;
	}
}
