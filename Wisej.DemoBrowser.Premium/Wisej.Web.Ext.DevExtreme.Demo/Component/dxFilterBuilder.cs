using System;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxFilterBuilder : TestBase
	{
		private readonly string[] _allOperators = new string[] { "and", "or", "notAnd", "notOr" };
		public dxFilterBuilder()
		{
			InitializeComponent();

			this.dxFilterBuilder1.Instance.onEditorPrepared += new WidgetEventHandler(dxFilterBuilder1_WidgetEvent);
		}

		private void dxFilterBuilder1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.tagTextBoxGroupOperation.Text))
            {
				var operators = this.tagTextBoxGroupOperation.Text.Split(',');

				if(_allOperators.Intersect(operators).Count() == operators.Count())
					this.dxFilterBuilder1.Options.groupOperations = operators;
				else
                {
					AlertBox.Show("Accepted Values: 'and' | 'or' | 'notAnd' | 'notOr' more details in doc", MessageBoxIcon.Error);

					Application.Play(MessageBoxIcon.Error);
				}
			}

			this.dxFilterBuilder1.Update();
        }

        private async void buttonGetFilterExpression_Click(object sender, EventArgs e)
        {
			var filterExpression = await this.dxFilterBuilder1.Instance.getFilterExpressionAsync();
			AlertBox.Show($"{JSON.Stringify(filterExpression)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void dxFilterBuilder_Load(object sender, EventArgs e)
        {
			dynamic data = 
			this.dxFilterBuilder1.Options = new
			{
				fields = new object[]
                {
					new
                    {
						caption = "ID",
						width = 50,
						dataField = "Product_ID",
						dataType = "number"
                    },
                    new
                    {
						dataField = "Product_Name",
						dataType = "string"
                    },
                    new
                    {
						caption = "Cost",
						dataField = "Product_Cost",
						dataType = "number",
						format = "currency"
                    },
					new
					{
						caption = "Sale Price",
						dataField = "Product_Sale_Price",
						dataType = "number",
						format = "currency"
					},
					new
					{
						caption = "Retail Price",
						dataField = "Product_Retail_Price",
						dataType = "number",
						format = "currency"
					},
					new
					{
						caption = "Inventory",
						dataField = "Product_Current_Inventory",
						dataType = "number",
					},
					
				},
				value = new object[]
				{
					new object[]{ "Product_Current_Inventory", "<>", 0 },
					"or",
					new object[]{ 
						new object[]{ "Product_Name", "contains", "HD" },
						"and",
						new object[]{ "Product_Cost", "<", 200 },
					},

				},
				groupOperations = new string[] {"and","or","notAnd","notOr"}
			};

			this.dxFilterBuilder1.Update();
        }
    }
}
