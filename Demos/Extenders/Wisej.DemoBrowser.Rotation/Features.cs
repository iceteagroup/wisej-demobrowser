using System;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Rotation
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			foreach (var control in this.Controls)
			{
				var numericUpDown = control as NumericUpDown ?? null;
				if (numericUpDown != null)
					numericUpDown.ValueChanged += NumericUpDown_ValueChanged; ;
			}
		}

		private void NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			UpdateLabel();
		}

		private void UpdateLabel()
		{
			this.rotation1.SetRotation(this.label3, new Web.Rotation.Properties()
			{
				Perspective = (int) this.numericUpDownPerspective.Value,
				RotateX = (int)this.numericUpDownXRotation.Value,
				RotateY = (int)this.numericUpDownYRotation.Value,
				RotateZ = (int)this.numericUpDownZRotation.Value,
				ScaleX = (int)this.numericUpDownXScale.Value,
				ScaleY = (int)this.numericUpDownYScale.Value,
				ScaleZ = (int)this.numericUpDownZScale.Value,
			});
		}
	}
}
