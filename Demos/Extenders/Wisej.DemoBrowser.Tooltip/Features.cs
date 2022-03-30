using System;
using System.Threading;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Tooltip
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
        }

        private void Features_Load(object sender, EventArgs e)
        {
            this.comboBoxIcon.DataSource = Enum.GetNames(typeof(ToolTipIcon));
            this.comboBoxAlignment.DataSource = Enum.GetNames(typeof(Placement));
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Focus();

            Application.StartTask(() =>
            {
                var maximum = this.progressBar1.Maximum;
                for (int i = 0; i <= maximum; i++)
                {
                    this.progressBar1.Value = i;
                    Application.Update(this);

                    Thread.Sleep((this.toolTipAutoPopDelay.AutoPopDelay - 1000) / maximum);
                }
            });
        }

        private void comboBoxIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var icon = (string)this.comboBoxIcon.SelectedItem;

            this.toolTipIcon.ToolTipIcon = (ToolTipIcon)Enum.Parse(typeof(ToolTipIcon), icon);
            this.toolTipIcon.SetToolTip(this.comboBoxIcon, icon);
        }

        private void comboBoxAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var alignment = (string)this.comboBoxAlignment.SelectedItem;

            this.toolTipAlignment.Alignment = (Placement)Enum.Parse(typeof(Placement), alignment);
            this.toolTipAlignment.SetToolTip(this.comboBoxAlignment, alignment);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AlertBox.Show($"Text: {this.textBox1.Text}");
        }
    }
}
