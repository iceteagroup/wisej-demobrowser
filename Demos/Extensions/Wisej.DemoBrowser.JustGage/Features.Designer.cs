namespace Wisej.DemoBrowser.JustGage
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
            this.justGage = new Wisej.Web.Ext.JustGage.JustGage();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.nudMaxVal = new Wisej.Web.NumericUpDown();
            this.nudMinVal = new Wisej.Web.NumericUpDown();
            this.chkGradient = new Wisej.Web.CheckBox();
            this.chkShowPointer = new Wisej.Web.CheckBox();
            this.chkShowValue = new Wisej.Web.CheckBox();
            this.chkShowMinMax = new Wisej.Web.CheckBox();
            this.chkFormatNumber = new Wisej.Web.CheckBox();
            this.chkDonut = new Wisej.Web.CheckBox();
            this.chkHumanFriendly = new Wisej.Web.CheckBox();
            this.txtLabel = new Wisej.Web.TextBox();
            this.btnValueColor = new Wisej.Web.Button();
            this.btnLabelColor = new Wisej.Web.Button();
            this.txtTitle = new Wisej.Web.TextBox();
            this.nudDecimals = new Wisej.Web.NumericUpDown();
            this.nudValue = new Wisej.Web.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // justGage
            // 
            this.justGage.BackColor = System.Drawing.Color.White;
            this.justGage.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.justGage.Cursor = Wisej.Web.Cursors.Default;
            this.justGage.HumanFriendly = true;
            this.justGage.Location = new System.Drawing.Point(809, 42);
            this.justGage.Name = "justGage";
            this.justGage.Size = new System.Drawing.Size(586, 390);
            this.justGage.TabIndex = 1;
            this.justGage.Text = "JustGage";
            this.justGage.Value = 300F;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.nudMaxVal);
            this.groupBox1.Controls.Add(this.nudMinVal);
            this.groupBox1.Controls.Add(this.chkGradient);
            this.groupBox1.Controls.Add(this.chkShowPointer);
            this.groupBox1.Controls.Add(this.chkShowValue);
            this.groupBox1.Controls.Add(this.chkShowMinMax);
            this.groupBox1.Controls.Add(this.chkFormatNumber);
            this.groupBox1.Controls.Add(this.chkDonut);
            this.groupBox1.Controls.Add(this.chkHumanFriendly);
            this.groupBox1.Controls.Add(this.txtLabel);
            this.groupBox1.Controls.Add(this.btnValueColor);
            this.groupBox1.Controls.Add(this.btnLabelColor);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.nudDecimals);
            this.groupBox1.Controls.Add(this.nudValue);
            this.groupBox1.Dock = Wisej.Web.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.Text = "Properties";
            // 
            // nudMaxVal
            // 
            this.nudMaxVal.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudMaxVal.LabelText = "Max Value";
            this.nudMaxVal.Location = new System.Drawing.Point(228, 204);
            this.nudMaxVal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMaxVal.Name = "nudMaxVal";
            this.nudMaxVal.Size = new System.Drawing.Size(126, 42);
            this.nudMaxVal.TabIndex = 14;
            this.nudMaxVal.ValueChanged += new System.EventHandler(this.nudMaxVal_ValueChanged);
            // 
            // nudMinVal
            // 
            this.nudMinVal.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudMinVal.LabelText = "Min Value";
            this.nudMinVal.Location = new System.Drawing.Point(59, 204);
            this.nudMinVal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMinVal.Name = "nudMinVal";
            this.nudMinVal.Size = new System.Drawing.Size(126, 42);
            this.nudMinVal.TabIndex = 13;
            this.nudMinVal.ValueChanged += new System.EventHandler(this.nudMinVal_ValueChanged);
            // 
            // chkGradient
            // 
            this.chkGradient.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkGradient.Appearance = Wisej.Web.Appearance.Switch;
            this.chkGradient.Location = new System.Drawing.Point(244, 425);
            this.chkGradient.Name = "chkGradient";
            this.chkGradient.Size = new System.Drawing.Size(102, 24);
            this.chkGradient.TabIndex = 12;
            this.chkGradient.Text = "Gradient";
            this.chkGradient.CheckedChanged += new System.EventHandler(this.chkGradient_CheckedChanged);
            // 
            // chkShowPointer
            // 
            this.chkShowPointer.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkShowPointer.Appearance = Wisej.Web.Appearance.Switch;
            this.chkShowPointer.Location = new System.Drawing.Point(59, 425);
            this.chkShowPointer.Name = "chkShowPointer";
            this.chkShowPointer.Size = new System.Drawing.Size(128, 24);
            this.chkShowPointer.TabIndex = 11;
            this.chkShowPointer.Text = "Show pointer";
            this.chkShowPointer.CheckedChanged += new System.EventHandler(this.chkShowPointer_CheckedChanged);
            // 
            // chkShowValue
            // 
            this.chkShowValue.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkShowValue.Appearance = Wisej.Web.Appearance.Switch;
            this.chkShowValue.Location = new System.Drawing.Point(244, 395);
            this.chkShowValue.Name = "chkShowValue";
            this.chkShowValue.Size = new System.Drawing.Size(120, 24);
            this.chkShowValue.TabIndex = 10;
            this.chkShowValue.Text = "Show value";
            this.chkShowValue.CheckedChanged += new System.EventHandler(this.chkShowValue_CheckedChanged);
            // 
            // chkShowMinMax
            // 
            this.chkShowMinMax.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkShowMinMax.Appearance = Wisej.Web.Appearance.Switch;
            this.chkShowMinMax.Location = new System.Drawing.Point(59, 365);
            this.chkShowMinMax.Name = "chkShowMinMax";
            this.chkShowMinMax.Size = new System.Drawing.Size(179, 24);
            this.chkShowMinMax.TabIndex = 9;
            this.chkShowMinMax.Text = "Show Min/Max values";
            this.chkShowMinMax.CheckedChanged += new System.EventHandler(this.chkShowMinMax_CheckedChanged);
            // 
            // chkFormatNumber
            // 
            this.chkFormatNumber.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkFormatNumber.Appearance = Wisej.Web.Appearance.Switch;
            this.chkFormatNumber.Location = new System.Drawing.Point(244, 335);
            this.chkFormatNumber.Name = "chkFormatNumber";
            this.chkFormatNumber.Size = new System.Drawing.Size(141, 24);
            this.chkFormatNumber.TabIndex = 8;
            this.chkFormatNumber.Text = "Format number";
            this.chkFormatNumber.CheckedChanged += new System.EventHandler(this.chkFormatNumber_CheckedChanged);
            // 
            // chkDonut
            // 
            this.chkDonut.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkDonut.Appearance = Wisej.Web.Appearance.Switch;
            this.chkDonut.Location = new System.Drawing.Point(59, 395);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(87, 24);
            this.chkDonut.TabIndex = 7;
            this.chkDonut.Text = "Donut";
            this.chkDonut.CheckedChanged += new System.EventHandler(this.chkDonut_CheckedChanged);
            // 
            // chkHumanFriendly
            // 
            this.chkHumanFriendly.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkHumanFriendly.Appearance = Wisej.Web.Appearance.Switch;
            this.chkHumanFriendly.Location = new System.Drawing.Point(59, 335);
            this.chkHumanFriendly.Name = "chkHumanFriendly";
            this.chkHumanFriendly.Size = new System.Drawing.Size(140, 24);
            this.chkHumanFriendly.TabIndex = 6;
            this.chkHumanFriendly.Text = "Human friendly";
            this.chkHumanFriendly.CheckedChanged += new System.EventHandler(this.chkHumanFriendly_CheckedChanged);
            // 
            // txtLabel
            // 
            this.txtLabel.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtLabel.LabelText = "Label ";
            this.txtLabel.Location = new System.Drawing.Point(224, 91);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(130, 42);
            this.txtLabel.TabIndex = 5;
            this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
            // 
            // btnValueColor
            // 
            this.btnValueColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnValueColor.Location = new System.Drawing.Point(59, 299);
            this.btnValueColor.Name = "btnValueColor";
            this.btnValueColor.Size = new System.Drawing.Size(295, 23);
            this.btnValueColor.TabIndex = 4;
            this.btnValueColor.Text = "Value color";
            this.btnValueColor.Click += new System.EventHandler(this.btnValueColor_Click);
            // 
            // btnLabelColor
            // 
            this.btnLabelColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnLabelColor.Location = new System.Drawing.Point(59, 262);
            this.btnLabelColor.Name = "btnLabelColor";
            this.btnLabelColor.Size = new System.Drawing.Size(295, 23);
            this.btnLabelColor.TabIndex = 3;
            this.btnLabelColor.Text = "Label color";
            this.btnLabelColor.Click += new System.EventHandler(this.btnLabelColor_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtTitle.LabelText = "Title";
            this.txtTitle.Location = new System.Drawing.Point(59, 148);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 42);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // nudDecimals
            // 
            this.nudDecimals.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudDecimals.LabelText = "Decimals";
            this.nudDecimals.Location = new System.Drawing.Point(59, 91);
            this.nudDecimals.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecimals.Name = "nudDecimals";
            this.nudDecimals.Size = new System.Drawing.Size(126, 42);
            this.nudDecimals.TabIndex = 1;
            this.nudDecimals.ValueChanged += new System.EventHandler(this.nudDecimals_ValueChanged);
            // 
            // nudValue
            // 
            this.nudValue.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudValue.LabelText = "Value";
            this.nudValue.Location = new System.Drawing.Point(59, 33);
            this.nudValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(295, 42);
            this.nudValue.TabIndex = 0;
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // Features
            // 
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.justGage);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Ext.JustGage.JustGage justGage;
        private Web.GroupBox groupBox1;
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
    }
}
