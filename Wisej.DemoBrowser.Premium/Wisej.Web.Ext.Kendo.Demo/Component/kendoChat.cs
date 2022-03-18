using System;
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

			this.kendoChat1.Instance.typingStart += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Instance.actionClick += new WidgetEventHandler(kendoChat1_actionClick);
			this.kendoChat1.Instance.typingEnd += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Instance.toolClick += new WidgetEventHandler(kendoChat1_WidgetEvent);
			this.kendoChat1.Instance.sendMessage += new WidgetEventHandler(kendoChat1_sendMessage);
			this.kendoChat1.Instance.post += new WidgetEventHandler(kendoChat1_WidgetEvent);
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
			var response = $"{e.Data} is a great choice!";
			
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

		private async void buttonGetUser_Click(object sender, EventArgs e)
		{
			var data = await this.kendoChat1.Instance.getUserAsync();

			AlertBox.Show(data.ToString());
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
	}
}
