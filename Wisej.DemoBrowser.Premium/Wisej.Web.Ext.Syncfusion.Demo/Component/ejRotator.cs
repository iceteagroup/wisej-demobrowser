using System;
using System.Globalization;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejRotator : TestBase
	{
		public ejRotator()
		{
			InitializeComponent();

			this.ejRotator1.Instance.onPagerClick += new WidgetEventHandler(ejRotator1_pagerClick);
		}

		private void ejRotator_Load(object sender, EventArgs e)
		{
			this.ejRotator1.Options.showCaption = true;
			this.ejRotator1.Options.showPlayButton = true;
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
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejRotator1.Options.showCaption = this.checkBox1.Checked;
			this.ejRotator1.Options.showPlayButton = this.checkBox2.Checked;
			this.ejRotator1.Options.animationType =
				char.ToLower(this.comboBox1.Text[0]) + this.comboBox1.Text.Substring(1);

			this.ejRotator1.Update();
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			this.ejRotator1.Instance.play();
		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			this.ejRotator1.Instance.pause();
		}

		private void ejRotator1_pagerClick(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"Slide Index: {e.Data.activeItemIndex}");
		}
	}
}