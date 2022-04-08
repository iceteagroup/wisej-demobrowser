using System.Drawing.Text;
using Wisej.Web;

namespace Wisej.DemoBrowser
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			// check font installed?
			if (!CheckOpenSansInstalled())
				Web.MessageBox.Show("Install <a target='_blank' href='https://fonts.google.com/specimen/Open+Sans'>Open Sans</a> for an optimal experience.<br>", allowHtml: true);

			Application.MainPage = new MainView();
			Application.SessionTimeout += Application_SessionTimeout;
		}

		private static bool CheckOpenSansInstalled()
        {
			var fontsCollection = new InstalledFontCollection();
			foreach (var fontFamily in fontsCollection.Families)
				if (fontFamily.Name == "Open Sans") 
					return true;

			return false;
		}

		private static void Application_SessionTimeout(object sender, System.ComponentModel.HandledEventArgs e)
		{
			e.Handled = true;
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}