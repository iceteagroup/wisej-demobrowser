using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejRecurrenceEditor : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejRecurrenceEditor()
		{
			InitializeComponent();

			this.ejRecurrenceEditor1.Instance.onChange += new WidgetEventHandler(ejRecurrenceEditor1_WidgetEvent);
		}

		private void ejRecurrenceEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonGenerateRule_Click(object sender, EventArgs e)
		{
			var rule = await this.ejRecurrenceEditor1.Instance.getRecurrenceRuleAsync();

			AlertBox.Show(rule);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejRecurrenceEditor1.Options.enableSpinners = this.checkBox1.Checked;
			this.ejRecurrenceEditor1.Options.maxDate = this.dateTimePicker1.ToString();
			this.ejRecurrenceEditor1.Options.minDate = this.dateTimePicker2.ToString();
			this.ejRecurrenceEditor1.Options.selectedRecurrenceType = this.numericUpDown1.Value;

			this.ejRecurrenceEditor1.Update();
		}
	}
}
