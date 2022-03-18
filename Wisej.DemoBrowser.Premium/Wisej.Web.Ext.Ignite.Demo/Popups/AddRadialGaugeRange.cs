using System;
using System.Drawing;

namespace Wisej.Web.Ext.Ignite.Demo.Popups
{
	public partial class AddRadialGaugeRange : Form
	{
		public AddRadialGaugeRange()
		{
			this.TopLevel = false;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public object ToObject()
		{
			return new { name = this.textBox1.Text,
				brush = this.textBox2.Text,
				startValue = this.numericUpDown1.Value,
				endValue = this.numericUpDown2.Value,
				outerStartExtent = this.numericUpDown3.Value,
				outerEndExtent = this.numericUpDown4.Value
			};
		}
	}

	/// <summary>
	/// Sample to demonstrate adding a new Range to the Gauge
	/// </summary>
	public class GaugeRange
	{
		public string Name;
		public Color Brush;
		public int StartValue;
		public int EndValue;
		public double OuterStartExtent;


	}
}
