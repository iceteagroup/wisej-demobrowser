namespace Wisej.DemoBrowser.Tooltip
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
            this.components = new System.ComponentModel.Container();
            this.toolTipDefault = new Wisej.Web.ToolTip(this.components);
            this.button1 = new Wisej.Web.Button();
            this.toolTipIcon = new Wisej.Web.ToolTip(this.components);
            this.comboBoxIcon = new Wisej.Web.ComboBox();
            this.button2 = new Wisej.Web.Button();
            this.progressBar1 = new Wisej.Web.ProgressBar();
            this.comboBoxAlignment = new Wisej.Web.ComboBox();
            this.textBox1 = new Wisej.Web.TextBox();
            this.toolTipAutoPopDelay = new Wisej.Web.ToolTip(this.components);
            this.toolTipHtml = new Wisej.Web.ToolTip(this.components);
            this.toolTipCustomColors = new Wisej.Web.ToolTip(this.components);
            this.toolTipAlignment = new Wisej.Web.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(211, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Default";
            this.toolTipDefault.SetToolTip(this.button1, "Default ToolTip");
            // 
            // toolTipIcon
            // 
            this.toolTipIcon.Alignment = Wisej.Web.Placement.LeftTop;
            // 
            // comboBoxIcon
            // 
            this.comboBoxIcon.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxIcon.Location = new System.Drawing.Point(1011, 292);
            this.comboBoxIcon.Name = "comboBoxIcon";
            this.comboBoxIcon.Size = new System.Drawing.Size(200, 30);
            this.comboBoxIcon.TabIndex = 13;
            this.toolTipIcon.SetToolTip(this.comboBoxIcon, "ToolTip Icon");
            this.comboBoxIcon.Watermark = "ToolTip Icon";
            this.comboBoxIcon.SelectedIndexChanged += new System.EventHandler(this.comboBoxIcon_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = Wisej.Web.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(1011, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "HTML";
            this.toolTipHtml.SetToolTip(this.button2, "<b>Hello,</b> <i>World!</i>");
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(611, 153);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 40);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Text = "AutoPop: Click to Start";
            this.toolTipAutoPopDelay.SetToolTip(this.progressBar1, "AutoPopDelay: 3 Seconds");
            this.progressBar1.Value = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // comboBoxAlignment
            // 
            this.comboBoxAlignment.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxAlignment.Location = new System.Drawing.Point(611, 292);
            this.comboBoxAlignment.Name = "comboBoxAlignment";
            this.comboBoxAlignment.Size = new System.Drawing.Size(200, 30);
            this.comboBoxAlignment.TabIndex = 11;
            this.toolTipAlignment.SetToolTip(this.comboBoxAlignment, "ToolTip Alignment");
            this.comboBoxAlignment.Watermark = "ToolTip Alignment";
            this.comboBoxAlignment.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlignment_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(211, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 30);
            this.textBox1.TabIndex = 10;
            this.toolTipCustomColors.SetToolTip(this.textBox1, "Customizable Colors");
            this.textBox1.Watermark = "Customizable Colors";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toolTipAutoPopDelay
            // 
            this.toolTipAutoPopDelay.Alignment = Wisej.Web.Placement.LeftTop;
            this.toolTipAutoPopDelay.AutoPopDelay = 3000;
            // 
            // toolTipHtml
            // 
            this.toolTipHtml.Alignment = Wisej.Web.Placement.LeftTop;
            this.toolTipHtml.AllowHtml = true;
            this.toolTipHtml.AutoPopDelay = 3000;
            // 
            // toolTipCustomColors
            // 
            this.toolTipCustomColors.Alignment = Wisej.Web.Placement.LeftTop;
            this.toolTipCustomColors.AllowHtml = true;
            this.toolTipCustomColors.AutoPopDelay = 3000;
            this.toolTipCustomColors.ForeColor = System.Drawing.SystemColors.HotTrack;
            // 
            // toolTipAlignment
            // 
            this.toolTipAlignment.Alignment = Wisej.Web.Placement.LeftTop;
            this.toolTipAlignment.AllowHtml = true;
            this.toolTipAlignment.AutoPopDelay = 3000;
            // 
            // Features
            // 
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxIcon);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBoxAlignment);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.ToolTip toolTipDefault;
        private Web.ToolTip toolTipIcon;
        private Web.Button button2;
        private Web.ComboBox comboBoxIcon;
        private Web.ProgressBar progressBar1;
        private Web.ComboBox comboBoxAlignment;
        private Web.TextBox textBox1;
        private Web.Button button1;
        private Web.ToolTip toolTipAutoPopDelay;
        private Web.ToolTip toolTipHtml;
        private Web.ToolTip toolTipCustomColors;
        private Web.ToolTip toolTipAlignment;
    }
}
