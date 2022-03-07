using System;
using System.Windows.Forms;
using Wisej.DemoBrowser.Common;
using UserControl = Wisej.Web.UserControl;

namespace Wisej.DemoBrowser.PropertyGrid
{
    public partial class PersonCard : UserControl
    {
        public Person Person
        {
            get => Person.Instance;
        }

        public PersonCard()
        {
            InitializeComponent();
        }

        private void PersonCard_Load(object sender, EventArgs e)
        {
            lblIssued.Text += DateTime.Now.ToShortDateString();

            lblFirstNameTxt.DataBindings.Add(new Binding("Text", Person, "FirstName"));
            lblLastNameTxt.DataBindings.Add(new Binding("Text", Person, "LastName"));
            lblGenderTxt.DataBindings.Add(new Binding("Text", Person, "Gender"));
            lblAddressTxt.DataBindings.Add(new Binding("Text", Person, "Address"));
            lblID.DataBindings.Add(new Binding("Text", Person, "Id"));
            barcode1.DataBindings.Add(new Binding("Text", Person, "Details"));
            pnlFavColor.DataBindings.Add(new Binding("BackColor", Person, "FavoriteColor"));
            lblDobTxt.DataBindings.Add(new Binding("Text", Person, "Dob"));
            pbVip.DataBindings.Add(new Binding("Visible", Person, "IsVip"));
        }

        private void pnlFavColor_PanelCollapsed(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
