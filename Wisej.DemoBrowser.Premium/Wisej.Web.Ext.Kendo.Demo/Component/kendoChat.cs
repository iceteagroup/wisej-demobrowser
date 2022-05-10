using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Wisej.Web;

namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	public partial class kendoChat : TestBase
	{
		private Random rand = new Random();
		public kendoChat()
		{
			InitializeComponent();

			this.kendoChat1.Instance.onTypingStart += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Instance.onActionClick += new WidgetEventHandler(kendoChat1_actionClick);
			this.kendoChat1.Instance.onTypingEnd += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Instance.onToolClick += new WidgetEventHandler(kendoChat1_toolClick);
			this.kendoChat1.Instance.onSendMessage += new WidgetEventHandler(kendoChat1_sendMessage);
			this.kendoChat1.Instance.onPost += new WidgetEventHandler(kendoChat1_WidgetEvent);
		}

		private void kendoChat1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
					$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
					MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void kendoChat1_sendMessage(object sender, WidgetEventArgs e)
		{
			var response = $"{e.Data.text} is a great choice!";
			
			Application.StartTask(() => {

				this.kendoChat1.Instance.renderMessage(new
				{
					type = "typing"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);

				Thread.Sleep(1000);

				this.kendoChat1.Instance.renderMessage(new
				{
					type = "text",
					text = response
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);
			});
		}

        private void kendoChat1_toolClick(object sender, WidgetEventArgs e)
        {
			this.upload1.UploadFiles();
        }

		private void kendoChat1_actionClick(object sender, WidgetEventArgs e)
		{
			var message = e.Data;

			var response = $"{message} is a great pick!";

			Application.StartTask(() => {

				this.kendoChat1.Instance.renderMessage(new
				{
					type = "typing"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);

				Thread.Sleep(1000);

				this.kendoChat1.Instance.renderMessage(new
				{
					type = "text",
					text = response
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);
			});
		}

		private void kendoChat_Load(object sender, EventArgs e)
		{
			Application.StartTask(() => {

				this.kendoChat1.Instance.renderMessage(new
				{
					type = "typing"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				Application.Update(this);

				Thread.Sleep(1000);

				this.kendoChat1.Instance.renderMessage(new
				{
					type = "text",
					text = "Where would you like to go?"
				}, new
				{
					id = 2,
					name = "Wisej Chat Bot",
					iconUrl = "Images/Chat/ANTON.jpg"
				});
				this.kendoChat1.Instance.renderSuggestedActions(new[] {
					new {
						title = "Chicago",
						value = "Chicago"
					}, 
					new
					{
						title = "New York City",
						value = "NYC"
					},
					new {
						title = "Atlanta",
						value = "Atlanta"
					},
					new
					{
						title = "Los Angeles",
						value = "Los Angeles"
					}
				});
				Application.Update(this);
			});
		}

		private void buttonApplyColor_Click(object sender, EventArgs e)
		{
			if (this.colorDialog1.ShowDialog() == DialogResult.OK)
				this.kendoChat1.Call("applyColor", this.colorDialog1.Color);
		}

		private void buttonClearChat_Click(object sender, EventArgs e)
		{
			this.kendoChat1.Call("reset");
		}

        private void buttonPost_Click(object sender, EventArgs e)
        {
			this.kendoChat1.Instance.postMessage(this.textBoxMessage.Text);
		}

        private void upload1_Uploaded(object sender, UploadedEventArgs e)
        {
			var attachments = new List<dynamic>();

			for (var i = 0; i < e.Files.Count; i++)
            {
				var file = e.Files[i];
				var contentType = file.ContentType;

				switch (contentType)
                {
					case "image/png":
					case "image/jpg":
					case "image/jpeg":
						using (var ms = new MemoryStream())
                        {
							file.InputStream.CopyTo(ms);
							ms.Position = 0;

							var base64 = Convert.ToBase64String(ms.ToArray());

							attachments.Add(new
							{
								contentType = "heroCard",
								content = new
								{
									images = new[]
									{
										new {
											alt = file.FileName,
											url = $"data:{contentType};base64,{base64}",
										}
									},
									title = file.FileName,
									subtitle = $"{file.ContentLength} bytes"
								}
							});
                        }
						break;

					default:
						AlertBox.Show($"Unsupported file {file.FileName}");
						break;
                }
            }

			this.kendoChat1.Instance.renderAttachments(new
			{
				attachments = attachments,
				attachmentLayout = "carousel"
			});
		}
    }
}
