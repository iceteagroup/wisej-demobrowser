namespace Wisej.DemoBrowser.OfficeViewer
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
            this.officeViewer1 = new Wisej.Web.Ext.OfficeViewer.OfficeViewer();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.button3 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button1 = new Wisej.Web.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // officeViewer1
            // 
            this.officeViewer1.Dock = Wisej.Web.DockStyle.Fill;
            this.officeViewer1.Location = new System.Drawing.Point(107, 0);
            this.officeViewer1.Name = "officeViewer1";
            this.officeViewer1.Size = new System.Drawing.Size(1315, 474);
            this.officeViewer1.TabIndex = 1;
            this.officeViewer1.Text = "officeViewer1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(107, 474);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = Wisej.Web.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(33, 115, 70);
            this.flowLayoutPanel1.SetFillWeight(this.button3, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button3, true);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageSource = "resource.wx/Wisej.DemoBrowser.OfficeViewer/excel.svg";
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "Excel";
            this.button3.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = Wisej.Web.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(210, 71, 38);
            this.flowLayoutPanel1.SetFillWeight(this.button2, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button2, true);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageSource = "resource.wx/Wisej.DemoBrowser.OfficeViewer/powerpoint.svg";
            this.button2.Location = new System.Drawing.Point(3, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "PowerPoint";
            this.button2.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(43, 87, 154);
            this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.button1, true);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageSource = "resource.wx/Wisej.DemoBrowser.OfficeViewer/word.svg";
            this.button1.Location = new System.Drawing.Point(3, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Word";
            this.button1.TextImageRelation = Wisej.Web.TextImageRelation.ImageAboveText;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Features
            // 
            this.Controls.Add(this.officeViewer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(978, 340);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.Ext.OfficeViewer.OfficeViewer officeViewer1;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Button button3;
        private Web.Button button2;
        private Web.Button button1;
    }
}
