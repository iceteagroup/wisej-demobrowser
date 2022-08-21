using System;
using System.IO;
using Wisej.Web;
using System.Text.RegularExpressions;

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
					
					id = "Start",
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
				},
				new
				{
					id = "End",
					name = "End",
					offsetX = 300, offsetY = 250, width = 140, height = 50, annotations = new object[]
					{
						new
						{
							id = "label1",
							content = "End"
						}
					},
					shape = new
					{
						type = "Flow",
						shape = "Terminator"
					}
				}
			};

			this.diagram1.Options.connectors = new object[]
			{
				new
                {
					id = "connector_1",
					sourceID = "Start",
					targetID = "End"
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


        private async void buttonExportToPNG_Click(object sender, EventArgs e)
        {
			var data = await this.diagram1.Instance.exportDiagramAsync(new
			{
				mode = "Download",
			});

			string fileBase64 = ((string)data).Replace("data:image/png;base64,", ""); // ((string)data).Split(new [] {"xx"});
			using (MemoryStream file = new MemoryStream(Convert.FromBase64String(fileBase64)))
			{
				Application.Download(file, "ExportFile.png", (image) =>
				{
					AlertBox.Show("File downloaded");
				});

			}
		}

        private async void buttonChangeLineColor_Click(object sender, EventArgs e)
        {
			var result = await this.colorDialog1.ShowDialogAsync();

			if(result == DialogResult.OK)
            {
				string color = $"#{this.colorDialog1.Color.R.ToString("X2")}{this.colorDialog1.Color.G.ToString("X2")}{this.colorDialog1.Color.B.ToString("X2")}";

				this.diagram1.Options.snapSettings = new
				{
					horizontalGridlines = new
                    {
						// Sets the line color of gridlines
						lineColor = color,
						// Defines the lineDashArray of gridlines
						lineDashArray = "2 2"
					},
					verticalGridlines = new
					{
						// Sets the line color of gridlines
						lineColor = color,
						// Defines the lineDashArray of gridlines
						lineDashArray = "2 2"
					}
				};

			}
        }
    }
}