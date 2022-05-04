using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TextBox
{
	public partial class AutoComplete : DemoView
	{
		public AutoComplete()
		{
			InitializeComponent();
		}

		private void AutoComplete_Load(object sender, EventArgs e)
		{
			this.comboBoxAutoCompleteMode.Items.AddRange(Enum.GetNames(typeof(Web.AutoComplete)));
		}

		private void comboBoxAutoCompleteMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			var text = (string)this.comboBoxAutoCompleteMode.SelectedItem;
			var mode = (Web.AutoComplete)Enum.Parse(typeof(Web.AutoComplete), text);

			this.textBoxAutoCompleteMode.LabelText = text;
			this.textBoxAutoCompleteMode.AutoComplete = mode;
		}
    }
}
