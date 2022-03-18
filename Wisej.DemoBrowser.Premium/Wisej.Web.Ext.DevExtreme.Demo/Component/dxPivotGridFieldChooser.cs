using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxPivotGridFieldChooser : TestBase
	{
		public dxPivotGridFieldChooser()
		{
			InitializeComponent();
		}

		private void dxPivotGridFieldChooser_Load(object sender, EventArgs e)
		{
			using (var stream = new StreamReader(Application.MapPath("Data\\PivotGrid\\sales.json")))
			{
				var json = stream.ReadToEnd();
				
				// Load the json into the pivotGrid & pivotGridDataFieldChooser datasource
			}
			
		}

		private void dxPivotGridFieldChooser1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
