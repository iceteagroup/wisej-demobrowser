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
            this.panel1 = new Wisej.Web.Panel();
            this.panel2 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudMaxVal
            // 
            this.nudMaxVal.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudMaxVal.LabelText = "Max Value";
            this.nudMaxVal.Location = new System.Drawing.Point(177, 261);
            this.nudMaxVal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMaxVal.Name = "nudMaxVal";
            this.nudMaxVal.Size = new System.Drawing.Size(126, 53);
            this.nudMaxVal.TabIndex = 14;
            this.nudMaxVal.ValueChanged += new System.EventHandler(this.nudMaxVal_ValueChanged);
            // 
            // nudMinVal
            // 
            this.nudMinVal.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudMinVal.LabelText = "Min Value";
            this.nudMinVal.Location = new System.Drawing.Point(24, 261);
            this.nudMinVal.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudMinVal.Name = "nudMinVal";
            this.nudMinVal.Size = new System.Drawing.Size(126, 53);
            this.nudMinVal.TabIndex = 13;
            this.nudMinVal.ValueChanged += new System.EventHandler(this.nudMinVal_ValueChanged);
            // 
            // chkGradient
            // 
            this.chkGradient.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkGradient.Appearance = Wisej.Web.Appearance.Switch;
            this.chkGradient.AutoSize = false;
            this.chkGradient.Location = new System.Drawing.Point(90, 84);
            this.chkGradient.Name = "chkGradient";
            this.chkGradient.Size = new System.Drawing.Size(144, 24);
            this.chkGradient.TabIndex = 12;
            this.chkGradient.Text = "Gradient";
            this.chkGradient.CheckedChanged += new System.EventHandler(this.chkGradient_CheckedChanged);
            // 
            // txtLabel
            // 
            this.txtLabel.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtLabel.LabelText = "Label ";
            this.txtLabel.Location = new System.Drawing.Point(173, 178);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(130, 53);
            this.txtLabel.TabIndex = 5;
            this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
            // 
            // chkHumanFriendly
            // 
            this.chkHumanFriendly.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkHumanFriendly.Appearance = Wisej.Web.Appearance.Switch;
            this.chkHumanFriendly.AutoSize = false;
            this.chkHumanFriendly.Location = new System.Drawing.Point(90, 280);
            this.chkHumanFriendly.Name = "chkHumanFriendly";
            this.chkHumanFriendly.Size = new System.Drawing.Size(144, 24);
            this.chkHumanFriendly.TabIndex = 6;
            this.chkHumanFriendly.Text = "Human Friendly";
            this.chkHumanFriendly.CheckedChanged += new System.EventHandler(this.chkHumanFriendly_CheckedChanged);
            // 
            // chkShowPointer
            // 
            this.chkShowPointer.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkShowPointer.Appearance = Wisej.Web.Appearance.Switch;
            this.chkShowPointer.AutoSize = false;
            this.chkShowPointer.Location = new System.Drawing.Point(90, 182);
            this.chkShowPointer.Name = "chkShowPointer";
            this.chkShowPointer.Size = new System.Drawing.Size(144, 24);
            this.chkShowPointer.TabIndex = 11;
            this.chkShowPointer.Text = "Show Pointer";
            this.chkShowPointer.CheckedChanged += new System.EventHandler(this.chkShowPointer_CheckedChanged);
            // 
            // btnValueColor
            // 
            this.btnValueColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnValueColor.ImageSource = "resource.wx/Wisej.DemoBrowser.JustGage/Images/ColorPicker.svg";
            this.btnValueColor.Location = new System.Drawing.Point(177, 344);
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
            this.chkDonut.Location = new System.Drawing.Point(90, 35);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(144, 24);
            this.chkDonut.TabIndex = 7;
            this.chkDonut.Text = "Donut";
            this.chkDonut.CheckedChanged += new System.EventHandler(this.chkDonut_CheckedChanged);
            // 
            // btnLabelColor
            // 
            this.btnLabelColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnLabelColor.ImageSource = "resource.wx/Wisej.DemoBrowser.JustGage/Images/ColorPicker.svg";
            this.btnLabelColor.Location = new System.Drawing.Point(24, 344);
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
            this.chkShowValue.Location = new System.Drawing.Point(90, 133);
            this.chkShowValue.Name = "chkShowValue";
            this.chkShowValue.Size = new System.Drawing.Size(144, 24);
            this.chkShowValue.TabIndex = 10;
            this.chkShowValue.Text = "Show Value";
            this.chkShowValue.CheckedChanged += new System.EventHandler(this.chkShowValue_CheckedChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = Wisej.Web.AnchorStyles.None;
            this.txtTitle.LabelText = "Title";
            this.txtTitle.Location = new System.Drawing.Point(24, 95);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(279, 53);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // chkFormatNumber
            // 
            this.chkFormatNumber.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkFormatNumber.Appearance = Wisej.Web.Appearance.Switch;
            this.chkFormatNumber.AutoSize = false;
            this.chkFormatNumber.Location = new System.Drawing.Point(90, 329);
            this.chkFormatNumber.Name = "chkFormatNumber";
            this.chkFormatNumber.Size = new System.Drawing.Size(144, 24);
            this.chkFormatNumber.TabIndex = 8;
            this.chkFormatNumber.Text = "Format Number";
            this.chkFormatNumber.CheckedChanged += new System.EventHandler(this.chkFormatNumber_CheckedChanged);
            // 
            // nudDecimals
            // 
            this.nudDecimals.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudDecimals.LabelText = "Decimals";
            this.nudDecimals.Location = new System.Drawing.Point(26, 178);
            this.nudDecimals.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecimals.Name = "nudDecimals";
            this.nudDecimals.Size = new System.Drawing.Size(126, 53);
            this.nudDecimals.TabIndex = 1;
            this.nudDecimals.ValueChanged += new System.EventHandler(this.nudDecimals_ValueChanged);
            // 
            // chkShowMinMax
            // 
            this.chkShowMinMax.Anchor = Wisej.Web.AnchorStyles.None;
            this.chkShowMinMax.Appearance = Wisej.Web.Appearance.Switch;
            this.chkShowMinMax.AutoSize = false;
            this.chkShowMinMax.Location = new System.Drawing.Point(90, 231);
            this.chkShowMinMax.Name = "chkShowMinMax";
            this.chkShowMinMax.Size = new System.Drawing.Size(144, 24);
            this.chkShowMinMax.TabIndex = 9;
            this.chkShowMinMax.Text = "Show Min/Max";
            this.chkShowMinMax.CheckedChanged += new System.EventHandler(this.chkShowMinMax_CheckedChanged);
            // 
            // nudValue
            // 
            this.nudValue.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudValue.DecimalPlaces = 2;
            this.nudValue.LabelText = "Value";
            this.nudValue.Location = new System.Drawing.Point(24, 10);
            this.nudValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(279, 53);
            this.nudValue.TabIndex = 0;
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // justGage
            // 
            this.justGage.Anchor = Wisej.Web.AnchorStyles.None;
            this.justGage.BackColor = System.Drawing.Color.White;
            this.justGage.Cursor = Wisej.Web.Cursors.Default;
            this.flowLayoutPanel1.SetFillWeight(this.justGage, 2);
            this.justGage.HumanFriendly = true;
            this.justGage.Location = new System.Drawing.Point(666, 3);
            this.justGage.MinimumSize = new System.Drawing.Size(200, 0);
            this.justGage.Name = "justGage";
            this.justGage.Size = new System.Drawing.Size(651, 388);
            this.justGage.TabIndex = 1;
            this.justGage.Text = "JustGage";
            this.justGage.Value = 50F;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudMaxVal);
            this.panel1.Controls.Add(this.nudMinVal);
            this.panel1.Controls.Add(this.nudValue);
            this.panel1.Controls.Add(this.txtLabel);
            this.panel1.Controls.Add(this.nudDecimals);
            this.panel1.Controls.Add(this.btnValueColor);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.btnLabelColor);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(334, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(300, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 388);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkGradient);
            this.panel2.Controls.Add(this.chkShowMinMax);
            this.panel2.Controls.Add(this.chkHumanFriendly);
            this.panel2.Controls.Add(this.chkShowPointer);
            this.panel2.Controls.Add(this.chkFormatNumber);
            this.panel2.Controls.Add(this.chkDonut);
            this.panel2.Controls.Add(this.chkShowValue);
            this.flowLayoutPanel1.SetFillWeight(this.panel2, 1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.MinimumSize = new System.Drawing.Size(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 388);
            this.panel2.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.justGage);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1320, 395);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // Features
            // 
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel2;
        private Web.Panel panel1;
    }
}
