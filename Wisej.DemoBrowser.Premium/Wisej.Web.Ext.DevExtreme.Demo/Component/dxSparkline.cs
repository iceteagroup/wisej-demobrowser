using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxSparkline : TestBase
	{
		public dxSparkline()
		{
			InitializeComponent();
		}

        private void dxSparkline1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private async void button1_Click(object sender, EventArgs e)
        {
			var result = await this.colorDialog1.ShowDialogAsync();
			if(result == DialogResult.OK)
            {
				string color = ColorTranslator.ToHtml(this.colorDialog1.Color);
				
				this.button1.Text = color;
				this.button1.BackColor = this.colorDialog1.Color;
				
				this.dxSparkline1.Options.lineColor = color;
				
				this.dxSparkline1.Update();
			}
		}

        private void dxSparkline_Load(object sender, EventArgs e)
        {
			this.dxSparkline1.Options = new
			{
				dataSource = new object[]
                {
					new Dictionary<string, int>
					{
						{ "month", 1 },
						{ "2010", 77},
						{ "2011", 93 },
						{"2012", 107 }
					},
					new Dictionary<string, int>
                    {
						{ "month", 2 },
						{ "2010", 72 },
						{ "2011", 101 },
						{ "2012", 112 }
					},
					new Dictionary<string, int>
                    {
						{"month", 3 },
						{ "2010", 79 },
						{ "2011", 115 },
						{ "2012", 123 }
					},
					new Dictionary<string, int>
                    {
						 {"month", 4 },
						{ "2010", 82 },
						{ "2011", 116 },
						{ "2012", 123 }
					},
					new Dictionary<string, int>
                    {
						{"month", 5 },
						{ "2010", 86 },
						{ "2011", 124 },
						{ "2012", 116 }
					},
					new Dictionary<string, int>
                    {
						{"month", 6 },
						{ "2010", 73 },
						{ "2011", 115 },
						{ "2012", 102 }
					},
					new Dictionary<string, int>
                    {
						{"month", 7 },
						{ "2010", 73 },
						{ "2011", 110 },
						{ "2012", 94 }
					},
					new Dictionary<string, int>
                    {
						{"month", 8 },
						{ "2010", 77 },
						{ "2011", 117 },
						{ "2012", 105 }
					},
					new Dictionary<string, int>
                    {
						 {"month", 9 },
						{ "2010", 76 },
						{ "2011", 113 },
						{ "2012", 113 }
					},
					new Dictionary<string, int>
                    {
						 {"month", 10 },
						{ "2010", 81 },
						{ "2011", 103 },
						{ "2012", 111 }
					},
					new Dictionary<string, int>
                    {
						 {"month", 11 },
						{ "2010", 83 },
						{ "2011", 110 },
						{ "2012", 107 }
					},
					new Dictionary<string, int>
                    {
						{"month", 12 },
						{ "2010", 89 },
						{ "2011", 109 },
						{ "2012", 110 }
					}
                },
				pointSymbol = "circle",
				argumentField = "month",
				valueField = "2010",
				type = "line",
				showMinMax = true,
				tooltip = new
                {
					format = "currency"
				}
			};

			this.dxSparkline1.Update();
        }
    }
}
