using System.Threading;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.ProgressBar
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void buttonTask_Click(object sender, System.EventArgs e)
		{
			this.buttonTask.Enabled = false;
			this.progressBarSteps.Value = 0;
			Application.StartTask(() =>
			{
				for (int i = 0; i <= this.progressBarSteps.Maximum; i++)
				{
					this.progressBarSteps.Text = $"{i}%";
					this.progressBarSteps.PerformStep();
					Application.Update(this);
					Thread.Sleep(100);
				}

				this.buttonTask.Enabled = true;
				Application.Update(this);
			});
		}
	}
}
