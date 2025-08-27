using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Toast
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void buttonDefault_Click(object sender, EventArgs e)
		{
			new Web.Toast("Hello, World!").Show();
		}

		private void buttonAlignments_Click(object sender, EventArgs e)
		{
			foreach (var value in Enum.GetValues(typeof(ContentAlignment)))
			{
				var text = (string)Enum.GetName(typeof(ContentAlignment), value);

				new Web.Toast(text)
				{
					Alignment = (ContentAlignment)value,
				}.Show();
			}
		}

		private void buttonAutoCloseDelay_Click(object sender, EventArgs e)
		{
			new Web.Toast("Auto Close Delay: 10 seconds")
			{
				AutoCloseDelay = 10000
			}.Show();
		}

		private void buttonHtml_Click(object sender, EventArgs e)
		{
			new Web.Toast("<b>Hello,</b> <i>World!</i>")
			{
				AllowHtml = true
			}.Show();
		}

		private void buttonBackColor_Click(object sender, EventArgs e)
		{
			new Web.Toast("Custom BackColor")
			{
				BackColor = Color.Orange
			}.Show();
		}

		private void buttonIcon_Click(object sender, EventArgs e)
		{
			new Web.Toast("Toast with icon", "messagebox-hand").Show();
		}
	}
}
