using System;
using Bogus;
using Wisej.Web;

namespace Wisej.DemoBrowser.DataRepeater.Components
{
    public partial class DataRepeaterItem : Wisej.Web.UserControl
    {
        public DataRepeaterItem()
        {
            InitializeComponent();
        }

        private void DataRepeaterItem_Load(object sender, EventArgs e)
        {
            Faker faker = new Faker();
            lblName.Text = faker.Name.FirstName() + " " + faker.Name.LastName();
            lblBirthday.Text = faker.Date.Past().ToShortDateString();
            pictureBox1.ImageSource = faker.Internet.Avatar();
        }
    }
}
