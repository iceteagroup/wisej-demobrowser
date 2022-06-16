using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TagTextBox
{
	public partial class Features : DemoView
	{
		private Random random = new Random();

		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			var stateCodes = new[]
			{
				"AK", "AL", "AR", "AS", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "GU", "HI", "IA", "ID", "IL",
				"IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MP", "MS", "MT", "NC", "ND", "NE", "NH",
				"NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UM", "UT", "VA",
				"VI", "VT", "WA", "WI", "WV", "WY"
			};

			foreach (var code in stateCodes)
			{
				this.tagDefault.Text += $"{code},";
				this.tagCustomRender.Text += $"{code},";
			}
		}

		private void tagTextBox2_TagRender(object sender, TagTextBoxRenderEventArgs e)
		{
			switch (e.Text.Replace(",", string.Empty))
			{
				case "AR":
					e.BackColor = Color.Beige;
					break;

				case "FL":
					e.BackColor = Color.LightGreen;
					break;

				case "AL":
					e.Html = "<b>" + e.Text + "</b>";
					break;

				case "CA":
					e.Html = "<u>" + e.Text + "</u>";
					break;

				case "GA":
					e.Html =
						"<img src='Images/html.png' style='display:inline-block;float:left;padding-right:5px' width=16/>" +
						e.Text;
					break;
				default:
				{
					e.BackColor = Color.FromArgb(this.random.Next(0, 255), this.random.Next(0, 255),
												this.random.Next(0, 255));

					e.Html = e.Html = "<b>" + e.Text + "</b>";
					break;
				}
			}
		}

		private void tagAutoComplete_TagAdded(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"{e.Text} Tag is Added");
		}

		private void Tag_Removed(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"{e.Text} is Removed");
		}

		private void Tag_Rejected(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"{e.Text} is Rejected, it already exists");
		}

		private void Tag_Selected(object sender, TagTextBoxEventArgs e)
		{
			AlertBox.Show($"{e.Text} Tag is Selected");
		}

		private void chkAutoSize_CheckedChanged(object sender, EventArgs e)
		{
			this.tagDefault.AutoSize = this.chkAutoSize.Checked;
			this.tagAllowDuplicates.AutoSize = this.chkAutoSize.Checked;
			this.tagAutoComplete.AutoSize = this.chkAutoSize.Checked;
			this.tagCustomRender.AutoSize = this.chkAutoSize.Checked;
		}
	}
}