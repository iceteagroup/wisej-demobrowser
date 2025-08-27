using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Accordion
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.chkCollapsible.Checked = this.accordion1.Collapsible;
			this.chkSelectedOnTop.Checked = this.accordion1.SelectedOnTop;
		}

		private void chkSelectedOnTop_CheckedChanged(object sender, EventArgs e)
		{
			this.accordion1.SelectedOnTop = this.chkSelectedOnTop.Checked;
			if (this.accordion1.SelectedOnTop)
			{
				this.chkCollapsible.Checked = false;
				this.chkCollapsible.Enabled = false;
				return;
			}
			this.chkCollapsible.Enabled = true;
		}

		private void chkCollapsible_CheckedChanged(object sender, EventArgs e)
		{
			this.accordion1.Collapsible = this.chkCollapsible.Checked;
		}

		private void accordion1_Selected(object sender, AccordionEventArgs e)
		{
			AccordionPanel accordionPanel = this.accordion1.SelectedPanel;
			AlertBox.Show($"{accordionPanel.Text} Panel Selected");
		}

		private void accordion1_Deselected(object sender, AccordionEventArgs e)
		{
			AlertBox.Show("Panel Deselected");
		}
	}
}
