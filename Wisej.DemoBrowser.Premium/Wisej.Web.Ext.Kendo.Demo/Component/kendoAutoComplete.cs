using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoAutoComplete : Wisej.Web.Ext.Kendo.Demo.Component.TestBase
	{
		public kendoAutoComplete()
		{
			InitializeComponent();

			this.kendoAutoComplete1.Instance.onChange += new WidgetEventHandler(kendoAutoComplete1_WidgetEvent);
			this.kendoAutoComplete1.Instance.onSelect += new WidgetEventHandler(kendoAutoComplete1_WidgetEvent);
		}

		private void kendoAutoComplete_Load(object sender, EventArgs e)
		{
			this.kendoAutoComplete1.Options.dataSource = new string[]
			{
				"Albania",
				"Andorra",
				"Armenia",
				"Austria",
				"Azerbaijan",
				"Belarus",
				"Belgium",
				"Bosnia & Herzegovina",
				"Bulgaria",
				"Croatia",
				"Cyprus",
				"Czech Republic",
				"Denmark",
				"Estonia",
				"Finland",
				"France",
				"Georgia",
				"Germany",
				"Greece",
				"Hungary",
				"Iceland",
				"Ireland",
				"Italy",
				"Kosovo",
				"Latvia",
				"Liechtenstein",
				"Lithuania",
				"Luxembourg",
				"Macedonia",
				"Malta",
				"Moldova",
				"Monaco",
				"Montenegro",
				"Netherlands",
				"Norway",
				"Poland",
				"Portugal",
				"Romania",
				"Russia",
				"San Marino",
				"Serbia",
				"Slovakia",
				"Slovenia",
				"Spain",
				"Sweden",
				"Switzerland",
				"Turkey",
				"Ukraine",
				"United Kingdom",
				"Vatican City"
			};

			this.kendoAutoComplete1.Options.filter = "startswith";
			this.kendoAutoComplete1.Options.placeholder = "Select country...";
			this.kendoAutoComplete1.Options.separator = ", ";

		}
		private void kendoAutoComplete1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			// enable / disable animations.
			if (this.checkBox1.Checked)
			{
				this.kendoAutoComplete1.Options.animation = new
				{
					close = new 
					{
						effects = "fadeOut zoom:out",
						duration = 300
					},
					open = new
					{
						effects = "fadeIn zoom:in",
						duration = 300
					}
				};
			}
			else
			{
				this.kendoAutoComplete1.Options.animation = false;
			}
			this.kendoAutoComplete1.Options.clearButton = this.checkBox2.Checked;
			this.kendoAutoComplete1.Options.highlightFirst = this.checkBox3.Checked;
			this.kendoAutoComplete1.Options.ignoreCase = this.checkBox4.Checked;
			this.kendoAutoComplete1.Options.suggest = this.checkBox5.Checked;
			this.kendoAutoComplete1.Options.delay = this.numericUpDown1.Value;

			this.kendoAutoComplete1.Update();
		}
	}
}
