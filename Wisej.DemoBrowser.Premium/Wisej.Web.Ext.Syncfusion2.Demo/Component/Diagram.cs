using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Diagram : TestBase
	{
		public Diagram()
		{
			InitializeComponent();

			this.diagram1.Instance.onClick += new WidgetEventHandler(diagram1_WidgetEvent);
		}

		private void Diagram_Load(object sender, EventArgs e)
		{
			this.diagram1.Options.nodes = new object[]
			{
				new
				{
					name = "Start",
					offsetX = 300, offsetY = 50, width = 140, height = 50, annotations = new object[]
					{
						new
						{
							id = "label1",
							content = "Start"
						}
					},
					shape = new
					{
						type = "Flow",
						shape = "Terminator"
					}
				}
			};
		}

		private void diagram1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}