using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igPieChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igPieChart()
		{
			InitializeComponent();

			this.igPieChart1.Instance.onSliceClick += new WidgetEventHandler(igPieChart_WidgetEvent);
			this.igPieChart1.Instance.onLabelClick += new WidgetEventHandler(igPieChart_WidgetEvent);
		}

		private void igPieChart_Load(object sender, EventArgs e)
		{
			this.igPieChart1.Options.dataSource = new dynamic[]{new {budget = 60, label="Administration", },
				new {budget = 40, label="Sales", },
				new {budget = 60, label="IT", },
				new {budget = 40, label="Marketing", },
				new {budget = 60, label="Development", },
				new {budget = 20, label="Support", },
			};
			this.igPieChart1.Options.valueMemberPath = "budget";
			this.igPieChart1.Options.labelMemberPath = "label";
			this.igPieChart1.Options.radiusFactor = 0.6;
			this.igPieChart1.Options.labelsPosition = "outsideEnd";
			this.igPieChart1.Options.leaderLineType = "arc";
			this.igPieChart1.Options.labelExtent = 40;
			this.igPieChart1.Options.explodedSlices = new int[] { 2, 3 };
		}

		private void igPieChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.igPieChart1.Instance.addItem(new {
				label = this.textBox1.Text,
				budget = this.numericUpDown1.Value
			});

			this.igPieChart1.Update();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igPieChart1.Options.allowSliceExplosion = this.checkBox1.Checked;
			this.igPieChart1.Options.allowSliceSelection = this.checkBox2.Checked;
			this.igPieChart1.Options.selectionMode = this.comboBox1.SelectedItem;

			this.igPieChart1.Update();
		}


	}
}
