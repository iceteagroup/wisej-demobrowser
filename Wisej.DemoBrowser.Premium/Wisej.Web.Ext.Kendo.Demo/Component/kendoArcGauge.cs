using System;
using System.Threading;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoArcGauge : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoArcGauge()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			kendoArcGauge1.Options.color = textBox1.Text;
			kendoArcGauge1.Instance.value(numericUpDown1.Value);
			kendoArcGauge1.Options.opacity = numericUpDown2.Value;
			kendoArcGauge1.Options.transitions = checkBox1.Checked;

			kendoArcGauge1.Update();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Start a new task?", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}

			taskCount++;
			button1.Text = $"Start Task ({taskCount})";

			Application.StartTask(() =>
			{

				var rand = new Random();

				for (var i = 0; i < 10; i++)
				{
					kendoArcGauge1.Instance.value(rand.Next(0, 100));
					Application.Update(this);
					Thread.Sleep(1000);
				}

				taskCount--;
				button1.Text = $"Start Task ({taskCount})";
				Application.Update(this);
			});
		}
		private int taskCount;

	}
}
