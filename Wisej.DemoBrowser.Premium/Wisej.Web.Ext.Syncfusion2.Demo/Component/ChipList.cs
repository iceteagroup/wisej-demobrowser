using System;
using System.Linq;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class ChipList : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public ChipList()
		{
			InitializeComponent();

			this.chipList1.Instance.click += new WidgetEventHandler(chipList1_WidgetEvent);
			this.chipList1.Instance.delete += new WidgetEventHandler(chipList1_WidgetEvent);
		}

		private void ChipList_Load(object sender, EventArgs e)
		{
			this.chipList1.Options.chips = new object[] 
			{ 
				new 
				{ 
					text = "Apple",
					cssClass = "e-primary",
					avatarText =""
				}, 
				new 
				{ 
					text = "Microsoft",
					cssClass = "e-info",
					avatarText =""

				},
				new 
				{ 
					text = "Google",
					cssClass = "e-success",
					avatarText =""

				},
				new 
				{ 
					text = "Tesla",
					cssClass = "e-warning",
					avatarText =""

				},
				new 
				{ 
					text = "Intel",
					cssClass = "e-danger",
					avatarText =""
				}
			};
		}

		private void chipList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
			this.chipList1.Options.selection = this.comboBoxSelection.Text;
			this.chipList1.Options.enableDelete = this.checkBoxDelete.Checked;

            for (int i = 0; i < ((object[])this.chipList1.Options.chips).Count(); i++)
            {
				this.chipList1.Options.chips[i] = new
				{
					text = this.chipList1.Options.chips[i].text,
					cssClass = this.chipList1.Options.chips[i].cssClass,
					avatarText = this.textBoxAvatarText.Text.Take(1)
																.FirstOrDefault()
																.ToString().ToUpper()
				};

			}


			this.chipList1.Update();
        }
    }
}
