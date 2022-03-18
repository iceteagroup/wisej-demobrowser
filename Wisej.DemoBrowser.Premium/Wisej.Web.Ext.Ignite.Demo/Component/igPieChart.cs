using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igPieChart : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igPieChart()
		{
			InitializeComponent();

			this.igPieChart1.Instance.sliceClick += new WidgetEventHandler(igPieChart_WidgetEvent);
			this.igPieChart1.Instance.labelClick += new WidgetEventHandler(igPieChart_WidgetEvent);
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

			// Works
			//this.igPieChart1.Call("AddItem");
	}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igPieChart1.Options.allowSliceExplosion = this.checkBox1.Checked;
			this.igPieChart1.Options.allowSliceSelection = this.checkBox2.Checked;
			this.igPieChart1.Options.explodedRadius = this.numericUpDown2.Value;
			this.igPieChart1.Options.selectionMode = this.comboBox1.SelectedItem;

			this.igPieChart1.Update();
		}
	}
}
