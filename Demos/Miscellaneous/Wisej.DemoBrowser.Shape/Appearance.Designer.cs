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
			this.panel1 = new Wisej.Web.Panel();
			this.label1 = new Wisej.Web.Label();
			this.btnBorderTopColor = new Wisej.Web.Button();
			this.cmbBorderTopStyle = new Wisej.Web.ComboBox();
			this.nudBorderTopSize = new Wisej.Web.NumericUpDown();
			this.nudBorderTopRadius = new Wisej.Web.NumericUpDown();
			this.panel2 = new Wisej.Web.Panel();
			this.btnBorderRightColor = new Wisej.Web.Button();
			this.cmbBorderRightStyle = new Wisej.Web.ComboBox();
			this.nudBorderRightSize = new Wisej.Web.NumericUpDown();
			this.nudBorderRightRadius = new Wisej.Web.NumericUpDown();
			this.label2 = new Wisej.Web.Label();
			this.panel3 = new Wisej.Web.Panel();
			this.btnBorderBottomColor = new Wisej.Web.Button();
			this.cmbBorderBottomStyle = new Wisej.Web.ComboBox();
			this.nudBorderBottomSize = new Wisej.Web.NumericUpDown();
			this.nudBorderBottomRadius = new Wisej.Web.NumericUpDown();
			this.label3 = new Wisej.Web.Label();
			this.panel4 = new Wisej.Web.Panel();
			this.btnBorderLeftColor = new Wisej.Web.Button();
			this.cmbBorderLeftStyle = new Wisej.Web.ComboBox();
			this.nudBorderLeftSize = new Wisej.Web.NumericUpDown();
			this.nudBorderLeftRadius = new Wisej.Web.NumericUpDown();
			this.label4 = new Wisej.Web.Label();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderTopSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderTopRadius)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderRightSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderRightRadius)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomRadius)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftRadius)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// shape1
			// 
			this.shape1.Anchor = Wisej.Web.AnchorStyles.None;
			this.shape1.BackColor = System.Drawing.Color.White;
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
			this.shape1.Location = new System.Drawing.Point(840, 41);
			this.shape1.Margin = new Wisej.Web.Padding(20);
			this.shape1.Name = "shape1";
			this.shape1.Size = new System.Drawing.Size(315, 294);
			// 
			// panel1
			// 
			this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnBorderTopColor);
			this.panel1.Controls.Add(this.cmbBorderTopStyle);
			this.panel1.Controls.Add(this.nudBorderTopSize);
			this.panel1.Controls.Add(this.nudBorderTopRadius);
			this.panel1.Location = new System.Drawing.Point(635, 20);
			this.panel1.Margin = new Wisej.Web.Padding(20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(165, 336);
			this.panel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 301);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 15);
			this.label1.TabIndex = 12;
			this.label1.Text = "BorderStyle Top";
			// 
			// btnBorderTopColor
			// 
			this.btnBorderTopColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.btnBorderTopColor.Location = new System.Drawing.Point(19, 18);
			this.btnBorderTopColor.Name = "btnBorderTopColor";
			this.btnBorderTopColor.Size = new System.Drawing.Size(126, 43);
			this.btnBorderTopColor.TabIndex = 11;
			this.btnBorderTopColor.Text = "Color";
			this.btnBorderTopColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
			// 
			// cmbBorderTopStyle
			// 
			this.cmbBorderTopStyle.Anchor = Wisej.Web.AnchorStyles.None;
			this.cmbBorderTopStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.cmbBorderTopStyle.LabelText = "Style";
			this.cmbBorderTopStyle.Location = new System.Drawing.Point(20, 82);
			this.cmbBorderTopStyle.Name = "cmbBorderTopStyle";
			this.cmbBorderTopStyle.Size = new System.Drawing.Size(125, 42);
			this.cmbBorderTopStyle.TabIndex = 10;
			this.cmbBorderTopStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
			// 
			// nudBorderTopSize
			// 
			this.nudBorderTopSize.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderTopSize.LabelText = "Size";
			this.nudBorderTopSize.Location = new System.Drawing.Point(20, 146);
			this.nudBorderTopSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderTopSize.Name = "nudBorderTopSize";
			this.nudBorderTopSize.Size = new System.Drawing.Size(125, 42);
			this.nudBorderTopSize.TabIndex = 9;
			this.nudBorderTopSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
			// 
			// nudBorderTopRadius
			// 
			this.nudBorderTopRadius.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderTopRadius.LabelText = "Radius";
			this.nudBorderTopRadius.Location = new System.Drawing.Point(20, 210);
			this.nudBorderTopRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderTopRadius.Name = "nudBorderTopRadius";
			this.nudBorderTopRadius.Size = new System.Drawing.Size(125, 42);
			this.nudBorderTopRadius.TabIndex = 8;
			this.nudBorderTopRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
			// 
			// panel2
			// 
			this.panel2.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel2.Controls.Add(this.btnBorderRightColor);
			this.panel2.Controls.Add(this.cmbBorderRightStyle);
			this.panel2.Controls.Add(this.nudBorderRightSize);
			this.panel2.Controls.Add(this.nudBorderRightRadius);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(430, 20);
			this.panel2.Margin = new Wisej.Web.Padding(20);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(165, 336);
			this.panel2.TabIndex = 13;
			// 
			// btnBorderRightColor
			// 
			this.btnBorderRightColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.btnBorderRightColor.Location = new System.Drawing.Point(22, 18);
			this.btnBorderRightColor.Name = "btnBorderRightColor";
			this.btnBorderRightColor.Size = new System.Drawing.Size(126, 43);
			this.btnBorderRightColor.TabIndex = 16;
			this.btnBorderRightColor.Text = "Color";
			this.btnBorderRightColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
			// 
			// cmbBorderRightStyle
			// 
			this.cmbBorderRightStyle.Anchor = Wisej.Web.AnchorStyles.None;
			this.cmbBorderRightStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.cmbBorderRightStyle.LabelText = "Style";
			this.cmbBorderRightStyle.Location = new System.Drawing.Point(23, 82);
			this.cmbBorderRightStyle.Name = "cmbBorderRightStyle";
			this.cmbBorderRightStyle.Size = new System.Drawing.Size(125, 42);
			this.cmbBorderRightStyle.TabIndex = 15;
			this.cmbBorderRightStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
			// 
			// nudBorderRightSize
			// 
			this.nudBorderRightSize.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderRightSize.LabelText = "Size";
			this.nudBorderRightSize.Location = new System.Drawing.Point(23, 146);
			this.nudBorderRightSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderRightSize.Name = "nudBorderRightSize";
			this.nudBorderRightSize.Size = new System.Drawing.Size(125, 42);
			this.nudBorderRightSize.TabIndex = 14;
			this.nudBorderRightSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
			// 
			// nudBorderRightRadius
			// 
			this.nudBorderRightRadius.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderRightRadius.LabelText = "Radius";
			this.nudBorderRightRadius.Location = new System.Drawing.Point(23, 210);
			this.nudBorderRightRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderRightRadius.Name = "nudBorderRightRadius";
			this.nudBorderRightRadius.Size = new System.Drawing.Size(125, 42);
			this.nudBorderRightRadius.TabIndex = 13;
			this.nudBorderRightRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
			// 
			// label2
			// 
			this.label2.Anchor = Wisej.Web.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 301);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "BorderStyle Right";
			// 
			// panel3
			// 
			this.panel3.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel3.Controls.Add(this.btnBorderBottomColor);
			this.panel3.Controls.Add(this.cmbBorderBottomStyle);
			this.panel3.Controls.Add(this.nudBorderBottomSize);
			this.panel3.Controls.Add(this.nudBorderBottomRadius);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Location = new System.Drawing.Point(225, 20);
			this.panel3.Margin = new Wisej.Web.Padding(20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(165, 336);
			this.panel3.TabIndex = 17;
			// 
			// btnBorderBottomColor
			// 
			this.btnBorderBottomColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.btnBorderBottomColor.Location = new System.Drawing.Point(22, 18);
			this.btnBorderBottomColor.Name = "btnBorderBottomColor";
			this.btnBorderBottomColor.Size = new System.Drawing.Size(126, 43);
			this.btnBorderBottomColor.TabIndex = 16;
			this.btnBorderBottomColor.Text = "Color";
			this.btnBorderBottomColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
			// 
			// cmbBorderBottomStyle
			// 
			this.cmbBorderBottomStyle.Anchor = Wisej.Web.AnchorStyles.None;
			this.cmbBorderBottomStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.cmbBorderBottomStyle.LabelText = "Style";
			this.cmbBorderBottomStyle.Location = new System.Drawing.Point(23, 82);
			this.cmbBorderBottomStyle.Name = "cmbBorderBottomStyle";
			this.cmbBorderBottomStyle.Size = new System.Drawing.Size(125, 42);
			this.cmbBorderBottomStyle.TabIndex = 15;
			this.cmbBorderBottomStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
			// 
			// nudBorderBottomSize
			// 
			this.nudBorderBottomSize.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderBottomSize.LabelText = "Size";
			this.nudBorderBottomSize.Location = new System.Drawing.Point(23, 146);
			this.nudBorderBottomSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderBottomSize.Name = "nudBorderBottomSize";
			this.nudBorderBottomSize.Size = new System.Drawing.Size(125, 42);
			this.nudBorderBottomSize.TabIndex = 14;
			this.nudBorderBottomSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
			// 
			// nudBorderBottomRadius
			// 
			this.nudBorderBottomRadius.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderBottomRadius.LabelText = "Radius";
			this.nudBorderBottomRadius.Location = new System.Drawing.Point(23, 210);
			this.nudBorderBottomRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderBottomRadius.Name = "nudBorderBottomRadius";
			this.nudBorderBottomRadius.Size = new System.Drawing.Size(125, 42);
			this.nudBorderBottomRadius.TabIndex = 13;
			this.nudBorderBottomRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
			// 
			// label3
			// 
			this.label3.Anchor = Wisej.Web.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 301);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 15);
			this.label3.TabIndex = 12;
			this.label3.Text = "BorderStyle Bottom";
			// 
			// panel4
			// 
			this.panel4.Anchor = Wisej.Web.AnchorStyles.None;
			this.panel4.Controls.Add(this.btnBorderLeftColor);
			this.panel4.Controls.Add(this.cmbBorderLeftStyle);
			this.panel4.Controls.Add(this.nudBorderLeftSize);
			this.panel4.Controls.Add(this.nudBorderLeftRadius);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(20, 20);
			this.panel4.Margin = new Wisej.Web.Padding(20);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(165, 336);
			this.panel4.TabIndex = 18;
			// 
			// btnBorderLeftColor
			// 
			this.btnBorderLeftColor.Anchor = Wisej.Web.AnchorStyles.None;
			this.btnBorderLeftColor.Location = new System.Drawing.Point(22, 18);
			this.btnBorderLeftColor.Name = "btnBorderLeftColor";
			this.btnBorderLeftColor.Size = new System.Drawing.Size(126, 43);
			this.btnBorderLeftColor.TabIndex = 16;
			this.btnBorderLeftColor.Text = "Color";
			this.btnBorderLeftColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
			// 
			// cmbBorderLeftStyle
			// 
			this.cmbBorderLeftStyle.Anchor = Wisej.Web.AnchorStyles.None;
			this.cmbBorderLeftStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.cmbBorderLeftStyle.LabelText = "Style";
			this.cmbBorderLeftStyle.Location = new System.Drawing.Point(23, 82);
			this.cmbBorderLeftStyle.Name = "cmbBorderLeftStyle";
			this.cmbBorderLeftStyle.Size = new System.Drawing.Size(125, 42);
			this.cmbBorderLeftStyle.TabIndex = 15;
			this.cmbBorderLeftStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
			// 
			// nudBorderLeftSize
			// 
			this.nudBorderLeftSize.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderLeftSize.LabelText = "Size";
			this.nudBorderLeftSize.Location = new System.Drawing.Point(23, 146);
			this.nudBorderLeftSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderLeftSize.Name = "nudBorderLeftSize";
			this.nudBorderLeftSize.Size = new System.Drawing.Size(125, 42);
			this.nudBorderLeftSize.TabIndex = 14;
			this.nudBorderLeftSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
			// 
			// nudBorderLeftRadius
			// 
			this.nudBorderLeftRadius.Anchor = Wisej.Web.AnchorStyles.None;
			this.nudBorderLeftRadius.LabelText = "Radius";
			this.nudBorderLeftRadius.Location = new System.Drawing.Point(23, 210);
			this.nudBorderLeftRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
			this.nudBorderLeftRadius.Name = "nudBorderLeftRadius";
			this.nudBorderLeftRadius.Size = new System.Drawing.Size(125, 42);
			this.nudBorderLeftRadius.TabIndex = 13;
			this.nudBorderLeftRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
			// 
			// label4
			// 
			this.label4.Anchor = Wisej.Web.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 301);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "BorderStyle Left";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.shape1);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 26);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1175, 376);
			this.flowLayoutPanel1.TabIndex = 20;
			// 
			// Appearance
			// 
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Appearance";
			this.Size = new System.Drawing.Size(1257, 434);
			this.Load += new System.EventHandler(this.Features_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderTopSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderTopRadius)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderRightSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderRightRadius)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderBottomRadius)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudBorderLeftRadius)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Web.Shape shape1;
        private Web.Panel panel1;
        private Web.Label label1;
        private Web.Button btnBorderTopColor;
        private Web.ComboBox cmbBorderTopStyle;
        private Web.NumericUpDown nudBorderTopSize;
        private Web.NumericUpDown nudBorderTopRadius;
        private Web.Panel panel2;
        private Web.Button btnBorderRightColor;
        private Web.ComboBox cmbBorderRightStyle;
        private Web.NumericUpDown nudBorderRightSize;
        private Web.NumericUpDown nudBorderRightRadius;
        private Web.Label label2;
        private Web.Panel panel3;
        private Web.Button btnBorderBottomColor;
        private Web.ComboBox cmbBorderBottomStyle;
        private Web.NumericUpDown nudBorderBottomSize;
        private Web.NumericUpDown nudBorderBottomRadius;
        private Web.Label label3;
        private Web.Panel panel4;
        private Web.Button btnBorderLeftColor;
        private Web.ComboBox cmbBorderLeftStyle;
        private Web.NumericUpDown nudBorderLeftSize;
        private Web.NumericUpDown nudBorderLeftRadius;
        private Web.Label label4;
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
