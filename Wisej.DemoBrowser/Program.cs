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
			Application.MainPage = new MainView();
			Application.SessionTimeout += Application_SessionTimeout;
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