using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igDateEditor : TestBase
	{
		public igDateEditor()
		{
			InitializeComponent();

			this.igDateEditor1.Instance.onValueChanged += new WidgetEventHandler(igDateEditor1_WidgetEvent);
		}

		private void igDateEditor_Load(object sender, EventArgs e)
		{
			this.igDateEditor1.Options.dateInputFormat = "dateTime";
			this.igDateEditor1.Options.value = "2020-01-01";
			this.igDateEditor1.Options.dataMode = "date";
		}
		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igDateEditor1.Options.dataMode = this.comboBoxDataMode.SelectedItem;
			this.igDateEditor1.Options.revertIfNotValid = this.checkBoxRevertIfNotValid.Checked;
			this.igDateEditor1.Options.buttonType = this.comboBoxButtonType.SelectedItem ?? "none";
			this.igDateEditor1.Options.selectionOnFocus = this.comboBoxSelectionOnFocus.SelectedItem;

			this.igDateEditor1.Update();
		}

		private async void buttonGetSelectedDate_Click(object sender, EventArgs e)
		{
			var data = await this.igDateEditor1.Instance.getSelectedDateAsync();

			AlertBox.Show(data.ToString());
		}

		private void igDateEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
