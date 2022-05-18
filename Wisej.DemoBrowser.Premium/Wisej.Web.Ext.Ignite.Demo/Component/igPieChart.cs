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

		private void igPieChart_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{

			// Doesn't work because Names are in quotes
			this.igPieChart1.Instance.addItem(new {
				Label = this.textBox1.Text,
				Budget = this.numericUpDown1.Value
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
