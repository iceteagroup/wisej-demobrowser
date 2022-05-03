using System;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.AceEditor
{
    public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{
			this.aceEditor1.Text = GetSampleCode("XML");
		}

		private void checkBoxIndent_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.DisplayIndentGuides = this.checkBoxIndent.Checked;
		}

		private void checkBoxGutter_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.ShowGutter = this.checkBoxGutter.Checked;
		}

		private void checkBoxLineNumbers_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.ShowLineNumbers = this.checkBoxLineNumbers.Checked;
		}

		private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
		{
			var language = (string)this.comboBoxLanguage.SelectedItem;
			this.aceEditor1.Text = GetSampleCode(language);
			this.aceEditor1.Language = language.ToLower();
		}

		private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.aceEditor1.Theme = (string)this.comboBoxTheme.SelectedItem;
		}

		private void checkBoxPrintMargin_CheckedChanged(object sender, EventArgs e)
		{
			this.aceEditor1.ShowPrintMargin = this.checkBoxPrintMargin.Checked;
		}

		private string GetSampleCode(string lang)
		{
			switch (lang)
            {
				case "XML":
					return @"<?xml version='1.0'?>
<catalog>
	<book id='bk101'>
	<author>Gambardella, Matthew</author>
	<title>XML Developer's Guide</title>
	<genre>Computer</genre>
	<price>44.95</price>
	<publish_date>2000-10-01</publish_date>
	<description>An in-depth look at creating applications 
	with XML.</description>
	</book>
</catalog>";

				case "HTML":
					return @"<!DOCTYPE html>
<html>
	<body>
	<h1>My First Heading</h1>
	<p>My first paragraph.</p>
	</body>
</html>";

				case "JavaScript":
					return @"var x, y, z;  // Declare 3 variables
x = 5;    // Assign the value 5 to x
y = 6;    // Assign the value 6 to y
z = x + y;  // Assign the sum of x and y to z

document.getElementById('demo').innerHTML =
'The value of z is ' + z + '.';";

				case "CSharp":
					return @"namespace CSharpTutorials
{
	class Program
	{
		static void Main(string[] args)
		{
			string message = 'Hello World!!';

			Console.WriteLine(message);
		}
	}
}";

				default:
					return "";
            }
        }
	}
}
