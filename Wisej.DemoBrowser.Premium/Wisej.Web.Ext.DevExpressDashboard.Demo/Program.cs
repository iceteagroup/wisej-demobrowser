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
			//create the session's temp folder (will be deleted when the session ends)
			System.IO.Directory.CreateDirectory(TempPath);

			Application.MainPage = new MainView();

			//delete the session's temp folder when the session ends
			Application.ApplicationExit += new System.EventHandler(DeleteTempFolder);
		}

		/// <summary>
		/// Temp folder of the current session, so sessions don't overwrite or delete each other's dashboards.
		/// </summary>
		internal static string TempPath => Application.MapPath("Temp/" + Application.SessionId);

		static void DeleteTempFolder(object sender, System.EventArgs e)
		{
			var path = TempPath;
			if (System.IO.Directory.Exists(path))
				System.IO.Directory.Delete(path, true);
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