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
			this.knob1 = new Wisej.Web.Ext.jQueryKnob.Knob();
			this.numericUpDownValue = new Wisej.Web.NumericUpDown();
			this.comboBoxKnobType = new Wisej.Web.ComboBox();
			this.comboBoxCapStyle = new Wisej.Web.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
			this.SuspendLayout();
			// 
			// knob1
			// 
			this.knob1.Anchor = Wisej.Web.AnchorStyles.None;
			this.knob1.Location = new System.Drawing.Point(545, 89);
			this.knob1.Name = "knob1";
			this.knob1.Size = new System.Drawing.Size(638, 297);
			this.knob1.TabIndex = 0;
			this.knob1.Text = "knob1";
			// 
			// numericUpDownValue
			// 
			this.numericUpDownValue.Anchor = Wisej.Web.AnchorStyles.None;
			this.numericUpDownValue.LabelText = "Value";
			this.numericUpDownValue.Location = new System.Drawing.Point(240, 298);
			this.numericUpDownValue.Name = "numericUpDownValue";
			this.numericUpDownValue.Size = new System.Drawing.Size(200, 53);
			this.numericUpDownValue.TabIndex = 1;
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
			this.comboBoxKnobType.Location = new System.Drawing.Point(240, 211);
			this.comboBoxKnobType.Name = "comboBoxKnobType";
			this.comboBoxKnobType.Size = new System.Drawing.Size(200, 53);
			this.comboBoxKnobType.TabIndex = 2;
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
			this.comboBoxCapStyle.Location = new System.Drawing.Point(240, 124);
			this.comboBoxCapStyle.Name = "comboBoxCapStyle";
			this.comboBoxCapStyle.Size = new System.Drawing.Size(200, 53);
			this.comboBoxCapStyle.TabIndex = 3;
			this.comboBoxCapStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxCapStyle_SelectedIndexChanged);
			// 
			// Features
			// 
			this.Controls.Add(this.comboBoxCapStyle);
			this.Controls.Add(this.comboBoxKnobType);
			this.Controls.Add(this.numericUpDownValue);
			this.Controls.Add(this.knob1);
			this.Name = "Features";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Ext.jQueryKnob.Knob knob1;
		private Web.NumericUpDown numericUpDownValue;
		private Web.ComboBox comboBoxKnobType;
		private Web.ComboBox comboBoxCapStyle;
	}
}
