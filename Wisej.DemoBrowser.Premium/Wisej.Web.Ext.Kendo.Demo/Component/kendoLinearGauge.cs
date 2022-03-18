using System;
using System.Threading;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoLinearGauge : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoLinearGauge()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoLinearGauge1.Options.transitions = this.checkBox1.Checked;
			this.kendoLinearGauge1.Instance.value(this.numericUpDown1.Value);

			this.kendoLinearGauge1.Update();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Start a new task?", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}

			taskCount++;
			this.button1.Text = $"Start Task ({taskCount})";

			Application.StartTask(() => {

				var rand = new Random();

				for (var i = 0; i < 10; i++)
				{
					this.kendoLinearGauge1.Instance.value(rand.Next(-40, 60));
					Application.Update(this);
					Thread.Sleep(1000);
				}

				taskCount--;
				this.button1.Text = $"Start Task ({taskCount})";
				Application.Update(this);
			});
		}
		private int taskCount;

	}
}
