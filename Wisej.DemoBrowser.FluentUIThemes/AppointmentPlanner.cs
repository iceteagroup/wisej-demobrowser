using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.FluentUIThemes
{
    public partial class AppointmentPlanner : DemoView
    {
        public AppointmentPlanner()
        {
            InitializeComponent();
        }

        private void Ignite_Load(object sender, EventArgs e)
        {
            //Application.Navigate($"/Ignite");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Navigate("https://wisej-appointmentplanner-48-a8dha3hzgweebef2.eastus-01.azurewebsites.net/", "_blank");
        }
    }
}
