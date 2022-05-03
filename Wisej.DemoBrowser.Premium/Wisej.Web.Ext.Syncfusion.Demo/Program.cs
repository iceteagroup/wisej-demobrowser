namespace Wisej.Web.Ext.Syncfusion.Demo
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.CurrentCulture = new System.Globalization.CultureInfo("pt");

			ejBase.Theme = "bootstrap-theme";
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