using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Scheduler : ViewBase
	{
		public Scheduler()
		{
			InitializeComponent();
		}

		private void Scheduler_Load(object sender, EventArgs e)
		{
			this.scheduler1.Options = new
			{
				date = "2020-08-31T20:00:00.001",
				url = "https://docs.webix.com/calendar-backend/"
			};
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.scheduler1.Options.mode = this.comboBoxMode.SelectedItem;
			this.scheduler1.Options.timeline = this.checkBoxAllowTimeline.Checked;
			this.scheduler1.Options.timelineMode = this.comboBoxTimelineMode.SelectedText;

			this.scheduler1.Update();
        }
    }
}