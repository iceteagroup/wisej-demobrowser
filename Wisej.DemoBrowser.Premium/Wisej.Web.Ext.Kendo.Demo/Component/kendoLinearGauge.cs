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

		private void kendoLinearGauge_Load(object sender, EventArgs e)
		{
			this.kendoLinearGauge1.Options.pointer = new { value = 20 };

			this.kendoLinearGauge1.Options.scale = new
			{
				majorUnit = 20,
				minorUnit = 2,
				min = -40,
				max = 60,
				vertical = true,
				ranges = new[]
				{
					new
					{
						from = -40,
						to = -20,
						color = "#2798df"
					},
					new
					{
						from = 30,
						to = 40,
						color = "#ffc700"
					},
					new
					{
						from = 45,
						to = 60,
						color = "#c20000"
					},
				}
			};
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
