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

		private void button1_Click(object sender, EventArgs e)
		{
			this.queryBuilder1.Instance.getSqlFromRules(new Action<dynamic>((r) => {
				AlertBox.Show(r);
			}));
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.queryBuilder1.Update();
		}
	}
}
