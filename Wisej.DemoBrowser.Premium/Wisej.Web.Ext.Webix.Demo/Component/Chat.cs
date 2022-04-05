using System;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
	public partial class Chat : ViewBase
	{
		private void Chat_Load(object sender, EventArgs e)
		{
			this.chat1.Options.chatId = 1;
			this.chat1.Options.token = "eyJhbGciOiJFZERTQSJ9.eyJkZXZpY2UiOjksImlhdCI6MTY0NzAzNDI1OSwiaWQiOjIsInN1YiI6InVzZXIifQ.CfSY1zrzhME3xrLFZE5z0xF4IyW_ChW0E0Qea_B5FKQnrO_yIv_UxOHsfTzX94O3rLo1jXYHgQfJnQINK9DABw";
			this.chat1.Options.url = "https://docs.webix.com/chat-backend/api/v1";//((IWisejHandler)this.chat1).GetServiceURL();
		}

		public Chat()
		{
			InitializeComponent();
		}
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

			this.comboBoxChatType.SelectedIndex = 0;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

			this.chat1.Options.chatType = this.comboBoxChatType.Text;
			this.chat1.Options.files = this.checkBoxAllowFile.Checked;
			this.chat1.Options.compact = this.checkBoxCompact.Checked;

			this.chat1.Update();
        }
    }
}
