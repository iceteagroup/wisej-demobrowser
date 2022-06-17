using System;
using System.Collections.Generic;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTreeList : TestBase
	{
		public kendoTreeList()
		{
			InitializeComponent();

			this.kendoTreeList1.Instance.onChange += new WidgetEventHandler(kendoTreeList1_WidgetEvent);
		}

		private void kendoTreeList_Load(object sender, EventArgs e)
		{
			this.kendoTreeList1.Options.resizable = this.checkBoxResizable.Checked;
			this.kendoTreeList1.Options.columnMenu = this.checkBoxColumnMenu.Checked;
			this.kendoTreeList1.Options.editable = this.comboBoxEditMode.SelectedItem;

			SetTreeListColumns();

			this.kendoTreeList1.Options.dataSource = new
			{
				data = LoadEmployees(),
				schema = new
				{
					model = new
					{
						id = "EmployeeID",
						parentId = "ReportsTo",
						fields = new
						{
							ReportsTo = new
							{
								field = "ReportsTo",
								nullable = true
							},
							EmployeeID = new
							{
								field = "EmployeeId",
								type = "number"
							},
							Extension = new
							{
								field = "Extension",
								type = "number"
							}
						},
						expanded = true
					}
				}
			};
		}

		private void kendoTreeList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private DynamicObject[] LoadEmployees()
		{
			using (var reader = new StreamReader(Application.MapPath("Data/TreeList/Employees.json")))
			{
				DynamicObject[] employees = JSON.Parse(reader.BaseStream).employees;

				return employees;
			}
		}

		private void SetTreeListColumns()
		{
			var columns = new object[]
			{
				new
				{
					field = "FirstName",
					title = "First Name",
					width = 280, template = "()=>getPhotoTemplate()",
					filterable = this.checkBoxFiltrable.Checked
				},
				new
				{
					field = "LastName",
					title = "Last Name",
					width = 160,
					filterable = this.checkBoxFiltrable.Checked
				},
				new
				{
					field = "Position",
					filterable = this.checkBoxFiltrable.Checked
				},
				new
				{
					field = "Phone",
					width = 200,
					filterable = this.checkBoxFiltrable.Checked
				},
				new
				{
					field = "Extension",
					width = 140,
					filterable = this.checkBoxFiltrable.Checked
				},
				new
				{
					field = "Address",
					filterable = this.checkBoxFiltrable.Checked
				},
				new
				{
					title = "Edit",
					command = new object[]
					{
						"edit"
					},
					width = 140,
					filterable = this.checkBoxFiltrable.Checked
				}
			};

			this.kendoTreeList1.Options.columns = columns;
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoTreeList1.Options.resizable = this.checkBoxResizable.Checked;
			this.kendoTreeList1.Options.columnMenu = this.checkBoxColumnMenu.Checked;
			this.kendoTreeList1.Options.editable = this.comboBoxEditMode.SelectedItem;

			SetTreeListColumns();

			this.kendoTreeList1.Update();
		}
	}
}