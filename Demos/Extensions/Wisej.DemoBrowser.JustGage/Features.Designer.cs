﻿namespace Wisej.DemoBrowser.JustGage
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
			this.nudMaxVal = new Wisej.Web.NumericUpDown();
			this.nudMinVal = new Wisej.Web.NumericUpDown();
			this.chkGradient = new Wisej.Web.CheckBox();
			this.txtLabel = new Wisej.Web.TextBox();
			this.chkHumanFriendly = new Wisej.Web.CheckBox();
			this.chkShowPointer = new Wisej.Web.CheckBox();
			this.btnValueColor = new Wisej.Web.Button();
			this.chkDonut = new Wisej.Web.CheckBox();
			this.btnLabelColor = new Wisej.Web.Button();
			this.chkShowValue = new Wisej.Web.CheckBox();
			this.txtTitle = new Wisej.Web.TextBox();
			this.chkFormatNumber = new Wisej.Web.CheckBox();
			this.nudDecimals = new Wisej.Web.NumericUpDown();
			this.chkShowMinMax = new Wisej.Web.CheckBox();
			this.nudValue = new Wisej.Web.NumericUpDown();
			this.justGage = new Wisej.Web.Ext.JustGage.JustGage();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
			this.SuspendLayout();
			// 
			// nudMaxVal
			// 
			this.nudMaxVal.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudMaxVal.LabelText = "Max Value";
			this.nudMaxVal.Location = new System.Drawing.Point(288, 305);
			this.nudMaxVal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.nudMaxVal.Name = "nudMaxVal";
			this.nudMaxVal.Size = new System.Drawing.Size(126, 50);
			this.nudMaxVal.TabIndex = 14;
			this.nudMaxVal.ValueChanged += new System.EventHandler(this.nudMaxVal_ValueChanged);
			// 
			// nudMinVal
			// 
			this.nudMinVal.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudMinVal.LabelText = "Min Value";
			this.nudMinVal.Location = new System.Drawing.Point(119, 305);
			this.nudMinVal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.nudMinVal.Name = "nudMinVal";
			this.nudMinVal.Size = new System.Drawing.Size(126, 50);
			this.nudMinVal.TabIndex = 13;
			this.nudMinVal.ValueChanged += new System.EventHandler(this.nudMinVal_ValueChanged);
			// 
			// chkGradient
			// 
			this.chkGradient.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkGradient.Appearance = Wisej.Web.Appearance.Switch;
			this.chkGradient.AutoSize = false;
			this.chkGradient.Location = new System.Drawing.Point(491, 116);
			this.chkGradient.Name = "chkGradient";
			this.chkGradient.Size = new System.Drawing.Size(175, 24);
			this.chkGradient.TabIndex = 12;
			this.chkGradient.Text = "Gradient";
			this.chkGradient.CheckedChanged += new System.EventHandler(this.chkGradient_CheckedChanged);
			// 
			// txtLabel
			// 
			this.txtLabel.Anchor = Wisej.Web.AnchorStyles.None;
			this.txtLabel.LabelText = "Label ";
			this.txtLabel.Location = new System.Drawing.Point(284, 222);
			this.txtLabel.Name = "txtLabel";
			this.txtLabel.Size = new System.Drawing.Size(130, 50);
			this.txtLabel.TabIndex = 5;
			this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
			// 
			// chkHumanFriendly
			// 
			this.chkHumanFriendly.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkHumanFriendly.Appearance = Wisej.Web.Appearance.Switch;
			this.chkHumanFriendly.AutoSize = false;
			this.chkHumanFriendly.Location = new System.Drawing.Point(491, 344);
			this.chkHumanFriendly.Name = "chkHumanFriendly";
			this.chkHumanFriendly.Size = new System.Drawing.Size(175, 24);
			this.chkHumanFriendly.TabIndex = 6;
			this.chkHumanFriendly.Text = "Human Friendly";
			this.chkHumanFriendly.CheckedChanged += new System.EventHandler(this.chkHumanFriendly_CheckedChanged);
			// 
			// chkShowPointer
			// 
			this.chkShowPointer.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkShowPointer.Appearance = Wisej.Web.Appearance.Switch;
			this.chkShowPointer.AutoSize = false;
			this.chkShowPointer.Location = new System.Drawing.Point(491, 230);
			this.chkShowPointer.Name = "chkShowPointer";
			this.chkShowPointer.Size = new System.Drawing.Size(175, 24);
			this.chkShowPointer.TabIndex = 11;
			this.chkShowPointer.Text = "Show Pointer";
			this.chkShowPointer.CheckedChanged += new System.EventHandler(this.chkShowPointer_CheckedChanged);
			// 
			// btnValueColor
			// 
			this.btnValueColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.btnValueColor.ImageSource = "resource.wx/Wisej.DemoBrowser.JustGage/ColorPicker.svg";
			this.btnValueColor.Location = new System.Drawing.Point(288, 388);
			this.btnValueColor.Name = "btnValueColor";
			this.btnValueColor.Size = new System.Drawing.Size(126, 35);
			this.btnValueColor.TabIndex = 4;
			this.btnValueColor.Text = "Value Color";
			this.btnValueColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnValueColor.Click += new System.EventHandler(this.btnValueColor_Click);
			// 
			// chkDonut
			// 
			this.chkDonut.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkDonut.Appearance = Wisej.Web.Appearance.Switch;
			this.chkDonut.AutoSize = false;
			this.chkDonut.Location = new System.Drawing.Point(491, 54);
			this.chkDonut.Name = "chkDonut";
			this.chkDonut.Size = new System.Drawing.Size(175, 24);
			this.chkDonut.TabIndex = 7;
			this.chkDonut.Text = "Donut";
			this.chkDonut.CheckedChanged += new System.EventHandler(this.chkDonut_CheckedChanged);
			// 
			// btnLabelColor
			// 
			this.btnLabelColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.btnLabelColor.ImageSource = "resource.wx/Wisej.DemoBrowser.JustGage/ColorPicker.svg";
			this.btnLabelColor.Location = new System.Drawing.Point(119, 388);
			this.btnLabelColor.Name = "btnLabelColor";
			this.btnLabelColor.Size = new System.Drawing.Size(126, 35);
			this.btnLabelColor.TabIndex = 3;
			this.btnLabelColor.Text = "Label Color";
			this.btnLabelColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLabelColor.Click += new System.EventHandler(this.btnLabelColor_Click);
			// 
			// chkShowValue
			// 
			this.chkShowValue.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkShowValue.Appearance = Wisej.Web.Appearance.Switch;
			this.chkShowValue.AutoSize = false;
			this.chkShowValue.Location = new System.Drawing.Point(491, 173);
			this.chkShowValue.Name = "chkShowValue";
			this.chkShowValue.Size = new System.Drawing.Size(175, 24);
			this.chkShowValue.TabIndex = 10;
			this.chkShowValue.Text = "Show Value";
			this.chkShowValue.CheckedChanged += new System.EventHandler(this.chkShowValue_CheckedChanged);
			// 
			// txtTitle
			// 
			this.txtTitle.Anchor = Wisej.Web.AnchorStyles.None;
			this.txtTitle.LabelText = "Title";
			this.txtTitle.Location = new System.Drawing.Point(119, 139);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(295, 50);
			this.txtTitle.TabIndex = 2;
			this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
			// 
			// chkFormatNumber
			// 
			this.chkFormatNumber.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkFormatNumber.Appearance = Wisej.Web.Appearance.Switch;
			this.chkFormatNumber.AutoSize = false;
			this.chkFormatNumber.Location = new System.Drawing.Point(491, 401);
			this.chkFormatNumber.Name = "chkFormatNumber";
			this.chkFormatNumber.Size = new System.Drawing.Size(175, 24);
			this.chkFormatNumber.TabIndex = 8;
			this.chkFormatNumber.Text = "Format Number";
			this.chkFormatNumber.CheckedChanged += new System.EventHandler(this.chkFormatNumber_CheckedChanged);
			// 
			// nudDecimals
			// 
			this.nudDecimals.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudDecimals.LabelText = "Decimals";
			this.nudDecimals.Location = new System.Drawing.Point(121, 222);
			this.nudDecimals.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudDecimals.Name = "nudDecimals";
			this.nudDecimals.Size = new System.Drawing.Size(126, 50);
			this.nudDecimals.TabIndex = 1;
			this.nudDecimals.ValueChanged += new System.EventHandler(this.nudDecimals_ValueChanged);
			// 
			// chkShowMinMax
			// 
			this.chkShowMinMax.Anchor = Wisej.Web.AnchorStyles.None;
			this.chkShowMinMax.Appearance = Wisej.Web.Appearance.Switch;
			this.chkShowMinMax.AutoSize = false;
			this.chkShowMinMax.Location = new System.Drawing.Point(491, 287);
			this.chkShowMinMax.Name = "chkShowMinMax";
			this.chkShowMinMax.Size = new System.Drawing.Size(175, 24);
			this.chkShowMinMax.TabIndex = 9;
			this.chkShowMinMax.Text = "Show Min/Max";
			this.chkShowMinMax.CheckedChanged += new System.EventHandler(this.chkShowMinMax_CheckedChanged);
			// 
			// nudValue
			// 
			this.nudValue.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudValue.DecimalPlaces = 2;
			this.nudValue.LabelText = "Value";
			this.nudValue.Location = new System.Drawing.Point(119, 54);
			this.nudValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this.nudValue.Name = "nudValue";
			this.nudValue.Size = new System.Drawing.Size(295, 50);
			this.nudValue.TabIndex = 0;
			this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
			// 
			// justGage
			// 
			this.justGage.Anchor = Wisej.Web.AnchorStyles.None;
			this.justGage.BackColor = System.Drawing.Color.White;
			this.justGage.Cursor = Wisej.Web.Cursors.Default;
			this.justGage.HumanFriendly = true;
			this.justGage.Location = new System.Drawing.Point(718, 54);
			this.justGage.Name = "justGage";
			this.justGage.Size = new System.Drawing.Size(586, 371);
			this.justGage.TabIndex = 1;
			this.justGage.Text = "JustGage";
			this.justGage.Value = 50F;
			// 
			// Features
			// 
			this.Controls.Add(this.justGage);
			this.Controls.Add(this.nudMaxVal);
			this.Controls.Add(this.nudMinVal);
			this.Controls.Add(this.chkGradient);
			this.Controls.Add(this.nudValue);
			this.Controls.Add(this.txtLabel);
			this.Controls.Add(this.chkShowMinMax);
			this.Controls.Add(this.chkHumanFriendly);
			this.Controls.Add(this.nudDecimals);
			this.Controls.Add(this.chkShowPointer);
			this.Controls.Add(this.chkFormatNumber);
			this.Controls.Add(this.btnValueColor);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.chkDonut);
			this.Controls.Add(this.chkShowValue);
			this.Controls.Add(this.btnLabelColor);
			this.MinimumSize = new System.Drawing.Size(1217, 401);
			this.Name = "Features";
			this.Load += new System.EventHandler(this.Features_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Web.NumericUpDown nudValue;
        private Web.TextBox txtTitle;
        private Web.NumericUpDown nudDecimals;
        private Web.Button btnLabelColor;
        private Web.Button btnValueColor;
        private Web.TextBox txtLabel;
        private Web.CheckBox chkDonut;
        private Web.CheckBox chkHumanFriendly;
        private Web.CheckBox chkShowValue;
        private Web.CheckBox chkShowMinMax;
        private Web.CheckBox chkFormatNumber;
        private Web.CheckBox chkShowPointer;
        private Web.CheckBox chkGradient;
        private Web.NumericUpDown nudMaxVal;
        private Web.NumericUpDown nudMinVal;
		private Web.Ext.JustGage.JustGage justGage;
	}
}
