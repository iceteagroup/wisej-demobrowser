using System;
using System.Threading;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.HelpTip
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			comboBoxIcon.DataSource = Enum.GetNames(typeof(ToolTipIcon));
			comboBoxAlignment.DataSource = Enum.GetNames(typeof(Placement));
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			AlertBox.Show("Clicked!");
		}

		private void comboBoxAlignment_SelectedIndexChanged(object sender, EventArgs e)
		{
			var alignment = (string) comboBoxAlignment.SelectedItem;

			helpTipAlignment.Alignment = (Placement) Enum.Parse(typeof(Placement), alignment);
			helpTipAlignment.SetHelpTip(comboBoxAlignment, alignment);
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{
			progressBar1.Focus();

			Application.StartTask(() =>
			{
				var maximum = progressBar1.Maximum;
				for (var i = 0; i <= maximum; i++)
				{
					progressBar1.Value = i;
					Application.Update(this);

					Thread.Sleep((helpTipAutoPopDelay.AutoPopDelay - 1000) / maximum);
				}
			});
		}

		private void comboBoxIcon_SelectedIndexChanged(object sender, EventArgs e)
		{
			var icon = (string) comboBoxIcon.SelectedItem;

			helpTipIcon.HelpTipIcon = (ToolTipIcon) Enum.Parse(typeof(ToolTipIcon), icon);
			helpTipIcon.SetHelpTip(comboBoxIcon, icon);
		}

		private void buttonCustomColors_Click(object sender, EventArgs e)
		{
			using (var dlg = new ColorDialog())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					helpTipColor.ForeColor = dlg.Color;
					buttonCustomColors.BackColor = dlg.Color;
				}
			}
		}
	}
}