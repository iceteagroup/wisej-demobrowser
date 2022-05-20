using System;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxCalendar : TestBase
	{
		public dxCalendar()
		{
			InitializeComponent();

			this.dxCalendar1.Instance.onValueChanged += new WidgetEventHandler(dxCalendar1_WidgetEvent);
		}

		private void dxCalendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxCalendar1.Options.activeStateEnabled = this.checkBox1.Checked;
			this.dxCalendar1.Options.showTodayButton = this.checkBox2.Checked;
			this.dxCalendar1.Options.focusStateEnabled = this.checkBox3.Checked;
			this.dxCalendar1.Options.hoverStateEnabled = this.checkBox4.Checked;
			this.dxCalendar1.Options.firstDayOfWeek = this.comboBox1.SelectedIndex;
			this.dxCalendar1.Options.zoomLevel = this.comboBox2.SelectedItem;

			this.dxCalendar1.Update();
		}

        private void dxCalendar_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;

			this.dxCalendar1.Options = new
			{
				value = "2020-01-01",
				zoomLevel = "century",
				firstDayOfWeek = 0,
				activeStateEnabled = false
			};

			this.dxCalendar1.Update();
        }
    }
}
