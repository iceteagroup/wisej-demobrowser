using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejGantt : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejGantt()
		{
			InitializeComponent();

			this.ejGantt1.Instance.onRowSelected += new WidgetEventHandler(ejGantt1_WidgetEvent);
			this.ejGantt1.Instance.onTaskbarClick += new WidgetEventHandler(ejGantt1_WidgetEvent);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejGantt1.Options.showProgressStatus = this.checkBox1.Checked;
			this.ejGantt1.Options.allowGanttChartEditing = this.checkBox3.Checked;
			this.ejGantt1.Options.enableCollapseAll = this.checkBox4.Checked;
			this.ejGantt1.Options.highlightNonWorkingTime = this.checkBox7.Checked;
			this.ejGantt1.Options.scheduleStartDate = DateTime.Parse(this.textBox1.Text).ToString("MM/dd/yyyy");
			this.ejGantt1.Options.scheduleEndDate = DateTime.Parse(this.textBox2.Text).ToString("MM/dd/yyyy");
			this.ejGantt1.Options.viewtype = this.comboBox1.SelectedItem.ToString().ToLower();

			this.ejGantt1.Update();
		}

		private void ejGantt1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
