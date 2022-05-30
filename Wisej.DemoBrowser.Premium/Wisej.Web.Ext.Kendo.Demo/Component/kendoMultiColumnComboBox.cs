using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMultiColumnComboBox : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoMultiColumnComboBox()
		{
			InitializeComponent();

			this.kendoMultiColumnComboBox1.Instance.onSelect += new WidgetEventHandler(kendoMultiColumnComboBox1_WidgetEvent);
		}

		private void kendoMultiColumnComboBox_Load(object sender, EventArgs e)
		{
			this.kendoMultiColumnComboBox1.Options.dataTextField = "ContactName";
			this.kendoMultiColumnComboBox1.Options.dataValueField = "CustomerID";
			this.kendoMultiColumnComboBox1.Options.height = 400;
			this.kendoMultiColumnComboBox1.Options.columns = new dynamic[]
			{
				new
				{
					field = "ContactName", title = "Contact Name",
					template =
						"<div class='customer-photo'style='background-image: url(https://demos.telerik.com/kendo-ui/content/web/Customers/#:data.CustomerID#.jpg);'></div><span class='customer-name'>#: ContactName #</span>",
					width = 200
				},
				new {field = "ContactTitle", title = "Contact Title", width = 200},
				new {field = "CompanyName", title = "Company Name", width = 200},
				new {field = "Country", title = "Country", width = 200}
			};
			this.kendoMultiColumnComboBox1.Options.footerTemplate = "Total #: instance.dataSource.total() # items found";

			this.kendoMultiColumnComboBox1.Options.filterFields = new[] { "ContactName", "ContactTitle", "CompanyName", "Country" };

			this.kendoMultiColumnComboBox1.Options.filter = "contains";

			this.kendoMultiColumnComboBox1.Options.dataSource = new
			{
				type = "odata",
				transport = new
				{
					read = "https://demos.telerik.com/kendo-ui/service/Northwind.svc/Customers"
				}
			};
		}

		private void kendoMultiColumnComboBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoMultiColumnComboBox1.Options.clearButton = this.checkBox1.Checked;
			this.kendoMultiColumnComboBox1.Options.ignoreCase = this.checkBox2.Checked;
			this.kendoMultiColumnComboBox1.Options.suggest = this.checkBox3.Checked;
			this.kendoMultiColumnComboBox1.Options.syncValueAndText = this.checkBox4.Checked;
			this.kendoMultiColumnComboBox1.Instance.value(this.textBox1.Text);

			this.kendoMultiColumnComboBox1.Update();
		}
	}
}
