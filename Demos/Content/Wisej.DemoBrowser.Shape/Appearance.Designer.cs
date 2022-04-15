namespace Wisej.DemoBrowser.Shape
{
    partial class Appearance
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
            this.shape1 = new Wisej.Web.Shape();
            this.nudBorderTopRadius = new Wisej.Web.NumericUpDown();
            this.nudBorderTopSize = new Wisej.Web.NumericUpDown();
            this.cmbBorderTopStyle = new Wisej.Web.ComboBox();
            this.btnBorderTopColor = new Wisej.Web.Button();
            this.groupBox1 = new Wisej.Web.GroupBox();
            this.nudBorderBottomRadius = new Wisej.Web.NumericUpDown();
            this.nudBorderBottomSize = new Wisej.Web.NumericUpDown();
            this.cmbBorderBottomStyle = new Wisej.Web.ComboBox();
            this.btnBorderBottomColor = new Wisej.Web.Button();
            this.groupBox2 = new Wisej.Web.GroupBox();
            this.nudBorderLeftRadius = new Wisej.Web.NumericUpDown();
            this.nudBorderLeftSize = new Wisej.Web.NumericUpDown();
            this.cmbBorderLeftStyle = new Wisej.Web.ComboBox();
            this.btnBorderLeftColor = new Wisej.Web.Button();
            this.groupBox3 = new Wisej.Web.GroupBox();
            this.nudBorderRightRadius = new Wisej.Web.NumericUpDown();
            this.nudBorderRightSize = new Wisej.Web.NumericUpDown();
            this.cmbBorderRightStyle = new Wisej.Web.ComboBox();
            this.btnBorderRightColor = new Wisej.Web.Button();
            this.groupBox4 = new Wisej.Web.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderTopRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderTopSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftSize)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderRightRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderRightSize)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // shape1
            // 
            this.shape1.Anchor = Wisej.Web.AnchorStyles.None;
            this.shape1.BorderStyleBottom.Color = System.Drawing.Color.FromArgb(251, 165, 128);
            this.shape1.BorderStyleBottom.Radius = 50;
            this.shape1.BorderStyleBottom.Size = 10;
            this.shape1.BorderStyleLeft.Color = System.Drawing.Color.FromArgb(135, 134, 245);
            this.shape1.BorderStyleLeft.Radius = 100;
            this.shape1.BorderStyleLeft.Size = 20;
            this.shape1.BorderStyleRight.Color = System.Drawing.Color.FromArgb(125, 255, 157);
            this.shape1.BorderStyleRight.Radius = 100;
            this.shape1.BorderStyleRight.Size = 30;
            this.shape1.BorderStyleTop.Color = System.Drawing.Color.FromArgb(125, 149, 255);
            this.shape1.BorderStyleTop.Radius = 50;
            this.shape1.BorderStyleTop.Size = 40;
            this.shape1.Location = new System.Drawing.Point(969, 97);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(315, 294);
            // 
            // nudBorderTopRadius
            // 
            this.nudBorderTopRadius.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderTopRadius.LabelText = "Radius";
            this.nudBorderTopRadius.Location = new System.Drawing.Point(20, 236);
            this.nudBorderTopRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderTopRadius.Name = "nudBorderTopRadius";
            this.nudBorderTopRadius.Size = new System.Drawing.Size(125, 53);
            this.nudBorderTopRadius.TabIndex = 4;
            this.nudBorderTopRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // nudBorderTopSize
            // 
            this.nudBorderTopSize.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderTopSize.LabelText = "Size";
            this.nudBorderTopSize.Location = new System.Drawing.Point(20, 166);
            this.nudBorderTopSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderTopSize.Name = "nudBorderTopSize";
            this.nudBorderTopSize.Size = new System.Drawing.Size(125, 53);
            this.nudBorderTopSize.TabIndex = 5;
            this.nudBorderTopSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // cmbBorderTopStyle
            // 
            this.cmbBorderTopStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbBorderTopStyle.LabelText = "Style";
            this.cmbBorderTopStyle.Location = new System.Drawing.Point(20, 96);
            this.cmbBorderTopStyle.Name = "cmbBorderTopStyle";
            this.cmbBorderTopStyle.Size = new System.Drawing.Size(125, 53);
            this.cmbBorderTopStyle.TabIndex = 6;
            this.cmbBorderTopStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // btnBorderTopColor
            // 
            this.btnBorderTopColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnBorderTopColor.Location = new System.Drawing.Point(19, 47);
            this.btnBorderTopColor.Name = "btnBorderTopColor";
            this.btnBorderTopColor.Size = new System.Drawing.Size(126, 32);
            this.btnBorderTopColor.TabIndex = 7;
            this.btnBorderTopColor.Text = "Color";
            this.btnBorderTopColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromName("@window");
            this.groupBox1.Controls.Add(this.btnBorderTopColor);
            this.groupBox1.Controls.Add(this.cmbBorderTopStyle);
            this.groupBox1.Controls.Add(this.nudBorderTopSize);
            this.groupBox1.Controls.Add(this.nudBorderTopRadius);
            this.groupBox1.Location = new System.Drawing.Point(139, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.Text = "BorderStyle Top";
            // 
            // nudBorderBottomRadius
            // 
            this.nudBorderBottomRadius.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderBottomRadius.LabelText = "Radius";
            this.nudBorderBottomRadius.Location = new System.Drawing.Point(20, 236);
            this.nudBorderBottomRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderBottomRadius.Name = "nudBorderBottomRadius";
            this.nudBorderBottomRadius.Size = new System.Drawing.Size(125, 53);
            this.nudBorderBottomRadius.TabIndex = 0;
            this.nudBorderBottomRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // nudBorderBottomSize
            // 
            this.nudBorderBottomSize.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderBottomSize.LabelText = "Size";
            this.nudBorderBottomSize.Location = new System.Drawing.Point(20, 166);
            this.nudBorderBottomSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderBottomSize.Name = "nudBorderBottomSize";
            this.nudBorderBottomSize.Size = new System.Drawing.Size(125, 53);
            this.nudBorderBottomSize.TabIndex = 1;
            this.nudBorderBottomSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // cmbBorderBottomStyle
            // 
            this.cmbBorderBottomStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbBorderBottomStyle.LabelText = "Style";
            this.cmbBorderBottomStyle.Location = new System.Drawing.Point(20, 96);
            this.cmbBorderBottomStyle.Name = "cmbBorderBottomStyle";
            this.cmbBorderBottomStyle.Size = new System.Drawing.Size(125, 53);
            this.cmbBorderBottomStyle.TabIndex = 2;
            this.cmbBorderBottomStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // btnBorderBottomColor
            // 
            this.btnBorderBottomColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnBorderBottomColor.Location = new System.Drawing.Point(19, 47);
            this.btnBorderBottomColor.Name = "btnBorderBottomColor";
            this.btnBorderBottomColor.Size = new System.Drawing.Size(126, 32);
            this.btnBorderBottomColor.TabIndex = 3;
            this.btnBorderBottomColor.Text = "Color";
            this.btnBorderBottomColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.FromName("@window");
            this.groupBox2.Controls.Add(this.btnBorderBottomColor);
            this.groupBox2.Controls.Add(this.cmbBorderBottomStyle);
            this.groupBox2.Controls.Add(this.nudBorderBottomSize);
            this.groupBox2.Controls.Add(this.nudBorderBottomRadius);
            this.groupBox2.Location = new System.Drawing.Point(518, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 301);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.Text = "BorderStyle Bottom";
            // 
            // nudBorderLeftRadius
            // 
            this.nudBorderLeftRadius.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderLeftRadius.LabelText = "Radius";
            this.nudBorderLeftRadius.Location = new System.Drawing.Point(20, 236);
            this.nudBorderLeftRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderLeftRadius.Name = "nudBorderLeftRadius";
            this.nudBorderLeftRadius.Size = new System.Drawing.Size(125, 53);
            this.nudBorderLeftRadius.TabIndex = 4;
            this.nudBorderLeftRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // nudBorderLeftSize
            // 
            this.nudBorderLeftSize.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderLeftSize.LabelText = "Size";
            this.nudBorderLeftSize.Location = new System.Drawing.Point(20, 166);
            this.nudBorderLeftSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderLeftSize.Name = "nudBorderLeftSize";
            this.nudBorderLeftSize.Size = new System.Drawing.Size(125, 53);
            this.nudBorderLeftSize.TabIndex = 5;
            this.nudBorderLeftSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // cmbBorderLeftStyle
            // 
            this.cmbBorderLeftStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbBorderLeftStyle.LabelText = "Style";
            this.cmbBorderLeftStyle.Location = new System.Drawing.Point(20, 96);
            this.cmbBorderLeftStyle.Name = "cmbBorderLeftStyle";
            this.cmbBorderLeftStyle.Size = new System.Drawing.Size(125, 53);
            this.cmbBorderLeftStyle.TabIndex = 6;
            this.cmbBorderLeftStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // btnBorderLeftColor
            // 
            this.btnBorderLeftColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnBorderLeftColor.Location = new System.Drawing.Point(19, 47);
            this.btnBorderLeftColor.Name = "btnBorderLeftColor";
            this.btnBorderLeftColor.Size = new System.Drawing.Size(126, 32);
            this.btnBorderLeftColor.TabIndex = 7;
            this.btnBorderLeftColor.Text = "Color";
            this.btnBorderLeftColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.FromName("@window");
            this.groupBox3.Controls.Add(this.btnBorderLeftColor);
            this.groupBox3.Controls.Add(this.cmbBorderLeftStyle);
            this.groupBox3.Controls.Add(this.nudBorderLeftSize);
            this.groupBox3.Controls.Add(this.nudBorderLeftRadius);
            this.groupBox3.Location = new System.Drawing.Point(717, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 301);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.Text = "BorderStyle Left";
            // 
            // nudBorderRightRadius
            // 
            this.nudBorderRightRadius.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderRightRadius.LabelText = "Radius";
            this.nudBorderRightRadius.Location = new System.Drawing.Point(20, 236);
            this.nudBorderRightRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderRightRadius.Name = "nudBorderRightRadius";
            this.nudBorderRightRadius.Size = new System.Drawing.Size(125, 53);
            this.nudBorderRightRadius.TabIndex = 4;
            this.nudBorderRightRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // nudBorderRightSize
            // 
            this.nudBorderRightSize.Anchor = Wisej.Web.AnchorStyles.None;
            this.nudBorderRightSize.LabelText = "Size";
            this.nudBorderRightSize.Location = new System.Drawing.Point(20, 166);
            this.nudBorderRightSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderRightSize.Name = "nudBorderRightSize";
            this.nudBorderRightSize.Size = new System.Drawing.Size(125, 53);
            this.nudBorderRightSize.TabIndex = 5;
            this.nudBorderRightSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // cmbBorderRightStyle
            // 
            this.cmbBorderRightStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.cmbBorderRightStyle.LabelText = "Style";
            this.cmbBorderRightStyle.Location = new System.Drawing.Point(20, 96);
            this.cmbBorderRightStyle.Name = "cmbBorderRightStyle";
            this.cmbBorderRightStyle.Size = new System.Drawing.Size(125, 53);
            this.cmbBorderRightStyle.TabIndex = 6;
            this.cmbBorderRightStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // btnBorderRightColor
            // 
            this.btnBorderRightColor.Anchor = Wisej.Web.AnchorStyles.None;
            this.btnBorderRightColor.Location = new System.Drawing.Point(19, 47);
            this.btnBorderRightColor.Name = "btnBorderRightColor";
            this.btnBorderRightColor.Size = new System.Drawing.Size(126, 32);
            this.btnBorderRightColor.TabIndex = 7;
            this.btnBorderRightColor.Text = "Color";
            this.btnBorderRightColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = Wisej.Web.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.FromName("@window");
            this.groupBox4.Controls.Add(this.btnBorderRightColor);
            this.groupBox4.Controls.Add(this.cmbBorderRightStyle);
            this.groupBox4.Controls.Add(this.nudBorderRightSize);
            this.groupBox4.Controls.Add(this.nudBorderRightRadius);
            this.groupBox4.Location = new System.Drawing.Point(330, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 301);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.Text = "BorderStyle Right";
            // 
            // Appearance
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shape1);
            this.MinimumSize = new System.Drawing.Size(940, 400);
            this.Name = "Appearance";
            this.Load += new System.EventHandler(this.Features_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderTopRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderTopSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftSize)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderRightRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorderRightSize)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.Shape shape1;
        private Web.NumericUpDown nudBorderTopRadius;
        private Web.NumericUpDown nudBorderTopSize;
        private Web.ComboBox cmbBorderTopStyle;
        private Web.Button btnBorderTopColor;
        private Web.GroupBox groupBox1;
        private Web.NumericUpDown nudBorderBottomRadius;
        private Web.NumericUpDown nudBorderBottomSize;
        private Web.ComboBox cmbBorderBottomStyle;
        private Web.Button btnBorderBottomColor;
        private Web.GroupBox groupBox2;
        private Web.NumericUpDown nudBorderLeftRadius;
        private Web.NumericUpDown nudBorderLeftSize;
        private Web.ComboBox cmbBorderLeftStyle;
        private Web.Button btnBorderLeftColor;
        private Web.GroupBox groupBox3;
        private Web.NumericUpDown nudBorderRightRadius;
        private Web.NumericUpDown nudBorderRightSize;
        private Web.ComboBox cmbBorderRightStyle;
        private Web.Button btnBorderRightColor;
        private Web.GroupBox groupBox4;
    }
}
