using System;
using System.Globalization;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			kendoBase.Theme = "bootstrap-main";
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