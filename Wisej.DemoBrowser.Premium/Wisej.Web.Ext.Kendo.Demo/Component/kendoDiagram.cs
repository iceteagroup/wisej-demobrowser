using System;
using System.IO;
using System.Net;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoDiagram : TestBase
	{
		public kendoDiagram()
		{
			InitializeComponent();

			kendoDiagram1.Instance.onClick += new WidgetEventHandler(kendoDiagram1_WidgetEvent);
		}

		private void kendoDiagram_Load(object sender, EventArgs e)
		{
			this.kendoDiagram1.Options.dataSource = new dynamic[]
			{
				new
				{
					firstName = "Antonio", lastName = "Moreno", image = "antonio.jpg", title = "Team Lead",
					colorScheme = "#1696d3", items = new dynamic[]
					{
						new
						{
							firstName = "Elizabeth", image = "elizabeth.jpg", lastName = "Brown", title = "Design Lead",
							colorScheme = "#ef6944", items = new dynamic[]
							{
								new
								{
									firstName = "Ann", lastName = "Devon", image = "ann.jpg", title = "UI Designer",
									colorScheme = "#ef6944"
								}
							}
						},
						new
						{
							firstName = "Diego", lastName = "Roel", image = "diego.jpg", title = "QA Engineer",
							colorScheme = "#ee587b", items = new dynamic[]
							{
								new
								{
									firstName = "Fran", lastName = "Wilson", image = "fran.jpg", title = "QA Intern",
									colorScheme = "#ee587b"
								}
							}
						},
						new
						{
							firstName = "Felipe", lastName = "Izquiedro", image = "felipe.jpg",
							title = "Senior Developer", colorScheme = "#75be16", items = new dynamic[]
							{
								new
								{
									firstName = "Daniel", lastName = "Tonini", image = "daniel.jpg",
									title = "Developer", colorScheme = "#75be16"
								}
							}
						}
					}
				}
			};

			this.kendoDiagram1.Options.layour = new
			{
				type = "layered"
			};
			this.kendoDiagram1.Options.shapeDefaults = new
			{
				visual = "visualTemplate"
			};
			this.kendoDiagram1.Options.connectionDefaults = new
			{
				stroke = new
				{
					color = "#979797",
					width = 2
				}
			};
		}

		private void kendoDiagram1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			var format = comboBox1.SelectedItem.ToString();

			switch (format)
			{
				case "PDF":
					break;

				case "SVG":
					break;

				case "PNG":
					break;
			}
		}

		private void kendoDiagram1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					ExportDocument(e.Request.Form["base64"], e.Request.Form["fileName"]);
					break;
			}

			e.Response.StatusCode = (int) HttpStatusCode.NotModified;
		}

		private void ExportDocument(string base64, string fileName)
		{
			AlertBox.Show($"Received the file {fileName} on the server.");

			var bytes = Convert.FromBase64String(base64);

			using (var ms = new MemoryStream(bytes))
			{
				Application.Download(ms, fileName);
			}
		}
	}
}