using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejTagCloud : TestBase
	{
		public ejTagCloud()
		{
			InitializeComponent();

			this.ejTagCloud1.Instance.onClick += new WidgetEventHandler(ejTagCloud1_WidgetEvent);
		}

		private void ejTagCloud_Load(object sender, EventArgs e)
		{
			this.ejTagCloud1.Options.titleText = "Tech Sites";
			this.ejTagCloud1.Options.dataSource = new object[]
			{
				new
				{
					text = "Google",
					url = "//www.google.com",
					frequency = 12
				},
				new
				{
					text = "All Things Digital",
					url = "//allthingsd.com/",
					frequency = 3
				},
				new
				{
					text = "Arts Technica",
					url = "//arstechnica.com/",
					frequency = 8
				},
				new
				{
					text = "Business Week",
					url = "//www.businessweek.com/",
					frequency = 2
				},
				new
				{
					text = "Yahoo",
					url = "//in.yahoo.com/",
					frequency = 12
				},
				new
				{
					text = "Center Networks",
					url = "//www.centernetworks.com/",
					frequency = 5
				},
				new
				{
					text = "Crave",
					url = "//news.cnet.com/crave/",
					frequency = 8
				},
				new
				{
					text = "Crunch Gear",
					url = "//techcrunch.com/gadgets/",
					frequency = 20
				},
				new
				{
					text = "Daily Tech",
					url = "//www.dailytech.com/",
					frequency = 1
				},
				new
				{
					text = "Electronista",
					url = "//www.electronista.com/",
					frequency = 3
				},
				new
				{
					text = "Engadget",
					url = "//www.engadget.com/",
					frequency = 5
				},
				new
				{
					text = "Gearlog",
					url = "//www.gearlog.com/",
					frequency = 9
				},
				new
				{
					text = "Information Week",
					url = "//www.informationweek.com/",
					frequency = 0
				},
				new
				{
					text = "PCWorld",
					url = "//www.pcworld.com/",
					frequency = 11
				},
				new
				{
					text = "Tech Republic",
					url = "//techrepublic.com/",
					frequency = 3
				},
				new
				{
					text = "Valleywag",
					url = "//valleywag.gawker.com/",
					frequency = 6
				},
				new
				{
					text = "Rediff",
					url = "//in.rediff.com/",
					frequency = 9
				},
				new
				{
					text = "WebProNews",
					url = "//www.webpronews.com/",
					frequency = 2
				}
			};
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejTagCloud1.Options.format = this.comboBoxFormat.Text;
			this.ejTagCloud1.Options.showTitle = this.checkBox1.Checked;
			this.ejTagCloud1.Options.minFontSize = $"{this.numericUpDownMinimumFontSize.Value}px";
			this.ejTagCloud1.Options.maxFontSize = $"{this.numericUpDownMaximumFontSize.Value}px";

			this.ejTagCloud1.Update();
		}

		private void ejTagCloud1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}