using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.jQueryKnob;

namespace Wisej.DemoBrowser.jQueryKnob
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void numericUpDownValue_ValueChanged(object sender, EventArgs e)
		{
			this.knob1.Value = (int)this.numericUpDownValue.Value;
		}

		private void comboBoxKnobType_SelectedIndexChanged(object sender, EventArgs e)
		{
			var type = (string)comboBoxKnobType.SelectedItem;
			this.knob1.KnobType = (KnobType)Enum.Parse(typeof(KnobType), type);
		}

		private void comboBoxCapStyle_SelectedIndexChanged(object sender, EventArgs e)
		{
			var cap = (string)this.comboBoxCapStyle.SelectedItem;
			this.knob1.LineCapStyle = (LineCapType)Enum.Parse(typeof(LineCapType), cap);
		}
	}
}
