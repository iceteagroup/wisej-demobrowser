﻿namespace Wisej.DemoBrowser.HelpTip
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
            this.helpTipDefault = new Wisej.Web.HelpTip(this.components);
            this.button1 = new Wisej.Web.Button();
            this.buttonCustomColors = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.comboBoxIcon = new Wisej.Web.ComboBox();
            this.helpTipColor = new Wisej.Web.HelpTip(this.components);
            this.progressBar1 = new Wisej.Web.ProgressBar();
            this.helpTipAutoPopDelay = new Wisej.Web.HelpTip(this.components);
            this.comboBoxAlignment = new Wisej.Web.ComboBox();
            this.helpTipIcon = new Wisej.Web.HelpTip(this.components);
            this.helpTipHtml = new Wisej.Web.HelpTip(this.components);
            this.helpTipAlignment = new Wisej.Web.HelpTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = Wisej.Web.AnchorStyles.None;
            this.helpTipDefault.SetHelpTip(this.button1, "Default HelpTip");
            this.button1.Location = new System.Drawing.Point(299, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Default";
            this.button1.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonCustomColors
            // 
            this.buttonCustomColors.Anchor = Wisej.Web.AnchorStyles.None;
            this.helpTipColor.SetHelpTip(this.buttonCustomColors, "Customizable Colors");
            this.buttonCustomColors.Location = new System.Drawing.Point(299, 268);
            this.buttonCustomColors.Name = "buttonCustomColors";
            this.buttonCustomColors.Size = new System.Drawing.Size(200, 40);
            this.buttonCustomColors.TabIndex = 9;
            this.buttonCustomColors.Text = "Customizable Colors";
            this.buttonCustomColors.Click += new System.EventHandler(this.buttonCustomColors_Click);
            // 
            // button2
            // 
            this.button2.Anchor = Wisej.Web.AnchorStyles.None;
            this.helpTipHtml.SetHelpTip(this.button2, "<b>Hello,</b> <i>World!</i>");
            this.button2.Location = new System.Drawing.Point(923, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "HTML";
            // 
            // comboBoxIcon
            // 
            this.comboBoxIcon.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxIcon.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxIcon.Location = new System.Drawing.Point(923, 276);
            this.comboBoxIcon.Name = "comboBoxIcon";
            this.comboBoxIcon.Size = new System.Drawing.Size(200, 30);
            this.comboBoxIcon.TabIndex = 7;
            this.comboBoxIcon.Watermark = "HelpTip Icon";
            this.comboBoxIcon.SelectedIndexChanged += new System.EventHandler(this.comboBoxIcon_SelectedIndexChanged);
            // 
            // helpTipColor
            // 
            this.helpTipColor.AutoPopDelay = 3000;
            this.helpTipColor.BackColor = System.Drawing.Color.FromName("@hotTrack");
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = Wisej.Web.AnchorStyles.None;
            this.helpTipColor.SetHelpTip(this.progressBar1, "AutoPopDelay: 3 Seconds");
            this.progressBar1.Location = new System.Drawing.Point(611, 169);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 40);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Text = "AutoPop: Click to Start";
            this.progressBar1.Value = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // helpTipAutoPopDelay
            // 
            this.helpTipAutoPopDelay.AutoPopDelay = 3000;
            // 
            // comboBoxAlignment
            // 
            this.comboBoxAlignment.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxAlignment.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxAlignment.Location = new System.Drawing.Point(611, 276);
            this.comboBoxAlignment.Name = "comboBoxAlignment";
            this.comboBoxAlignment.Size = new System.Drawing.Size(200, 30);
            this.comboBoxAlignment.TabIndex = 5;
            this.comboBoxAlignment.Watermark = "HelpTip Alignment";
            this.comboBoxAlignment.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlignment_SelectedIndexChanged);
            // 
            // helpTipHtml
            // 
            this.helpTipHtml.AllowHtml = true;
            // 
            // Features
            // 
            this.Controls.Add(this.buttonCustomColors);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBoxIcon);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBoxAlignment);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(836, 142);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.HelpTip helpTipDefault;
		private Web.Button button1;
		private Web.HelpTip helpTipAutoPopDelay;
		private Web.HelpTip helpTipColor;
		private Web.ComboBox comboBoxAlignment;
		private Web.ProgressBar progressBar1;
		private Web.ComboBox comboBoxIcon;
		private Web.HelpTip helpTipIcon;
		private Web.Button button2;
		private Web.HelpTip helpTipHtml;
		private Web.HelpTip helpTipAlignment;
		private Web.Button buttonCustomColors;
	}
}
