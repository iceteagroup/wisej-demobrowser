using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Sparkline : TestBase
	{
		public Sparkline()
		{
			InitializeComponent();
		}

		private void Sparkline_Load(object sender, EventArgs e)
		{
			this.sparkline1.Options.dataSource = new object[]
			{
				new
				{
					x = 0, xval = "2005",
					yval = 20090440
				},
				new
				{
					x = 1, xval = "2006",
					yval = 20264080
				},
				new
				{
					x = 2, xval = "2007",
					yval = 20434180
				},
				new
				{
					x = 3, xval = "2008",
					yval = 21007310
				},
				new
				{
					x = 4, xval = "2009",
					yval = 21262640
				},
				new
				{
					x = 5, xval = "2010",
					yval = 21515750
				},
				new
				{
					x = 6, xval = "2011",
					yval = 21766710
				},
				new
				{
					x = 7, xval = "2012",
					yval = 22015580
				},
				new
				{
					x = 8, xval = "2013",
					yval = 22262500
				},
				new
				{
					x = 9, xval = "2014",
					yval = 22507620
				}
			};
			this.sparkline1.Options.xName = "xval";
			this.sparkline1.Options.yName = "yval";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.sparkline1.Options.type = this.comboBox1.Text;
			this.sparkline1.Update();
		}
	}
}