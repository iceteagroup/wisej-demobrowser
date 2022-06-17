using System.Linq;
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

			var progressBars = this.panel2.Controls.Where(c => c is Web.ProgressBar)
				.Union(this.panel3.Controls.Where(c => c is Web.ProgressBar));
			
			foreach (Web.ProgressBar progressBar in progressBars)
			{
				progressBar.Value = 0;
			}

			Application.StartTask(() =>
			{
				for (int i = 0; i <= this.progressBarSteps.Maximum && !this.IsDisposed; i++)
				{
					foreach (Web.ProgressBar progressBar in progressBars)
                    {
						progressBar.Text = $"{i}%";
						progressBar.PerformStep();
					}
					
					Application.Update(this);
					Thread.Sleep(100);
				}

				this.buttonTask.Enabled = true;
				Application.Update(this);
			});
		}
	}
}
