using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejPager : TestBase
	{
		public ejPager()
		{
			InitializeComponent();

			this.ejPager1.Instance.onClick += new WidgetEventHandler(ejPager1_WidgetEvent);
			this.ejPager1.Instance.onChange += new WidgetEventHandler(ejPager1_WidgetEvent);
		}

		private void ejPager_Load(object sender, EventArgs e)
		{
			//ejRotator1
			this.ejRotator1.Options.showPager = false;
			this.ejRotator1.Options.showCaption = true;
			this.ejRotator1.Options.animationType = "slide";
			this.ejRotator1.Options.dataSource = new object[]
			{
				new
				{
					text = "Beautiful Bird",
					url = "images/bird.jpg"
				},
				new
				{
					text = "Colorful Night",
					url = "images/night.jpg"
				},
				new
				{
					text = "Nature",
					url = "images/nature.jpg"
				},
				new
				{
					text = "Snow Fall",
					url = "images/snowfall.jpg"
				},
				new
				{
					text = "Credit Card",
					url = "images/card.jpg"
				},
				new
				{
					text = "Amazing Sculptures",
					url = "images/sculpture.jpg"
				}
			};

			//ejPager1
			this.ejPager1.Options.pageSize = 1;
			this.ejPager1.Options.totalPages = 6;
			this.ejPager1.Options.totalRecordsCount = 6;
			this.ejPager1.Options.pageCount = 3;
			this.ejPager1.Options.isResponsive = true;
		}

		private void ejPager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			if (e.Type == "change" || e.Type == "click") this.ejRotator1.Instance.gotoIndex(e.Data.currentPage);
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