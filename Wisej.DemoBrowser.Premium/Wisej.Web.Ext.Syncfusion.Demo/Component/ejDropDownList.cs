using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejDropDownList : TestBase
	{
		public ejDropDownList()
		{
			InitializeComponent();

			this.ejDropDownList1.Instance.onChange += new WidgetEventHandler(ejDropDownList_WidgetEvent);
		}

		private void ejDropDownList_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$@"<b>{e.Type}</b><br/>
				{e.Data}",
				MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			Update(this.ejDropDownList1);
			Update(this.ejDropDownList2);
		}

		private void Update(Wisej.Web.Ext.Syncfusion.ejDropDownList ejList)
		{
			ejList.Options.allowVirtualScrolling = this.checkBox1.Checked;
			ejList.Options.caseSensitiveSearch = this.checkBox2.Checked;
			ejList.Options.enableIncrementalSearch = this.checkBox3.Checked;
			ejList.Options.enableFilterSearch = this.checkBox4.Checked;
			ejList.Options.enableSorting = this.checkBox5.Checked;
			ejList.Options.showCheckbox = this.checkBox6.Checked;

			ejList.Update();
		}

		private void ejDropDownList_Load(object sender, EventArgs e)
		{
			//ejDropDownList1
			this.ejDropDownList1.Options.watermarkText = "Select your skill";
			this.ejDropDownList1.Options.showCheckbox = true;
			this.ejDropDownList1.Options.fields = new
			{
				text = "skill"
			};
			this.ejDropDownList1.Options.dataSource = new object[]
			{
				new
				{
					skill = "ASP.NET"
				},
				new
				{
					skill = "ActionScript"
				},
				new
				{
					skill = "Basic"
				},
				new
				{
					skill = "C++"
				},
				new
				{
					skill = "C#"
				},
				new
				{
					skill = "dBase"
				},
				new
				{
					skill = "Delphi"
				},
				new
				{
					skill = "ESPOL"
				},
				new
				{
					skill = "F#"
				},
				new
				{
					skill = "FoxPro"
				},
				new
				{
					skill = "Java"
				},
				new
				{
					skill = "J#"
				},
				new
				{
					skill = "Lisp"
				},
				new
				{
					skill = "Logo"
				},
				new
				{
					skill = "PHP"
				}
			};

			//ejDropDownList2
			this.ejDropDownList2.Options.watermarkText = "Select a vegetable";
			this.ejDropDownList2.Options.allowGrouping = true;
			this.ejDropDownList2.Options.fields = new
			{
				text = "skill",
				category = "category"
			};
			this.ejDropDownList2.Options.dataSource = new object[]
			{
				new
				{
					skill = "Cabbage",
					category = "Leafy and Salad"
				},
				new
				{
					skill = "Pea",
					category = "Leafy and Salad"
				},
				new
				{
					skill = "Spinach",
					category = "Leafy and Salad"
				},
				new
				{
					skill = "Wheatgrass",
					category = "Leafy and Salad"
				},
				new
				{
					skill = "Yarrow",
					category = "Leafy and Salad"
				},
				new
				{
					skill = "Chickpea",
					category = "Beans"
				},
				new
				{
					skill = "Green bean",
					category = "Beans"
				},
				new
				{
					skill = "Horse gram",
					category = "Beans"
				},
				new
				{
					skill = "Peanut",
					category = "Beans"
				},
				new
				{
					skill = "Pigeon pea",
					category = "Beans"
				},
				new
				{
					skill = "Garlic",
					category = "Bulb and Stem"
				},
				new
				{
					skill = "Garlic Chives",
					category = "Bulb and Stem"
				},
				new
				{
					skill = "Lotus root",
					category = "Bulb and Stem"
				},
				new
				{
					skill = "Nopal",
					category = "Bulb and Stem"
				},
				new
				{
					skill = "Onion",
					category = "Bulb and Stem"
				},
				new
				{
					skill = "Shallot",
					category = "Bulb and Stem"
				},
				new
				{
					skill = "Beetroot",
					category = "Root and Tuberous"
				},
				new
				{
					skill = "Carrot",
					category = "Root and Tuberous"
				},
				new
				{
					skill = "Ginger",
					category = "Root and Tuberous"
				},
				new
				{
					skill = "Potato",
					category = "Root and Tuberous"
				},
				new
				{
					skill = "Radish",
					category = "Root and Tuberous"
				},
				new
				{
					skill = "Turmeric",
					category = "Root and Tuberous"
				}
			};
		}
	}
}