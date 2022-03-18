using System;
using System.Drawing.Imaging;
using System.IO;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class Signature : TestBase
	{
		public Signature()
		{
			InitializeComponent();

			this.signature1.Instance.change += new WidgetEventHandler(signature1_WidgetEvent);
		}

		private void signature1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUndo_Click(object sender, EventArgs e)
		{
			this.signature1.Instance.undo();
		}

		private void buttonRedo_Click(object sender, EventArgs e)
		{
			this.signature1.Instance.redo();
		}

		private async void buttonSave_Click(object sender, EventArgs e)
		{
			var image = await this.signature1.GetSignatureAsync();
			using (var ms = new MemoryStream())
			{
				image.Save(ms, ImageFormat.Png);
				ms.Position = 0;

				Application.Download(ms, "Signature.png");
			}
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			this.signature1.Instance.clear();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.signature1.Instance.draw(this.textBoxName.Text);
		}
	}
}
