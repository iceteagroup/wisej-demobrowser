using System;
using System.ComponentModel;
using Wisej.DemoBrowser.Common;
namespace Wisej.DemoBrowser.DataGridView.Views
{
    [Description("You can use Wisej to display your data however you want. This demo demonstrates how you can present data with just a simple object array ")]
    [CustomName("Simple Binding")]
    [AddToTreeView(true)]
    [ImageSource("resource.wx/Wisej.Ext.VisualStudioIcons/MemoryArray.svg")]
	public partial class DGVSimpleBinding : Wisej.DemoBrowser.Common.Views.DemoView
    {
        public DGVSimpleBinding()
        {
            InitializeComponent();
        }

        private void SimpleBinding_Load(object sender, EventArgs e)
        {
            Profile[] objectArray = new Profile[3];

            objectArray[0] = new Profile()
            {
                firstName = "Trigui",
                lastName = "Alaa",
                birthday = new DateTime(1998, 06, 29),
                email = "alaa.trigui@iceteagroup.com",
                hobbies = "Gaming, Reading",
                phoneNumber = "+XXX-XXXXXXXX",
            };

            objectArray[1] = new Profile()
            {
                firstName = "Trigui",
                lastName = "Alaa",
                birthday = new DateTime(1998, 06, 29),
                email = "alaa.trigui@iceteagroup.com",
                hobbies = "Gaming, Reading",
                phoneNumber = "+XXX-XXXXXXXX",
            };

            objectArray[2] = new Profile()
            {
                firstName = "Trigui",
                lastName = "Alaa",
                birthday = new DateTime(1998, 06, 29),
                email = "alaa.trigui@iceteagroup.com",
                hobbies = "Gaming, Reading",
                phoneNumber = "+XXX-XXXXXXXX",
            };


            this.dataGridView1.DataSource = objectArray;
        }
                

        }

    class Profile
    {
        public Profile()
        {

        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string hobbies { get; set; }
        public string phoneNumber { get; set; }

    }
}

   
