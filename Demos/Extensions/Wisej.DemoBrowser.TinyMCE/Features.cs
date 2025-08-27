using System;
using System.IO;
using System.Reflection;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.TinyMCE
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			var name = "Wisej.DemoBrowser.TinyMCE.data.html";
			var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
			using (var sr = new StreamReader(resource))
				this.tinyMCE1.Text = sr.ReadToEnd();
		}
	}
}
