using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class QueryBuilder : TestBase
	{
		public QueryBuilder()
		{
			InitializeComponent();
		}

		private void QueryBuilder_Load(object sender, EventArgs e)
		{
			this.queryBuilder1.Options.dataSource = new object[]
			{
				new
				{
					TaskID = 1, Name = "Lenovo Yoga",
					Category = "Laptop",
					SerialNo = "CB27932009",
					InvoiceNo = "INV-2878",
					Status = "Assigned"
				},
				new
				{
					TaskID = 2, Name = "Acer Aspire",
					Category = "Others",
					SerialNo = "CB35728290",
					InvoiceNo = "INV-3456",
					Status = "In-repair"
				},
				new
				{
					TaskID = 3, Name = "Apple MacBook",
					Category = "Laptop",
					SerialNo = "CB35628728",
					InvoiceNo = "INV-2763",
					Status = "In-repair"
				}
			};
			this.queryBuilder1.Options.columns = new object[]
			{
				new
				{
					field = "TaskID",
					label = "Task ID",
					type = "number"
				},
				new
				{
					field = "Name",
					label = "Name",
					type = "string"
				},
				new
				{
					field = "Category",
					label = "Category",
					type = "string"
				},
				new
				{
					field = "SerialNo",
					label = "Serial No",
					type = "string"
				},
				new
				{
					field = "InvoiceNo",
					label = "Invoice No",
					type = "string"
				},
				new
				{
					field = "Status",
					label = "Status",
					type = "string"
				}
			};
			this.queryBuilder1.Options.rule = new
			{
				condition = "or",
				rules = new object[]
				{
					new
					{
						label = "Category",
						field = "Category",
						type = "string",
						@operator = "equal",
						value = "Laptop"
					},
					new
					{
						condition = "and",
						rules = new object[]
						{
							new
							{
								label = "Status",
								field = "Status",
								type = "string",
								@operator = "notequal",
								value = "Pending"
							},
							new
							{
								label = "Task ID",
								field = "TaskID",
								type = "number",
								@operator = "equal",
								value = 5675
							}
						}
					}
				}
			};
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.queryBuilder1.Instance.getSqlFromRules(new Action<dynamic>((r) => { AlertBox.Show(r); }));
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.queryBuilder1.Update();
		}
	}
}