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
			this.comboBoxView2.Items.AddRange(Enum.GetNames(typeof(FlowDirection)));
		}

		private void comboBoxView_SelectedIndexChanged(object sender, EventArgs e)
        {
			var flow = (FlowDirection)Enum.Parse(typeof(FlowDirection), (string)this.comboBoxView.SelectedItem);
			this.flowLayoutPanel1.FlowDirection = flow;
        }

		private void comboBoxView2_SelectedIndexChanged(object sender, EventArgs e)
		{
			var flow = (FlowDirection)Enum.Parse(typeof(FlowDirection), (string)this.comboBoxView2.SelectedItem);
			this.flowLayoutPanel.FlowDirection = flow;
		}
	}
}
