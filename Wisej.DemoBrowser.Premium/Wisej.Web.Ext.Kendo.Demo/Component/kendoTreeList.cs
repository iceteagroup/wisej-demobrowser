using System;
using System.Collections.Generic;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoTreeList : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoTreeList()
		{
			InitializeComponent();

			this.kendoTreeList1.Instance.onChange += new WidgetEventHandler(kendoTreeList1_WidgetEvent);
		}

		private void kendoTreeList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void kendoTreeList_Load(object sender, EventArgs e)
		{
			this.comboBoxEditMode.SelectedIndex = 0;

			this.kendoTreeList1.Options.dataSource = new
			{
				data = LoadEmployees(),
				schema = new
				{
					model = new
					{
						id = "EmployeeID",
						parentId = "ReportsTo",
						fields = new {
							ReportsTo = new {
								field = "ReportsTo",
								nullable = true
							},
							EmployeeID = new {
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

		private DynamicObject[] LoadEmployees()
		{
			using (StreamReader reader = new StreamReader(Application.MapPath("Data/TreeList/Employees.json")))
			{
				DynamicObject[] employees = JSON.Parse(reader.BaseStream).employees;

				return employees;
			}
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.kendoTreeList1.Options.columnMenu = this.checkBoxColumnMenu.Checked;
			
			if (string.Equals(this.comboBoxEditMode.SelectedText, "none"))
				this.kendoTreeList1.Options.editable = false;
			else
				this.kendoTreeList1.Options.editable = this.comboBoxEditMode.SelectedText;
			
			for (int i = 0; i < ((dynamic[])this.kendoTreeList1.Options.columns).Length; i++)
				this.kendoTreeList1.Options.columns[i].filterable = this.checkBoxFiltrable.Checked;
			
			this.kendoTreeList1.Update();
        }
    }
}
