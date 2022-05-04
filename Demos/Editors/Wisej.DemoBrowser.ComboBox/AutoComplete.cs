using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ComboBox
{
	public partial class AutoComplete : DemoView
	{
		public AutoComplete()
		{
			InitializeComponent();
		}

		private void AutoComplete_Load(object sender, EventArgs e)
		{
			this.comboBoxAutoCompleteMode.Items.AddRange(Enum.GetNames(typeof(AutoCompleteMode)));
		}

		private void comboBoxAutoCompleteMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			var text = (string)this.comboBoxAutoCompleteMode.SelectedItem;
			var mode = (AutoCompleteMode) Enum.Parse(typeof(AutoCompleteMode), text);
			this.comboBox1.AutoCompleteMode = mode;
		}

        private void comboBoxDropDownStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
			var text = (string)this.comboBoxDropDownStyle.SelectedItem;
			var style = (ComboBoxStyle)Enum.Parse(typeof(ComboBoxStyle), text);
			this.comboBox1.DropDownStyle = style;
		}
    }
}
