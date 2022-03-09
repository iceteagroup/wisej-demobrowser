using System;
using System.CodeDom;
using System.Drawing;
using System.IO;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.RibbonBar;

namespace Wisej.DemoBrowser.RibbonBar
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
            this.ribbonBarItemCheckBox1.Checked = true;
            this.ribbonBar.MenuButtonItemClick += RibbonBar_MenuButtonItemClick;

            this.ribbonBarItemComboBox1.Items = new string[] {
                "One", "Two", "Three"
            };
            this.ribbonBarItemComboBox1.Value = "One";
            this.ribbonBarItemTextBox2.Value = "Text2";
        }

        private void RibbonBar_MenuButtonItemClick(object sender, RibbonBarMenuItemEventArgs e)
        {
            var button = e.Item;
            AlertBox.Show($"Menu: {button.Text} Clicked, Menu Item: {e.MenuItem.Text}");
        }

        private void ribbonBar_ItemClick(object sender, Web.Ext.RibbonBar.RibbonBarItemEventArgs e)
        {
            if (e.Item.GetType() == typeof(RibbonBarItemCheckBox))
            {
                string checkStatus = ((RibbonBarItemCheckBox) e.Item).Checked ? "Checked" : "Unchecked";
                AlertBox.Show($"Checkbox: {e.Item.Text} {checkStatus} ", showProgressBar: true);

                return;
            }

            if (e.Item.GetType() == typeof(RibbonBarItemButton))
            {

                object imgSource = Application.Theme.Images[e.Item.ImageSource];
                if (imgSource == null) imgSource = e.Item.ImageSource;

                string img = $"<img src='{imgSource}' width='32px' height='32px'> ";
                AlertBox.Show($"Button: {img}{e.Item.Text} Clicked ", showProgressBar: true, allowHtml:true);

                return;
            }

            if (e.Item.GetType() == typeof(RibbonBarItemTextBox))
            {
                AlertBox.Show($"Button: {e.Item.Text} Clicked And Entered", showProgressBar: true);
                return;
            }

        }

        private void ribbonBar_GroupClick(object sender, RibbonBarGroupEventArgs e)
        {
            AlertBox.Show($"Group: {e.Group.Text} clicked", showProgressBar: true);
        }

        private void ribbonBar_AppButtonClick(object sender, EventArgs e)
        {
            AlertBox.Show("App Button Clicked");
        }

        private void ribbonBar_ToolClick(object sender, ToolClickEventArgs e)
        {
            AlertBox.Show("Tool Click: " + e.Tool.ToolTipText);
        }

        private void ribbonBarItemComboBox1_ValueChanged(object sender, EventArgs e)
        {
            RibbonBarItemComboBox comboBox = (RibbonBarItemComboBox) sender;
            AlertBox.Show($"ComboBox Selected Value: {comboBox.Value}");
        }

        private void ribbonBarItemTextBox1_Click(object sender, EventArgs e)
        {
            AlertBox.Show($"ComboBox Selected Value:");
        }
    }
}
