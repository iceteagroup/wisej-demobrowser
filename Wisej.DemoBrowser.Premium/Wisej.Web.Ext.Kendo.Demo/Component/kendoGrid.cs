using System;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Web;
using Wisej.Core;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoGrid : TestBase
	{
		public kendoGrid()
		{
			InitializeComponent();

			this.kendoGrid1.Instance.onEdit += new WidgetEventHandler(kendoGrid1_WidgetEvent);
			this.kendoGrid1.Instance.onNavigate += new WidgetEventHandler(kendoGrid1_WidgetEvent);
			this.kendoGrid1.Instance.onDataBound += new WidgetEventHandler(kendoGrid1_DataBound);		}

		private void kendoGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void kendoGrid1_DataBound(object sender, WidgetEventArgs e)
		{
			this.kendoGrid1.Call("onDataBound");
		}

		private void buttonPDF_Click(object sender, EventArgs e)
		{
			this.kendoGrid1.Instance.saveAsPDF();
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			this.kendoGrid1.Instance.saveAsExcel();
		}

		private void kendoGrid1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request.QueryString["action"])
			{
				case "export":
					// prepare for download.
					this.ExportDocument(e.Request.Form["base64"], e.Request.Form["fileName"], e.Response);
					break;
			}
		}

		private void ExportDocument(string base64Data, string fileName, HttpResponse response)
		{
			var bytes = Convert.FromBase64String(base64Data);
			response.AddHeader("Content-Disposition", $"attachment; filename={fileName}");
			response.OutputStream.Write(bytes, 0, bytes.Length);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoGrid1.Options.allowCopy = this.checkBox1.Checked;
			this.kendoGrid1.Options.mobile = this.checkBox2.Checked;
			this.kendoGrid1.Options.navigatable = this.checkBox3.Checked;
			this.kendoGrid1.Options.persistSelection = this.checkBox4.Checked;

			this.kendoGrid1.Update();
		}

		private void kendoGrid_Load(object sender, EventArgs e)
		{
			this.kendoGrid1.Options.dataSource = new { 
				data = LoadProducts(),
				pageSize = 20,
				aggregate = new[] {
					new {
						field = "TotalSales",
						aggregate = "sum"
					}
				},
				group = new {
					field = "Category.CategoryName",
					dir = "desc",
					aggregates = new[] {
						new {
							field = "TotalSales",
							aggregate = "sum"
						}
					}
				},
				schema = new { 
					model = new {
						id = "ProductID",
						fields = new {
							ProductID = new { 
								editable = false,
								nullable = true
							},
							Discontinued = new {
								type = "boolean",
								editable = false,
							},
							TotalSales = new {
								type = "number",
								editable = false
							},
							TargetSales = new {
								type = "number",
								editable = false
							},
							LastSupply = new {
								type = "date"
							},
							UnitPrice = new {
								type = "number"
							},
							UnitsInStock = new {
								type = "number"
							},
							Category = new {
								defaultValue = new {
									CategoryID = 8,
									CategoryName = "Seafood"
								}
							},
							Country = new {
								defaultValue = new {
									CountryNameLong = "Bulgaria",
									CountryNameShort = "bg"
								}
							}
						}
					}
				}
			};
		}

		private DynamicObject[] LoadProducts()
		{
			using (StreamReader reader = new StreamReader(Application.MapPath("Data/Grid/ProductDetails.json"), detectEncodingFromByteOrderMarks: true))
			{
				var data = JSON.Parse(reader.BaseStream).products;

				return data;
			}
		}
	}
}
