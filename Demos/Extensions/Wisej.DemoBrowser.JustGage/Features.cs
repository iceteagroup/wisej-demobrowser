using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.JustGage
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			nudValue.Value = (decimal)justGage.Value;
			nudDecimals.Value = justGage.Decimals;
			nudMinVal.Value = (decimal)justGage.Minimum;
			nudMaxVal.Value = (decimal)justGage.Maximum;
			txtLabel.Text = justGage.Label;
			txtTitle.Text = justGage.Text;
			chkHumanFriendly.Checked = justGage.HumanFriendly;
			chkFormatNumber.Checked = justGage.FormatNumber;
			chkDonut.Checked = justGage.Donut;
			chkGradient.Checked = justGage.Gradient;
			chkShowValue.Checked = justGage.ShowValue;
			chkShowPointer.Checked = justGage.ShowPointer;
			chkShowMinMax.Checked = justGage.ShowMinMax;
			btnValueColor.BackColor = justGage.ValueColor;
			btnLabelColor.BackColor = justGage.LabelColor;
		}

		private void nudValue_ValueChanged(object sender, EventArgs e)
		{
			justGage.Value = (float)nudValue.Value;
		}

		private void nudDecimals_ValueChanged(object sender, EventArgs e)
		{
			justGage.Decimals = (int)nudDecimals.Value;
			nudValue.DecimalPlaces = (int)nudDecimals.Value;
		}

		private void txtLabel_TextChanged(object sender, EventArgs e)
		{
			justGage.Label = txtLabel.Text;
		}

		private void txtTitle_TextChanged(object sender, EventArgs e)
		{
			justGage.Text = txtTitle.Text;
		}

		private void btnLabelColor_Click(object sender, EventArgs e)
		{
			using (ColorDialog dlg = new ColorDialog())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					justGage.LabelColor = dlg.Color;
			}
		}

		private void btnValueColor_Click(object sender, EventArgs e)
		{
			using (ColorDialog dlg = new ColorDialog())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
					justGage.ValueColor = dlg.Color;
			}
		}

		private void chkHumanFriendly_CheckedChanged(object sender, EventArgs e)
		{
			justGage.HumanFriendly = chkHumanFriendly.Checked;
		}

		private void chkFormatNumber_CheckedChanged(object sender, EventArgs e)
		{
			justGage.FormatNumber = chkFormatNumber.Checked;
		}

		private void chkShowMinMax_CheckedChanged(object sender, EventArgs e)
		{
			justGage.ShowMinMax = chkShowMinMax.Checked;
		}

		private void chkDonut_CheckedChanged(object sender, EventArgs e)
		{
			justGage.Donut = chkDonut.Checked;
		}

		private void chkShowValue_CheckedChanged(object sender, EventArgs e)
		{
			justGage.ShowValue = chkShowValue.Checked;
		}

		private void chkShowPointer_CheckedChanged(object sender, EventArgs e)
		{
			justGage.ShowPointer = chkShowPointer.Checked;
		}

		private void chkGradient_CheckedChanged(object sender, EventArgs e)
		{
			justGage.Gradient = chkGradient.Checked;
		}

		private void nudMinVal_ValueChanged(object sender, EventArgs e)
		{
			justGage.Minimum = (float) nudMinVal.Value;
		}

		private void nudMaxVal_ValueChanged(object sender, EventArgs e)
		{
			justGage.Maximum = (float) nudMaxVal.Value;
		}
	}
}
