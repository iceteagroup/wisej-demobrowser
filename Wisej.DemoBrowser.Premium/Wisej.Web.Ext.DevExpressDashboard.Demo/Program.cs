using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExpressDashboard.Demo
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.MainPage = new MainView();

			//create temp folder (will be deleted when user closes application)
			System.IO.Directory.CreateDirectory("./Temp");

			//delete temp folder when user closes application
			Application.ApplicationExit += new System.EventHandler(DeleteTempFolder);
		}

		static void DeleteTempFolder(object sender, System.EventArgs e)
		{
			System.IO.Directory.Delete("./Temp");
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