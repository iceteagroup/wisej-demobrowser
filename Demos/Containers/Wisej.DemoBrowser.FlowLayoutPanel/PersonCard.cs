using System;
using Bogus;
using Wisej.Web;

namespace Wisej.DemoBrowser.FlowLayoutPanel
{
    public partial class PersonCard : Wisej.Web.UserControl
    {
        public PersonCard()
        {
            InitializeComponent();
        }

        private void PersonCard_Load(object sender, EventArgs e)
        {
            Faker faker = new Faker();
            lblName.Text = faker.Name.FullName();
            pbPhoto.ImageSource = $"https://i.pravatar.cc/150?img={faker.Random.Int(1, 70)}";
        }
    }
}
