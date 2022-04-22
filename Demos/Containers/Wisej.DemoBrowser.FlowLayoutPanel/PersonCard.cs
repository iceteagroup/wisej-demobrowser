using System;
using System.Drawing;
using Bogus;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.FlowLayoutPanel
{
	public partial class PersonCard : Wisej.Web.UserControl
	{
		public string PersonName;

		public bool Checked = false;		

		public PersonCard()
		{
			InitializeComponent();
		}

		private void PersonCard_Load(object sender, EventArgs e)
		{
			Faker faker = new Faker();
			this.PersonName = faker.Name.FullName();
			
			labelName.Text = this.PersonName;
			labelSubject.Text = faker.Lorem.Sentence();
			labelTime.Text = DateTime.Now.ToString("HH:mm");
			pictureBoxPhoto.ImageSource = ImageHelper.GetRandomPerson();
		}

		private void checkBoxMark_CheckedChanged(object sender, EventArgs e)
		{
			var check = this.checkBoxMark.Checked ? "Checked" : "Unchecked";
			AlertBox.Show($"{check} the message from {this.labelName.Text}");

			this.Checked = true;
		}

		private void PersonCard_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.FromArgb(245, 246, 246);
			this.Font = new Font("@default", 12F, GraphicsUnit.Pixel);

			AlertBox.Show($"Selected the message from {this.labelName.Text}");
		}
	}
}
