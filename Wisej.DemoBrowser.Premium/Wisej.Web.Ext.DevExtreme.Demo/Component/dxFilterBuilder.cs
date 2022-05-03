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
    }
}
