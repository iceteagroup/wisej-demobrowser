using System;
using System.Drawing;
using Wisej.DemoBrowser.Common;
using Wisej.Web;

namespace Wisej.DemoBrowser.Signature
{
	public partial class Features : DemoView
	{
		public Features()
		{
			InitializeComponent();
		}

		private void Features_Load(object sender, EventArgs e)
		{

		}

		private async void signature1_SignatureChange(object sender, EventArgs e)
		{
			AlertBox.Show("Signature Changed");

			this.buttonRedo.Enabled = await this.signature1.CanRedoAsync();
			this.buttonUndo.Enabled = await this.signature1.CanUndoAsync();
			this.checkBoxEmpty.Checked = await this.signature1.IsEmptyAsync();
		}

		private void buttonUndo_Click(object sender, EventArgs e)
		{
			this.signature1.Undo();
		}

		private void buttonRedo_Click(object sender, EventArgs e)
		{
			this.signature1.Redo();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.signature1.Clear();
		}

		private void uploadSelectImage_Uploaded(object sender, UploadedEventArgs e)
		{
			var image = new Bitmap(e.Files[0].InputStream);

			this.signature1.Load(image);
		}

		private async void buttonExportImage_Click(object sender, EventArgs e)
		{
			var image = await this.signature1.GetImageAsync();

			this.pictureBox1.Image = image;

			image.Save(Application.MapPath("signature.png"));
		}

		private void textBoxColor_TextChanged(object sender, EventArgs e)
		{
			this.signature1.LineColor = ColorTranslator.FromHtml(textBoxColor.Text);
		}

		private void numericUpDownLineWidth_ValueChanged(object sender, EventArgs e)
		{
			this.signature1.LineWidth = (int)this.numericUpDownLineWidth.Value;
		}
	}
}
		