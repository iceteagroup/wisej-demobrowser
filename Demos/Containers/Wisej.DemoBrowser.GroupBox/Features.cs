using System;
using System.Threading;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.GroupBox
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void grpCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (grpCheckBox.Checked)
			{
				AlertBox.Show("Groupbox enabled");
				return;
			}
			AlertBox.Show("Groupbox disabled");
		}

		private void buttonTask_Click(object sender, EventArgs e)
		{
			if (this._running)
				return;

			this._running = true;

			Application.StartTask(() =>
			{
				for (var i = 1; i <= this.progressBar1.Maximum; i++)
				{
					this.progressBar1.Value = i;
					this.label1.Text = $"{i}%";
					Application.Update(this);
					Thread.Sleep(200);
				}

				this._running = false;
			});
		}
		private bool _running = false;
	}
}
