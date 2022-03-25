using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Schedule : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public Schedule()
		{
			InitializeComponent();

			this.schedule1.Instance.onEventClick += new WidgetEventHandler(schedule1_WidgetEvent);
			this.schedule1.Instance.onPopupClose += new WidgetEventHandler(schedule1_WidgetEvent);

		}

		private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.schedule1.Options.allowInline = this.checkBoxInline.Checked;
			this.schedule1.Options.currentView = this.comboBoxCurrentView.Text;
			this.schedule1.Options.calendarMode = this.comboBoxCalendarMode.Text;
			this.schedule1.Options.allowDragAndDrop = this.checkBoxDragAndDrop.Checked;
			this.schedule1.Options.enableAdaptiveUI = this.checkBoxAdaptativeUI.Checked;

			this.schedule1.Update();
        }

		private void Schedule_Load(object sender, EventArgs e)
		{
			var text = File.ReadAllText(Application.MapPath("Data/Schedule/data.json"));
			var data = JSON.Parse(text);

			this.schedule1.Options.eventSettings.dataSource = data.scheduleData;
		}

		private void schedule1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
