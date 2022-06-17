using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TabControl
{
    public partial class Layout : DemoView
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void comboBoxAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = this.comboBoxAlignment.SelectedItem.ToString();
            var alignment = (TabAlignment)Enum.Parse(typeof(TabAlignment), text);

            this.tabControl.Alignment = alignment;

            UpdateText();
        }

        private void comboBoxOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = this.comboBoxOrientation.SelectedItem.ToString();
            var orientation = (Orientation)Enum.Parse(typeof(Orientation), text);

            this.tabControl.Orientation = orientation;

            UpdateText();
        }

        private void UpdateText()
        {
            var align = this.comboBoxAlignment.SelectedItem;
            var orient = this.comboBoxOrientation.SelectedItem;
            var text = $"TabPage aligned to the {align} and oriented {orient}ly";

            this.labelPage1Text.Text = text;
            this.labelPage2Text.Text = text;
        }
    }
}
