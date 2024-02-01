using System;
using System.Drawing;
using System.Linq;
using Wisej.Demobrowser.Tesseract.Properties;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using static Wisej.Web.Ext.Camera.Camera;

namespace Wisej.DemoBrowser.Camera
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		//Note that this method must be async so that we can call ScanImageAsync
		private async void buttonScan1_Click(object sender, EventArgs e)
		{
			string scannedText = await tesseract1.ScanImageAsync(pictureBox1.Image);
			AlertBox.Show(scannedText);
			textBox_scanResult.Text = scannedText;
		}

		private void comboBox1_SelectedItemChanged(object sender, EventArgs e)
		{
			string pictureBoxImage = comboBox1.SelectedItem.ToString();
			SetPictureBoxImage(pictureBoxImage);
		}

		private void SetPictureBoxImage(string imageString)
		{
			//Get access to the assembly. 
			System.Reflection.Assembly assembly = this.GetType().Assembly;
			//Use the assembly to find an embedded resource based on the parameter imageString
			string resourceName = assembly.GetManifestResourceNames().FirstOrDefault(name => name.EndsWith(imageString));
			if (!String.IsNullOrEmpty(resourceName))
			{
				//create a System.Drawing.Image object
				System.IO.Stream resource = assembly.GetManifestResourceStream(resourceName);
				Image imageFromStream = Image.FromStream(resource);
				//set the image of the picturebox
				pictureBox1.Image = imageFromStream;
			}
		}

		private void Features_Load(object sender, EventArgs e)
		{
			//Initial setup for "Picturebox Image" tab
			comboBox1.SelectedItem = comboBox1.Items[0];
			string pictureBoxImage = comboBox1.SelectedItem.ToString();
			SetPictureBoxImage(pictureBoxImage);

		}
	}
}
