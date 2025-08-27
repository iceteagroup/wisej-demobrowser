namespace Wisej.DemoBrowser.Shape
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Features));
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
            this.spacer2 = new Wisej.Web.Spacer();
            this.spacer1 = new Wisej.Web.Spacer();
            this.panel5 = new Wisej.Web.Panel();
            this.shape1 = new Wisej.Web.Shape();
            this.spacer3 = new Wisej.Web.Spacer();
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
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBorderTopColor);
            this.panel1.Controls.Add(this.cmbBorderTopStyle);
            this.panel1.Controls.Add(this.nudBorderTopSize);
            this.panel1.Controls.Add(this.nudBorderTopRadius);
            this.panel1.CssClass = "shadow";
            this.panel1.Location = new System.Drawing.Point(665, 3);
            this.panel1.Margin = new Wisej.Web.Padding(16, 3, 3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(145, 0);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(165, 336);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = Wisej.Web.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 301);
            this.label1.Name = "label1";
            this.label1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label1.ResponsiveProfiles"))));
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "BorderStyle Top";
            // 
            // btnBorderTopColor
            // 
            this.btnBorderTopColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.btnBorderTopColor.Location = new System.Drawing.Point(21, 18);
            this.btnBorderTopColor.Name = "btnBorderTopColor";
            this.btnBorderTopColor.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnBorderTopColor.ResponsiveProfiles"))));
            this.btnBorderTopColor.Size = new System.Drawing.Size(122, 43);
            this.btnBorderTopColor.TabIndex = 11;
            this.btnBorderTopColor.Text = "Top Color";
            this.btnBorderTopColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // cmbBorderTopStyle
            // 
            this.cmbBorderTopStyle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.cmbBorderTopStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbBorderTopStyle.LabelText = "Style";
            this.cmbBorderTopStyle.Location = new System.Drawing.Point(18, 82);
            this.cmbBorderTopStyle.Name = "cmbBorderTopStyle";
            this.cmbBorderTopStyle.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cmbBorderTopStyle.ResponsiveProfiles"))));
            this.cmbBorderTopStyle.Size = new System.Drawing.Size(130, 53);
            this.cmbBorderTopStyle.TabIndex = 10;
            this.cmbBorderTopStyle.Text = "Solid";
            this.cmbBorderTopStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // nudBorderTopSize
            // 
            this.nudBorderTopSize.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderTopSize.LabelText = "Size";
            this.nudBorderTopSize.Location = new System.Drawing.Point(18, 146);
            this.nudBorderTopSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderTopSize.Name = "nudBorderTopSize";
            this.nudBorderTopSize.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderTopSize.ResponsiveProfiles"))));
            this.nudBorderTopSize.Size = new System.Drawing.Size(130, 53);
            this.nudBorderTopSize.TabIndex = 9;
            this.nudBorderTopSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // nudBorderTopRadius
            // 
            this.nudBorderTopRadius.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderTopRadius.LabelText = "Radius";
            this.nudBorderTopRadius.Location = new System.Drawing.Point(18, 210);
            this.nudBorderTopRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderTopRadius.Name = "nudBorderTopRadius";
            this.nudBorderTopRadius.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderTopRadius.ResponsiveProfiles"))));
            this.nudBorderTopRadius.Size = new System.Drawing.Size(130, 53);
            this.nudBorderTopRadius.TabIndex = 8;
            this.nudBorderTopRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnBorderRightColor);
            this.panel2.Controls.Add(this.cmbBorderRightStyle);
            this.panel2.Controls.Add(this.nudBorderRightSize);
            this.panel2.Controls.Add(this.nudBorderRightRadius);
            this.panel2.Controls.Add(this.label2);
            this.panel2.CssClass = "shadow";
            this.panel2.Location = new System.Drawing.Point(481, 3);
            this.panel2.Margin = new Wisej.Web.Padding(16, 3, 3, 3);
            this.panel2.MinimumSize = new System.Drawing.Size(145, 0);
            this.panel2.Name = "panel2";
            this.panel2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel2.ResponsiveProfiles"))));
            this.panel2.Size = new System.Drawing.Size(165, 336);
            this.panel2.TabIndex = 13;
            // 
            // btnBorderRightColor
            // 
            this.btnBorderRightColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.btnBorderRightColor.Location = new System.Drawing.Point(21, 18);
            this.btnBorderRightColor.Name = "btnBorderRightColor";
            this.btnBorderRightColor.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnBorderRightColor.ResponsiveProfiles"))));
            this.btnBorderRightColor.Size = new System.Drawing.Size(122, 43);
            this.btnBorderRightColor.TabIndex = 16;
            this.btnBorderRightColor.Text = "Right Color";
            this.btnBorderRightColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // cmbBorderRightStyle
            // 
            this.cmbBorderRightStyle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.cmbBorderRightStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbBorderRightStyle.LabelText = "Style";
            this.cmbBorderRightStyle.Location = new System.Drawing.Point(18, 82);
            this.cmbBorderRightStyle.Name = "cmbBorderRightStyle";
            this.cmbBorderRightStyle.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cmbBorderRightStyle.ResponsiveProfiles"))));
            this.cmbBorderRightStyle.Size = new System.Drawing.Size(130, 53);
            this.cmbBorderRightStyle.TabIndex = 15;
            this.cmbBorderRightStyle.Text = "Solid";
            this.cmbBorderRightStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // nudBorderRightSize
            // 
            this.nudBorderRightSize.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderRightSize.LabelText = "Size";
            this.nudBorderRightSize.Location = new System.Drawing.Point(18, 146);
            this.nudBorderRightSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderRightSize.Name = "nudBorderRightSize";
            this.nudBorderRightSize.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderRightSize.ResponsiveProfiles"))));
            this.nudBorderRightSize.Size = new System.Drawing.Size(130, 53);
            this.nudBorderRightSize.TabIndex = 14;
            this.nudBorderRightSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // nudBorderRightRadius
            // 
            this.nudBorderRightRadius.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderRightRadius.LabelText = "Radius";
            this.nudBorderRightRadius.Location = new System.Drawing.Point(18, 210);
            this.nudBorderRightRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderRightRadius.Name = "nudBorderRightRadius";
            this.nudBorderRightRadius.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderRightRadius.ResponsiveProfiles"))));
            this.nudBorderRightRadius.Size = new System.Drawing.Size(130, 53);
            this.nudBorderRightRadius.TabIndex = 13;
            this.nudBorderRightRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = Wisej.Web.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 301);
            this.label2.Name = "label2";
            this.label2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label2.ResponsiveProfiles"))));
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "BorderStyle Right";
            // 
            // panel3
            // 
            this.panel3.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnBorderBottomColor);
            this.panel3.Controls.Add(this.cmbBorderBottomStyle);
            this.panel3.Controls.Add(this.nudBorderBottomSize);
            this.panel3.Controls.Add(this.nudBorderBottomRadius);
            this.panel3.Controls.Add(this.label3);
            this.panel3.CssClass = "shadow";
            this.panel3.Location = new System.Drawing.Point(297, 3);
            this.panel3.Margin = new Wisej.Web.Padding(16, 3, 3, 3);
            this.panel3.MinimumSize = new System.Drawing.Size(145, 0);
            this.panel3.Name = "panel3";
            this.panel3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel3.ResponsiveProfiles"))));
            this.panel3.Size = new System.Drawing.Size(165, 336);
            this.panel3.TabIndex = 17;
            // 
            // btnBorderBottomColor
            // 
            this.btnBorderBottomColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.btnBorderBottomColor.Location = new System.Drawing.Point(21, 18);
            this.btnBorderBottomColor.Name = "btnBorderBottomColor";
            this.btnBorderBottomColor.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnBorderBottomColor.ResponsiveProfiles"))));
            this.btnBorderBottomColor.Size = new System.Drawing.Size(122, 43);
            this.btnBorderBottomColor.TabIndex = 16;
            this.btnBorderBottomColor.Text = "Bottom Color";
            this.btnBorderBottomColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // cmbBorderBottomStyle
            // 
            this.cmbBorderBottomStyle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.cmbBorderBottomStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbBorderBottomStyle.LabelText = "Style";
            this.cmbBorderBottomStyle.Location = new System.Drawing.Point(18, 82);
            this.cmbBorderBottomStyle.Name = "cmbBorderBottomStyle";
            this.cmbBorderBottomStyle.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cmbBorderBottomStyle.ResponsiveProfiles"))));
            this.cmbBorderBottomStyle.Size = new System.Drawing.Size(130, 53);
            this.cmbBorderBottomStyle.TabIndex = 15;
            this.cmbBorderBottomStyle.Text = "Solid";
            this.cmbBorderBottomStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // nudBorderBottomSize
            // 
            this.nudBorderBottomSize.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderBottomSize.LabelText = "Size";
            this.nudBorderBottomSize.Location = new System.Drawing.Point(18, 146);
            this.nudBorderBottomSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderBottomSize.Name = "nudBorderBottomSize";
            this.nudBorderBottomSize.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderBottomSize.ResponsiveProfiles"))));
            this.nudBorderBottomSize.Size = new System.Drawing.Size(130, 53);
            this.nudBorderBottomSize.TabIndex = 14;
            this.nudBorderBottomSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // nudBorderBottomRadius
            // 
            this.nudBorderBottomRadius.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderBottomRadius.LabelText = "Radius";
            this.nudBorderBottomRadius.Location = new System.Drawing.Point(18, 210);
            this.nudBorderBottomRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderBottomRadius.Name = "nudBorderBottomRadius";
            this.nudBorderBottomRadius.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderBottomRadius.ResponsiveProfiles"))));
            this.nudBorderBottomRadius.Size = new System.Drawing.Size(130, 53);
            this.nudBorderBottomRadius.TabIndex = 13;
            this.nudBorderBottomRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = Wisej.Web.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 301);
            this.label3.Name = "label3";
            this.label3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label3.ResponsiveProfiles"))));
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "BorderStyle Bottom";
            // 
            // panel4
            // 
            this.panel4.Anchor = Wisej.Web.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnBorderLeftColor);
            this.panel4.Controls.Add(this.cmbBorderLeftStyle);
            this.panel4.Controls.Add(this.nudBorderLeftSize);
            this.panel4.Controls.Add(this.nudBorderLeftRadius);
            this.panel4.Controls.Add(this.label4);
            this.panel4.CssClass = "shadow";
            this.panel4.Location = new System.Drawing.Point(113, 3);
            this.panel4.Margin = new Wisej.Web.Padding(16, 3, 3, 3);
            this.panel4.MinimumSize = new System.Drawing.Size(145, 0);
            this.panel4.Name = "panel4";
            this.panel4.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel4.ResponsiveProfiles"))));
            this.panel4.Size = new System.Drawing.Size(165, 336);
            this.panel4.TabIndex = 18;
            // 
            // btnBorderLeftColor
            // 
            this.btnBorderLeftColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.btnBorderLeftColor.Location = new System.Drawing.Point(23, 18);
            this.btnBorderLeftColor.Name = "btnBorderLeftColor";
            this.btnBorderLeftColor.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("btnBorderLeftColor.ResponsiveProfiles"))));
            this.btnBorderLeftColor.Size = new System.Drawing.Size(120, 43);
            this.btnBorderLeftColor.TabIndex = 16;
            this.btnBorderLeftColor.Text = "Left Color";
            this.btnBorderLeftColor.Click += new System.EventHandler(this.ChangeColor_Clicked);
            // 
            // cmbBorderLeftStyle
            // 
            this.cmbBorderLeftStyle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.cmbBorderLeftStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.cmbBorderLeftStyle.LabelText = "Style";
            this.cmbBorderLeftStyle.Location = new System.Drawing.Point(19, 82);
            this.cmbBorderLeftStyle.Name = "cmbBorderLeftStyle";
            this.cmbBorderLeftStyle.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("cmbBorderLeftStyle.ResponsiveProfiles"))));
            this.cmbBorderLeftStyle.Size = new System.Drawing.Size(128, 53);
            this.cmbBorderLeftStyle.TabIndex = 15;
            this.cmbBorderLeftStyle.Text = "Solid";
            this.cmbBorderLeftStyle.SelectedIndexChanged += new System.EventHandler(this.Style_SelectedIndexChanged);
            // 
            // nudBorderLeftSize
            // 
            this.nudBorderLeftSize.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderLeftSize.LabelText = "Size";
            this.nudBorderLeftSize.Location = new System.Drawing.Point(19, 146);
            this.nudBorderLeftSize.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderLeftSize.Name = "nudBorderLeftSize";
            this.nudBorderLeftSize.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderLeftSize.ResponsiveProfiles"))));
            this.nudBorderLeftSize.Size = new System.Drawing.Size(128, 53);
            this.nudBorderLeftSize.TabIndex = 14;
            this.nudBorderLeftSize.ValueChanged += new System.EventHandler(this.Size_ValueChanged);
            // 
            // nudBorderLeftRadius
            // 
            this.nudBorderLeftRadius.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.nudBorderLeftRadius.LabelText = "Radius";
            this.nudBorderLeftRadius.Location = new System.Drawing.Point(19, 210);
            this.nudBorderLeftRadius.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudBorderLeftRadius.Name = "nudBorderLeftRadius";
            this.nudBorderLeftRadius.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("nudBorderLeftRadius.ResponsiveProfiles"))));
            this.nudBorderLeftRadius.Size = new System.Drawing.Size(128, 53);
            this.nudBorderLeftRadius.TabIndex = 13;
            this.nudBorderLeftRadius.ValueChanged += new System.EventHandler(this.Radius_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 301);
            this.label4.Name = "label4";
            this.label4.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("label4.ResponsiveProfiles"))));
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "BorderStyle Left";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.spacer2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.spacer1);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.spacer3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowLayoutPanel1.ResponsiveProfiles"))));
            this.flowLayoutPanel1.ScrollBars = Wisej.Web.ScrollBars.Hidden;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1331, 344);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // spacer2
            // 
            this.flowLayoutPanel1.SetFillWeight(this.spacer2, 1);
            this.spacer2.Location = new System.Drawing.Point(3, 3);
            this.spacer2.Name = "spacer2";
            this.spacer2.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("spacer2.ResponsiveProfiles"))));
            this.spacer2.Size = new System.Drawing.Size(91, 336);
            // 
            // spacer1
            // 
            this.flowLayoutPanel1.SetFillWeight(this.spacer1, 1);
            this.spacer1.Location = new System.Drawing.Point(836, 3);
            this.spacer1.Name = "spacer1";
            this.spacer1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("spacer1.ResponsiveProfiles"))));
            this.spacer1.Size = new System.Drawing.Size(90, 336);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.shape1);
            this.panel5.Location = new System.Drawing.Point(932, 3);
            this.panel5.MinimumSize = new System.Drawing.Size(300, 0);
            this.panel5.Name = "panel5";
            this.panel5.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel5.ResponsiveProfiles"))));
            this.panel5.Size = new System.Drawing.Size(300, 336);
            this.panel5.TabIndex = 30;
            // 
            // shape1
            // 
            this.shape1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
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
            this.shape1.Location = new System.Drawing.Point(10, 64);
            this.shape1.Margin = new Wisej.Web.Padding(10, 20, 20, 20);
            this.shape1.Name = "shape1";
            this.shape1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("shape1.ResponsiveProfiles"))));
            this.shape1.Size = new System.Drawing.Size(280, 209);
            // 
            // spacer3
            // 
            this.flowLayoutPanel1.SetFillWeight(this.spacer3, 1);
            this.spacer3.Location = new System.Drawing.Point(1238, 3);
            this.spacer3.Name = "spacer3";
            this.spacer3.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("spacer3.ResponsiveProfiles"))));
            this.spacer3.Size = new System.Drawing.Size(90, 336);
            // 
            // Features
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(0, 32, 0, 0);
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
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Web.Panel panel5;
        private Web.Shape shape1;
        private Web.Spacer spacer1;
        private Web.Spacer spacer2;
        private Web.Spacer spacer3;
    }
}
