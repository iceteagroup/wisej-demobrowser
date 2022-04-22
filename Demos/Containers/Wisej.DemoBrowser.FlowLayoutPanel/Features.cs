using System;
using System.Linq;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.FlowLayoutPanel
{
    public partial class Features : DemoView
	{
		private Random random = new Random();

		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.comboBoxView.Items.AddRange(Enum.GetNames(typeof(FlowDirection)));
		}

        private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
			var flow = (FlowDirection)Enum.Parse(typeof(FlowDirection), (string)this.comboBoxView.SelectedItem);
			this.flowLayoutPanel.FlowDirection = flow;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
			for (var i = 0; i < 10; i++)
				this.flowLayoutPanel.Controls.Add(new PersonCard());
        }
    }
}
