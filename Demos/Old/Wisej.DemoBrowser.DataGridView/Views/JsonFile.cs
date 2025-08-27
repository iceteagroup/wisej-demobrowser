using System;
using System.Collections.Generic;
using System.ComponentModel;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.DataGridView.Views
{
	[Description("Wisej offers an easy and convinient to parse json data and bind it to controls such as a DataGridView")]
	[CustomName("Json File")]
	[AddToTreeView(true)]
	[ImageSource("resource.wx/Wisej.Ext.VisualStudioIcons/JSONScript.svg")]
	public partial class JsonFile : Common.Views.DemoView
	{
		private const string ROOT_NAMESPACE = "Wisej.DemoBrowser.DataGridView";
		
		public JsonFile()
		{
			InitializeComponent();
		}

		private void JsonFile_Load(object sender, EventArgs e)
		{
			using (var stream = this.GetType().Assembly.GetManifestResourceStream($"{ROOT_NAMESPACE}.Data.jsonData.json"))
			{
				var data = JSON.Parse(stream);
				this.dataGridView1.DataSource = new List<dynamic>(data);
			}
		}
	}
}
