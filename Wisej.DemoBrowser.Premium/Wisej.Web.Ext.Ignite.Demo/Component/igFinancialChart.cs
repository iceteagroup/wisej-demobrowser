using System;
using System.IO;
using System.Threading;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igFinancialChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igFinancialChart()
		{
			InitializeComponent();

			this.igFinancialChart1.Instance.onSeriesPointerUp += new WidgetEventHandler(igFinancialChart_WidgetEvent);
		}

		private void igFinancialChart_Load(object sender, EventArgs e)
		{
			this.igFinancialChart1.Options.dataSource = JSON.Parse(File.ReadAllText(Application.MapPath("Data/FinancialChart/data.json")));
		}

		private void igFinancialChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igFinancialChart1.Options.chartType = this.comboBox1.SelectedItem;
			this.igFinancialChart1.Options.trendLineType = this.comboBox2.SelectedItem;
			this.igFinancialChart1.Options.animateSeriesWhenAxisRangeChanges = this.checkBox1.Checked;
			this.igFinancialChart1.Options.crosshairsSnapToDate = this.checkBox2.Checked;
			this.igFinancialChart1.Options.isToolbarVisible = this.checkBox3.Checked;

			this.igFinancialChart1.Update();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igFinancialChart1.Instance.addItem(GenerateItem());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Start a new task?", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}

			taskCount++;
			this.button2.Text = $"Start Task ({taskCount})";

			Application.StartTask(() => {

				var rand = new Random();

				for (var i = 0; i < 10; i++)
				{
					this.igFinancialChart1.Instance.addItem(GenerateItem());
					Application.Update(this);
					Thread.Sleep(500);
				}

				taskCount--;
				this.button2.Text = $"Start Task ({taskCount})";
				Application.Update(this);
			});
		}
		private int taskCount;

		private object GenerateItem()
		{
			Random r = new Random();

			return new
			{
				time = "2013-02-04T05:00:00.000Z",
				open = r.Next(1400, 1600),
				high = r.Next(1400, 1600),
				low = r.Next(1400, 1600),
				close = r.Next(1400, 1600),
				volume = 3723793
			};
		}
	}
}
