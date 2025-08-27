namespace Wisej.DemoBrowser.jQueryKnob
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
            this.knob1 = new Wisej.Web.Ext.jQueryKnob.Knob();
            this.numericUpDownValue = new Wisej.Web.NumericUpDown();
            this.comboBoxKnobType = new Wisej.Web.ComboBox();
            this.comboBoxCapStyle = new Wisej.Web.ComboBox();
            this.panel1 = new Wisej.Web.Panel();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // knob1
            // 
            this.knob1.Anchor = Wisej.Web.AnchorStyles.None;
            this.flowLayoutPanel1.SetFillWeight(this.knob1, 1);
            this.knob1.Location = new System.Drawing.Point(608, 3);
            this.knob1.MinimumSize = new System.Drawing.Size(300, 0);
            this.knob1.Name = "knob1";
            this.knob1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("knob1.ResponsiveProfiles"))));
            this.knob1.Size = new System.Drawing.Size(599, 297);
            this.knob1.TabIndex = 0;
            this.knob1.Text = "knob1";
            this.knob1.Value = 50;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Anchor = Wisej.Web.AnchorStyles.None;
            this.numericUpDownValue.LabelText = "Value";
            this.numericUpDownValue.Location = new System.Drawing.Point(199, 209);
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("numericUpDownValue.ResponsiveProfiles"))));
            this.numericUpDownValue.Size = new System.Drawing.Size(200, 53);
            this.numericUpDownValue.TabIndex = 1;
            this.numericUpDownValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownValue.ValueChanged += new System.EventHandler(this.numericUpDownValue_ValueChanged);
            // 
            // comboBoxKnobType
            // 
            this.comboBoxKnobType.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxKnobType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxKnobType.Items.AddRange(new object[] {
            "Gauge",
            "Cursor"});
            this.comboBoxKnobType.LabelText = "Knob Type";
            this.comboBoxKnobType.Location = new System.Drawing.Point(199, 122);
            this.comboBoxKnobType.Name = "comboBoxKnobType";
            this.comboBoxKnobType.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("comboBoxKnobType.ResponsiveProfiles"))));
            this.comboBoxKnobType.Size = new System.Drawing.Size(200, 53);
            this.comboBoxKnobType.TabIndex = 2;
            this.comboBoxKnobType.Text = "Gauge";
            this.comboBoxKnobType.SelectedIndexChanged += new System.EventHandler(this.comboBoxKnobType_SelectedIndexChanged);
            // 
            // comboBoxCapStyle
            // 
            this.comboBoxCapStyle.Anchor = Wisej.Web.AnchorStyles.None;
            this.comboBoxCapStyle.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxCapStyle.Items.AddRange(new object[] {
            "Butt",
            "Round"});
            this.comboBoxCapStyle.LabelText = "Line Cap Style";
            this.comboBoxCapStyle.Location = new System.Drawing.Point(199, 35);
            this.comboBoxCapStyle.Name = "comboBoxCapStyle";
            this.comboBoxCapStyle.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("comboBoxCapStyle.ResponsiveProfiles"))));
            this.comboBoxCapStyle.Size = new System.Drawing.Size(200, 53);
            this.comboBoxCapStyle.TabIndex = 3;
            this.comboBoxCapStyle.Text = "Butt";
            this.comboBoxCapStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxCapStyle_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxCapStyle);
            this.panel1.Controls.Add(this.comboBoxKnobType);
            this.panel1.Controls.Add(this.numericUpDownValue);
            this.flowLayoutPanel1.SetFillWeight(this.panel1, 1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MinimumSize = new System.Drawing.Size(225, 0);
            this.panel1.Name = "panel1";
            this.panel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panel1.ResponsiveProfiles"))));
            this.panel1.Size = new System.Drawing.Size(599, 297);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.knob1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(106, 85);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowLayoutPanel1.ResponsiveProfiles"))));
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1210, 305);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Features
            // 
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Features";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Web.Ext.jQueryKnob.Knob knob1;
		private Web.NumericUpDown numericUpDownValue;
		private Web.ComboBox comboBoxKnobType;
		private Web.ComboBox comboBoxCapStyle;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Panel panel1;
    }
}
