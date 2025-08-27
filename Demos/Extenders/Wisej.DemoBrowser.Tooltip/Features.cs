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

			this.comboBoxAlignment.SelectedIndex = 0;
			this.comboBoxIcon.SelectedIndex = 0;
		}

		private void comboBoxIcon_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.toolTip.ToolTipIcon =
				(ToolTipIcon) Enum.Parse(typeof(ToolTipIcon), this.comboBoxIcon.SelectedItem.ToString());
		}

		private void comboBoxAlignment_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.toolTip.Alignment =
				(Placement) Enum.Parse(typeof(Placement), this.comboBoxAlignment.SelectedItem.ToString());
		}

		private void txtToolTipText_TextChanged(object sender, EventArgs e)
		{
			this.toolTip.SetToolTip(this.btnToolTip, txtToolTipText.Text);
		}

		private void chkAllowHtml_CheckedChanged(object sender, EventArgs e)
		{
			this.toolTip.AllowHtml = chkAllowHtml.Checked;
		}

		private void txtColor_Enter(object sender, EventArgs e)
		{
			using (ColorDialog dlg = new ColorDialog())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					this.toolTip.ForeColor = dlg.Color;
					this.txtColor.Text = dlg.Color.ToString();
					this.txtColor.BackColor = dlg.Color;
				}
			}
		}
	}
}