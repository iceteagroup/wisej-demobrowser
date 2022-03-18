using System;
using System.Threading;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoRadialGauge : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoRadialGauge()
		{
			InitializeComponent();
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
					this.kendoRadialGauge1.Instance.value(rand.Next(0, 180));
					Application.Update(this);
					Thread.Sleep(1000);
				}

				taskCount--;
				this.button1.Text = $"Start Task ({taskCount})";
				Application.Update(this);
			});
		}
		private int taskCount;

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoRadialGauge1.Options.transitions = this.checkBox1.Checked;
			this.kendoRadialGauge1.Instance.value(this.numericUpDown1.Value);

			this.kendoRadialGauge1.Update();
		}
	}
}
