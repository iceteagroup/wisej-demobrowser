using System.Drawing;

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
            this.toolTip = new Wisej.Web.ToolTip(this.components);
            this.progressBar1 = new Wisej.Web.ProgressBar();
            this.btnToolTip = new Wisej.Web.Button();
            this.comboBoxIcon = new Wisej.Web.ComboBox();
            this.comboBoxAlignment = new Wisej.Web.ComboBox();
            this.txtColor = new Wisej.Web.TextBox();
            this.txtToolTipText = new Wisej.Web.TextBox();
            this.chkAllowHtml = new Wisej.Web.CheckBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(821, 268);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 40);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Text = "AutoPop: Click to Start";
            this.toolTip.SetToolTip(this.progressBar1, "This ToolTip Text Will Pop Automatically");
            this.progressBar1.Value = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnToolTip
            // 
            this.btnToolTip.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnToolTip.Location = new System.Drawing.Point(821, 167);
            this.btnToolTip.Name = "btnToolTip";
            this.btnToolTip.Size = new System.Drawing.Size(200, 40);
            this.btnToolTip.TabIndex = 14;
            this.btnToolTip.Text = "ToolTip";
            this.toolTip.SetToolTip(this.btnToolTip, "ToolTip Text");
            // 
            // comboBoxIcon
            // 
            this.comboBoxIcon.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxIcon.Location = new System.Drawing.Point(407, 291);
            this.comboBoxIcon.Name = "comboBoxIcon";
            this.comboBoxIcon.Size = new System.Drawing.Size(200, 30);
            this.comboBoxIcon.TabIndex = 13;
            this.comboBoxIcon.Watermark = "ToolTip Icon";
            this.comboBoxIcon.SelectedIndexChanged += new System.EventHandler(this.comboBoxIcon_SelectedIndexChanged);
            // 
            // comboBoxAlignment
            // 
            this.comboBoxAlignment.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxAlignment.Location = new System.Drawing.Point(407, 226);
            this.comboBoxAlignment.Name = "comboBoxAlignment";
            this.comboBoxAlignment.Size = new System.Drawing.Size(200, 30);
            this.comboBoxAlignment.TabIndex = 11;
            this.comboBoxAlignment.Watermark = "ToolTip Alignment";
            this.comboBoxAlignment.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlignment_SelectedIndexChanged);
            // 
            // txtColor
            // 
            this.txtColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtColor.Location = new System.Drawing.Point(407, 161);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(200, 30);
            this.txtColor.TabIndex = 10;
            this.txtColor.Watermark = "Customizable Colors";
            this.txtColor.Enter += new System.EventHandler(this.txtColor_Enter);
            // 
            // txtToolTipText
            // 
            this.txtToolTipText.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtToolTipText.Location = new System.Drawing.Point(407, 96);
            this.txtToolTipText.Name = "txtToolTipText";
            this.txtToolTipText.Size = new System.Drawing.Size(200, 30);
            this.txtToolTipText.TabIndex = 15;
            this.txtToolTipText.Text = "ToolTip Text";
            this.txtToolTipText.Watermark = "ToolTip Text";
            this.txtToolTipText.TextChanged += new System.EventHandler(this.txtToolTipText_TextChanged);
            // 
            // chkAllowHtml
            // 
            this.chkAllowHtml.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkAllowHtml.Location = new System.Drawing.Point(407, 356);
            this.chkAllowHtml.Name = "chkAllowHtml";
            this.chkAllowHtml.Size = new System.Drawing.Size(100, 23);
            this.chkAllowHtml.TabIndex = 16;
            this.chkAllowHtml.Text = "Allow HTML";
            this.chkAllowHtml.CheckedChanged += new System.EventHandler(this.chkAllowHtml_CheckedChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.chkAllowHtml);
            this.Controls.Add(this.txtToolTipText);
            this.Controls.Add(this.btnToolTip);
            this.Controls.Add(this.comboBoxIcon);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBoxAlignment);
            this.Controls.Add(this.txtColor);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Web.ToolTip toolTip;
        private Web.Button btnToolTip;
        private Web.ComboBox comboBoxIcon;
        private Web.ProgressBar progressBar1;
        private Web.ComboBox comboBoxAlignment;
        private Web.TextBox txtColor;
        private Web.TextBox txtToolTipText;
        private Web.CheckBox chkAllowHtml;
    }
}
