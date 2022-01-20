namespace Wisej.DemoBrowser.SplitContainer
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
            this.splitContainer1 = new Wisej.Web.SplitContainer();
            this.textBox1 = new Wisej.Web.TextBox();
            this.monthCalendar1 = new Wisej.Web.MonthCalendar();
            this.splitContainer2 = new Wisej.Web.SplitContainer();
            this.textBox2 = new Wisej.Web.TextBox();
            this.monthCalendar2 = new Wisej.Web.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = Wisej.Web.AnchorStyles.None;
            this.splitContainer1.Location = new System.Drawing.Point(68, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.TabStop = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel2.TabStop = true;
            this.splitContainer1.Size = new System.Drawing.Size(633, 418);
            this.splitContainer1.SplitterDistance = 194;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox1.LabelText = "Vertical SplitContainer";
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 418);
            this.textBox1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.AutoSize = true;
            this.monthCalendar1.Dock = Wisej.Web.DockStyle.Fill;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.Size = new System.Drawing.Size(433, 418);
            this.monthCalendar1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = Wisej.Web.AnchorStyles.None;
            this.splitContainer2.Location = new System.Drawing.Point(722, 28);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = Wisej.Web.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.TabStop = true;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.monthCalendar2);
            this.splitContainer2.Panel2.TabStop = true;
            this.splitContainer2.Size = new System.Drawing.Size(633, 418);
            this.splitContainer2.SplitterDistance = 112;
            this.splitContainer2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Dock = Wisej.Web.DockStyle.Fill;
            this.textBox2.LabelText = "Horizontal SplitContainer";
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(633, 112);
            this.textBox2.TabIndex = 1;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.AutoSize = true;
            this.monthCalendar2.Dock = Wisej.Web.DockStyle.Fill;
            this.monthCalendar2.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.Size = new System.Drawing.Size(631, 298);
            this.monthCalendar2.TabIndex = 1;
            // 
            // Features
            // 
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Features";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Web.SplitContainer splitContainer1;
        private Web.SplitContainer splitContainer2;
        private Web.TextBox textBox1;
        private Web.MonthCalendar monthCalendar1;
        private Web.TextBox textBox2;
        private Web.MonthCalendar monthCalendar2;
    }
}
