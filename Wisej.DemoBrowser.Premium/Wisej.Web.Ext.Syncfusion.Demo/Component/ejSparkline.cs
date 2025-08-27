using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejSparkline : TestBase
	{
		public ejSparkline()
		{
			InitializeComponent();

			this.ejSparkline1.Instance.onClick += new WidgetEventHandler(ejSparkline1_WidgetEvent);
		}

		private void ejSparkline_Load(object sender, EventArgs e)
		{
			this.ejSparkline1.Options.isResponsive = true;
			this.ejSparkline1.Options.dataSource = new object[]
			{
				2, 6, -1, 1, 12, 5, -2, 7, -3, 5, 8, 10
			};
			this.ejSparkline1.Options.negativePointColor = "red";
			this.ejSparkline1.Options.highPointColor = "blue";
			this.ejSparkline1.Options.tooltip = new
			{
				visible = true,
				font = new
				{
					size = "12px"
				}
			};
			this.ejSparkline1.Options.type = "column";
		}

		private void ejSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejSparkline1.Options.type = this.comboBox1.SelectedItem.ToString().ToLower();
			this.ejSparkline1.Options.markerSettings = new
			{
				visible = this.checkBox2.Checked,
				fill = "black"
			};
			this.ejSparkline1.Options.axisLineSettings = new
			{
				visible = this.checkBox3.Checked,
				color = "black"
			};

			this.ejSparkline1.Update();
		}
	}
}