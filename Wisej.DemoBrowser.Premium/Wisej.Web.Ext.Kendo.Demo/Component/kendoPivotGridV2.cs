using System;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoPivotGridV2 : TestBase
	{
		public kendoPivotGridV2()
		{
			InitializeComponent();
		}

		private void kendoPivotGridV2_Load(object sender, EventArgs e)
		{
			this.kendoPivotGridV21.Options.columnWidth = 120;
			this.kendoPivotGridV21.Options.dataSource = new
			{
				type = "xmla",
				columns = new dynamic[]
				{
					new
					{
						name = new []{"[Date].[Calendar]"},
						expand = true
					},
					new
					{
						name = new []{"[Product].[Category]"},
					}
				},
				rows = new[]
				{
					new
					{
						name = new []{"[Geography].[City]"},
						expand = true
					}
				},
				measures = new[]
				{
					new
					{
						name = new []{"[Measures].[Reseller Freight Cost]"},
					}
				},
				transport = new
				{
					connection = new
					{
						catalog = "Adventure Works DW 2008R2",
						cube = "Adventure Works"
					},
					read = "https://demos.telerik.com/olap/msmdpump.dll"
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoPivotGridV21.Options.columnWidth = this.numericUpDownColumnWidth.Value;

			this.kendoPivotGridV21.Update();
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			this.kendoPivotGridV21.Instance.saveAsPDF();
		}
	}
}
