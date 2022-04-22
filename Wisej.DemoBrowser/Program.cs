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
            //if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
            //{
            //    //WIP
            //    return true;
            //}

            //if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
            //{
                var fontsCollection = new System.Drawing.Text.InstalledFontCollection();
                foreach (var fontFamily in fontsCollection.Families)
                    if (fontFamily.Name == "Open Sans")
                        return true;

                return false;
            //}

            //if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Linux))
            //{
            //    string command = "fc-list | grep –I OpenSans";
            //    string result = "";
            //    using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
            //    {
            //        proc.StartInfo.FileName = "/bin/bash";
            //        proc.StartInfo.Arguments = "-c \" " + command + " \"";
            //        proc.StartInfo.UseShellExecute = false;
            //        proc.StartInfo.RedirectStandardOutput = true;
            //        proc.StartInfo.RedirectStandardError = true;
            //        proc.Start();

            //        result += proc.StandardOutput.ReadToEnd();
            //        result += proc.StandardError.ReadToEnd();

            //        proc.WaitForExit();

            //    }
            //    if (!string.IsNullOrEmpty(result) && result.ToLower().Contains("opensans"))
            //    {
            //        return true;
            //    }
            //    return false;
            //}

            //return false;
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