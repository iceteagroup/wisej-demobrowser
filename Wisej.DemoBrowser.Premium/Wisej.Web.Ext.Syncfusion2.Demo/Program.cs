using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			ej2Base.Theme = "bootstrap5";
			Application.MainPage = new MainView();
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