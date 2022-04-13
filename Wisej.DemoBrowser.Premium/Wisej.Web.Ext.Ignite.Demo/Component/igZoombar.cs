using System;
using System.Threading;
using Wisej.Web;

namespace Wisej.Web.Ext.Ignite.Demo.Component
{
	public partial class igZoombar : TestBase
	{
		Ignite.igZoombar igZoombar1;
		public igZoombar()
		{
			InitializeComponent();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.igZoombar1.Options.zoomWindowMoveDistance = this.numericUpDown1.Value;
			this.igZoombar1.Options.zoomWindowMinWidth = this.numericUpDown2.Value;
			this.igZoombar1.Options.windowPanDuration = this.numericUpDown3.Value;

			this.igZoombar1.Update();
		}

		private void igDataChart1_Appear(object sender, EventArgs e)
		{
			igZoombar1 = new Ignite.igZoombar(new { target = $"#id_{this.igDataChart1.Handle}_container" });
			igZoombar1.Dock = DockStyle.Fill;
			this.panel1.Controls.Add(igZoombar1);
		}
	}
}
