using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoMultiSelect : TestBase
	{
		public kendoMultiSelect()
		{
			InitializeComponent();

			this.kendoMultiSelect1.Instance.onSelect += new WidgetEventHandler(kendoMultiSelect1_WidgetEvent);
		}

		private void kendoMultiSelect_Load(object sender, EventArgs e)
		{
			this.kendoMultiSelect1.Options.dataTextField = "text";
			this.kendoMultiSelect1.Options.dataValueField = "value";

			this.kendoMultiSelect1.Options.autoClose = this.checkBoxAutoClose.Checked;

			var dataSource = this.tagTextBoxDataSource.Text.Split(',');

			this.kendoMultiSelect1.Options.dataSource = new dynamic[]
			{
				new {text = "Alabama", value = "0"}, new {text = "Alaska", value = "1"},
				new {text = "American Samoa", value = "2"}, new {text = "Arizona", value = "3"},
				new {text = "Arkansas", value = "4"}, new {text = "California", value = "5"},
				new {text = "Colorado", value = "6"}, new {text = "Connecticut", value = "7"},
				new {text = "Delaware", value = "8"}, new {text = "District of Columbia", value = "9"},
				new {text = "Florida", value = "10"}, new {text = "Georgia", value = "11"},
				new {text = "Guam", value = "12"}, new {text = "Hawaii", value = "13"},
				new {text = "Idaho", value = "14"}, new {text = "Illinois", value = "15"},
				new {text = "Indiana", value = "16"}, new {text = "Iowa", value = "17"},
				new {text = "Kansas", value = "18"}, new {text = "Kentucky", value = "19"},
				new {text = "Louisiana", value = "20"}, new {text = "Maine", value = "21"},
				new {text = "Maryland", value = "22"}, new {text = "Massachusetts", value = "23"},
				new {text = "Michigan", value = "24"}, new {text = "Minnesota", value = "25"},
				new {text = "Minor Outlying Islands", value = "26"}, new {text = "Mississippi", value = "27"},
				new {text = "Missouri", value = "28"}, new {text = "Montana", value = "29"},
				new {text = "Nebraska", value = "30"}, new {text = "Nevada", value = "31"},
				new {text = "New Hampshire", value = "32"}, new {text = "New Jersey", value = "33"},
				new {text = "New Mexico", value = "34"}, new {text = "New York", value = "35"},
				new {text = "North Carolina", value = "36"}, new {text = "North Dakota", value = "37"},
				new {text = "Northern Mariana Islands", value = "38"}, new {text = "Ohio", value = "39"},
				new {text = "Oklahoma", value = "40"}, new {text = "Oregon", value = "41"},
				new {text = "Pennsylvania", value = "42"}, new {text = "Puerto Rico", value = "43"},
				new {text = "Rhode Island", value = "44"}, new {text = "South Carolina", value = "45"},
				new {text = "South Dakota", value = "46"}, new {text = "Tennessee", value = "47"},
				new {text = "Texas", value = "48"}, new {text = "U.S. Virgin Islands", value = "49"},
				new {text = "Utah", value = "50"}, new {text = "Vermont", value = "51"},
				new {text = "Virginia", value = "52"}, new {text = "Washington", value = "53"},
				new {text = "West Virginia", value = "54"}, new {text = "Wisconsin", value = "55"},
				new {text = "Wyoming", value = "56"}
			};
		}

		private void kendoMultiSelect1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private async void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.tagTextBoxDataSource.Text))
			{
				var data = this.tagTextBoxDataSource.Text.Split(',');
				var items = data.Select(d => new
				{
					value = Guid.NewGuid().ToString(),
					text = d
				});

				await this.kendoMultiSelect1.Instance.setDataSourceAsync(items);
			}

			this.kendoMultiSelect1.Options.autoClose = this.checkBoxAutoClose.Checked;

			this.kendoMultiSelect1.Update();
		}
	}
}