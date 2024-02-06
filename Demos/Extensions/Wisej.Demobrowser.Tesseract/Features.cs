using System;
using System.Drawing;
using System.Linq;
using Wisej.Core;
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
                pictureBox_picturebox.Image = imageFromStream;
            }
        }

        private void Features_Load(object sender, EventArgs e)
        {
            //Initial setup for "Picturebox Image" tab
            comboBox_picturebox.SelectedItem = comboBox_picturebox.Items[0];
            string pictureBoxImage = comboBox_picturebox.SelectedItem.ToString();
            SetPictureBoxImage(pictureBoxImage);
        }

        //Note that this method must be async so that we can call ScanImageAsync
        private async void buttonScan_url_Click(object sender, EventArgs e)
        {
            var scannedText = await tesseract1.ScanImageAsync(textBox_url.Text);
            textBox_url2.Text = scannedText.Text;
            AlertBox.Show(scannedText.Text);
            //AlertBox.Show(scannedText.Confidence.ToString());
            //AlertBox.Show(scannedText.Words[1]);
        }

        private void LoadImage(HttpPostedFile file)
        {
            this.upload1.Value = file.FileName;
            pictureBoxUploadedImage.Image = new Bitmap(Image.FromStream(file.InputStream));
        }

        private void tesseract1_TextRecognized(object sender, Ext.Tesseract.TextRecognizedEventArgs e)
        {
            AlertBox.Show("Text recognized from camera");
        }

		private void comboBox_picturebox_SelectedItemChanged_1(object sender, EventArgs e)
		{
			string pictureBoxImage = comboBox_picturebox.SelectedItem.ToString();
			SetPictureBoxImage(pictureBoxImage);
		}

		private async void button_upload_Click(object sender, EventArgs e)
		{
			if (pictureBoxUploadedImage.Image != null)
			{
				var scannedText = await tesseract1.ScanImageAsync(pictureBoxUploadedImage.Image);
				AlertBox.Show(scannedText.Text);
				textBox3.Text = scannedText.Text;
			}
			else
			{
				AlertBox.Show("Please upload an image");
			}
		}

		private void upload1_Uploaded_1(object sender, UploadedEventArgs e)
		{
			if (e.Files.Count == 0)
				return;

			LoadImage(e.Files[0]);
		}

		//Note that this method must be async so that we can call ScanImageAsync
		private async void buttonScan_picturebox_Click(object sender, EventArgs e)
		{
			var scannedText = await tesseract1.ScanImageAsync(pictureBox_picturebox.Image);
			AlertBox.Show(scannedText.Text);
			textBox_picturebox.Text = scannedText.Text;
		}
	}
}