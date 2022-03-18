using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igScheduler : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igScheduler()
		{
			InitializeComponent();

			this.igScheduler1.Instance.appointmentCreated += new WidgetEventHandler(igScheduler_WidgetEvent);
			this.igScheduler1.Instance.appointmentDeleted += new WidgetEventHandler(igScheduler_WidgetEvent);
			this.igScheduler1.Instance.appointmentCreating += new WidgetEventHandler(igScheduler_WidgetEvent);
			this.igScheduler1.Instance.appointmentDeleting += new WidgetEventHandler(igScheduler_WidgetEvent);
		}

		private void igScheduler1_Appear(object sender, EventArgs e)
		{
			this.igScheduler1.Call("loadData");
			this.igScheduler1.Update();
		}

		private void igScheduler_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var start = this.dateTimePicker1.Value.ToJSON(false);
			var end = this.dateTimePicker2.Value.ToJSON(false);

			var data = await this.igScheduler1.CallAsync("getAppointmentsInRange", start, end);

			using (MemoryStream ms = new MemoryStream())
			{
				var sw = new StreamWriter(ms);
				try
				{
					sw.Write(JSON.Stringify(data));
					sw.Flush();
					ms.Seek(0, SeekOrigin.Begin);

					Application.Download(ms, "myAppointments.json");
				}
				finally
				{
					sw.Dispose();
				}
			}
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igScheduler1.Options.enableTodayButton = this.checkBox1.Checked;
			this.igScheduler1.Options.viewMode = this.comboBox1.SelectedItem ?? "none";
			this.igScheduler1.Options.agendaViewSettings.dateRangeInterval = this.numericUpDown1.Value;

			this.igScheduler1.Update();
		}
	}
}
