using System;
using System.ComponentModel;
using Wisej.Core;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igMap : Wisej.Web.Ext.Ignite.Demo.Component.TestBase
	{
		public igMap()
		{
			InitializeComponent();

			this.igMap1.Instance.onSeriesMouseLeftButtonUp += new WidgetEventHandler(igMap_WidgetEvent);
		}

		private void igMap_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var item = new
			{
				Latitude = this.numericUpDown1.Value,
				Longitude = this.numericUpDown2.Value,
				Name = textBox1.Text,
				Country = textBox2.Text
			};

			this.igMap1.Instance.insertItem(item, 0, "worldCities");
		}
	}
}
