using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.LinkLabel
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void LinkLabel_Click(object sender, System.EventArgs e)
        {
            Application.Navigate("https://docs.wisej.com/docs/controls/content/linklabel#link-behavior", "_blank");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Navigate("https://docs.wisej.com/docs/controls/content/linklabel#link-area", "_blank");
        }
    }
}
