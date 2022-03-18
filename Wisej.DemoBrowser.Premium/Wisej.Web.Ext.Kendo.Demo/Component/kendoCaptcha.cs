using System;
using System.Drawing.Imaging;
using System.IO;
using Telerik.Web.Captcha;
using Wisej.Core;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoCaptcha : TestBase
	{
		public kendoCaptcha()
		{
			InitializeComponent();

			this.kendoCaptcha1.Instance.change += new WidgetEventHandler(kendoCaptcha1_WidgetEvent);
		}

		/// <summary>
		/// Process incoming data requests from the client.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void kendoCaptcha1_WebRequest(object sender, WebRequestEventArgs e)
		{
			switch (e.Request["action"])
			{
				case "handler":
					e.Response.ContentType = "application/json";
					e.Response.Write(ProcessHandler());
					break;

				case "image":
					e.Response.BinaryWrite(GetImage(e.Request["captchaId"]));
					break;

				case "validationHandler":
					e.Response.ContentType = "application/json";
					e.Response.Write(ProcessValidation(e.Request["captchaId"], e.Request["captcha"]));
					break;
			}
		}

		/// <summary>
		/// Generate and return a new Captcha.
		/// </summary>
		/// <returns></returns>
		private object ProcessHandler()
		{
			CaptchaImage newCaptcha = CaptchaHelper.GetNewCaptcha();
			Application.Session["captcha" + newCaptcha.UniqueId] = newCaptcha;
			
			return new
			{
				captcha = $"./{((Widget)this.kendoCaptcha1).GetServiceURL()}?action=image&captchaId={newCaptcha.UniqueId}",
				captchaId = newCaptcha.UniqueId
			}.ToJSON();
		}

		/// <summary>
		/// Generate and return the Captcha image.
		/// </summary>
		/// <param name="captchaId"></param>
		/// <returns></returns>
		private byte[] GetImage(string captchaId)
		{
			CaptchaImage captcha = (CaptchaImage)Application.Session["captcha" + captchaId];
			var image = CaptchaHelper.RenderCaptcha(captcha);

			using (MemoryStream ms = new MemoryStream())
			{
				image.Save(ms, ImageFormat.Png);
				return ms.ToArray();
			}
		}

		/// <summary>
		/// Validate the Captcha input and display the corresponding AlertBox.
		/// </summary>
		/// <param name="captchaId"></param>
		/// <param name="captcha"></param>
		/// <returns></returns>
		private object ProcessValidation(string captchaId, string captcha)
		{
			CaptchaImage captchaImage = Application.Session["captcha" + captchaId];

			var success = CaptchaHelper.Validate(captchaImage, captcha);

			return success.ToString().ToLower();
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.kendoCaptcha1.Update();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			var success = await this.kendoCaptcha1.Validate();
			
			if (success)
				AlertBox.Show("Success!", MessageBoxIcon.Information);
			else
				AlertBox.Show("Failed.", MessageBoxIcon.Error);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.kendoCaptcha1.Instance.reset();
		}

		private void kendoCaptcha1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
