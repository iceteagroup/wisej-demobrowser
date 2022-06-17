using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTimePicker : TestBase
	{
		private bool isPopupShown = false;

		public ejTimePicker()
		{
			InitializeComponent();

			this.ejTimePicker1.Instance.onOpen += new WidgetEventHandler(ejTimePicker1_WidgetEvent);
			this.ejTimePicker1.Instance.onChange += new WidgetEventHandler(ejTimePicker1_WidgetEvent);
			this.ejTimePicker1.Instance.onSelect += new WidgetEventHandler(ejTimePicker1_WidgetEvent);
		}

		private void ejTimePicker_Load(object sender, EventArgs e)
		{
			this.ejTimePicker1.Options.value = "ejTimePicker1";
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
			if (this.isPopupShown)
			{
				this.ejTimePicker1.Instance.hide();
				this.isPopupShown = false;
			}
			else
			{
				this.ejTimePicker1.Instance.show();
				this.isPopupShown = true;
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