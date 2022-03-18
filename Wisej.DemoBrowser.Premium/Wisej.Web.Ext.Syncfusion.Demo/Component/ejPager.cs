using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPager : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejPager()
		{
			InitializeComponent();

			this.ejPager1.Instance.click += new WidgetEventHandler(ejPager1_WidgetEvent);
			this.ejPager1.Instance.change += new WidgetEventHandler(ejPager1_WidgetEvent);
		}

		private void ejPager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			if (e.Type == "change" || e.Type == "click")
			{
				this.ejRotator1.Instance.gotoIndex(e.Data.currentPage);
			}
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonGoToFirstPage_Click(object sender, EventArgs e)
		{
			this.ejPager1.Instance.goToFirstPage();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejPager1.Instance.goToPage(this.numericSelectedPage.Value);
		}
	}
}
