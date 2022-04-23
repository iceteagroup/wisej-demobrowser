using Wisej.DemoBrowser.Common;
using Wisej.Web;
using System;

namespace Wisej.DemoBrowser.FlexLayoutPanel
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, System.EventArgs e)
        {
            cmbGender.SelectedIndex = 0;
            cmbHorizontalAlignment.SelectedIndex = 0;
            cmbLayoutStyle.SelectedIndex = 0;
            cmbVerticalAlignment.SelectedIndex = 0;
        }

        private void cmbLayoutStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var layoutStyle = cmbLayoutStyle.SelectedItem.ToString();
            this.flexLayoutPanel3.LayoutStyle = (FlexLayoutStyle)Enum.Parse(typeof(FlexLayoutStyle), layoutStyle);
        }

        private void cmbHorizontalAlignment_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var horizontalAlignment = cmbHorizontalAlignment.SelectedItem.ToString();
            this.flexLayoutPanel3.HorizontalAlign = (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), horizontalAlignment);
        }

        private void cmbVerticalAlignment_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var verticalAlignment = cmbVerticalAlignment.SelectedItem.ToString();
            this.flexLayoutPanel3.VerticalAlign = (VerticalAlignment)Enum.Parse(typeof(VerticalAlignment), verticalAlignment);
        }
    }
}
