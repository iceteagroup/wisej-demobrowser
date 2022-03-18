using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTimePicker : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		bool isPopupShown = false;
			
		public ejTimePicker()
		{
			InitializeComponent();

			this.ejTimePicker1.Instance.open += new WidgetEventHandler(ejTimePicker1_WidgetEvent);
			this.ejTimePicker1.Instance.change += new WidgetEventHandler(ejTimePicker1_WidgetEvent);
			this.ejTimePicker1.Instance.select += new WidgetEventHandler(ejTimePicker1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTimePicker1.Options.enabled = this.checkBoxEnabled.Checked;

			this.ejTimePicker1.Update();
		}

		private async void buttonGetTime_Click(object sender, EventArgs e)
		{
			var timeVal = await this.ejTimePicker1.Instance.getValueAsync();

			AlertBox.Show(timeVal);
		}

		private void buttonShowHidePopup_Click(object sender, EventArgs e)
		{
			if (isPopupShown)
			{
				this.ejTimePicker1.Instance.hide();
				isPopupShown = false;
			} else
			{
				this.ejTimePicker1.Instance.show();
				isPopupShown = true;
			}
		}

		private void buttonTimeNow_Click(object sender, EventArgs e)
		{
			this.ejTimePicker1.Instance.setCurrentTime();
		}

		private void ejTimePicker1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
