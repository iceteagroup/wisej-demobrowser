using System;
using System.Collections.Generic;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using System.Linq;
using Wisej.Web.Ext.Bubbles;

namespace Wisej.DemoBrowser.Bubbles
{
    public partial class Features : DemoView
    {
       
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {

            this.cmbBubblesAlignment.DataSource = Enum.GetNames(typeof(System.Drawing.ContentAlignment));

            this.cmbBubbleStyle.DataSource = Enum.GetNames(typeof(BubbleStyle));

            this.cmbBubblesAlignment.SelectedIndex = 0;
            this.cmbBubbleStyle.SelectedIndex = 0;

            bubbleNotification1.SetBubbleValue(textBox, textBox.Text.Length);
            bubbleNotification2.SetBubbleValue(button, button.Text.Length);
        }

        private void cmbBubblesAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.ContentAlignment option;
            Enum.TryParse<System.Drawing.ContentAlignment>(cmbBubblesAlignment.SelectedValue.ToString(), out option);

            bubbleNotification1.Alignment = option;
            bubbleNotification2.Alignment = option;
        }

        private void cmbBubbleStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            BubbleStyle option;
            Enum.TryParse<BubbleStyle>(cmbBubbleStyle.SelectedValue.ToString(), out option);

            bubbleNotification1.SetBubbleStyle(textBox, option);
            bubbleNotification2.SetBubbleStyle(button, option);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bubbleNotification1.SetBubbleValue(textBox,textBox.Text.Length);
        }

        private void bubbleNotification_Click(object sender, BubbleEventArgs e)
        {
            AlertBox.Show("Bubble clicked");
        }
    }
}
