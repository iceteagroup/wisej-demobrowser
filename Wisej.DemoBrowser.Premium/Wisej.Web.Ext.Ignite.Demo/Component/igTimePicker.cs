using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igTimePicker : TestBase
	{
		public igTimePicker()
		{
			InitializeComponent();

			this.igTimePicker1.Instance.onValueChanged += new WidgetEventHandler(igTimePicker_WidgetEvent);
		}

		private void igTimePicker_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igTimePicker1.Options.readOnly = this.checkBox2.Checked;
			this.igTimePicker1.Options.buttonType = this.comboBox1.SelectedItem;
			this.igTimePicker1.Options.preventSubmitOnEnter = this.checkBox3.Checked;
			this.igTimePicker1.Options.isLimitedToListValues = this.checkBox1.Checked;

			this.igTimePicker1.Update();
		}
	}
}
