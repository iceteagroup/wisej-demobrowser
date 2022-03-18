using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class RichTextEditor : Wisej.Web.Ext.Syncfusion2.Demo.Component.TestBase
	{
		public RichTextEditor()
		{
			InitializeComponent();

			this.richTextEditor1.Instance.toolbarClick += new WidgetEventHandler(richTextEditor1_WidgetEvent);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			AlertBox.Show(this.richTextEditor1.Text);
		}

		private void richTextEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void RichTextEditor_Load(object sender, EventArgs e)
		{
			this.richTextEditor1.Text = @"<p>The Rich Text Editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid <a href='https://ej2.syncfusion.com/home/' target='_blank'>HTML markup</a> or <a href='https://ej2.syncfusion.com/home/' target='_blank'>markdown</a> of the content</p>
			<p><b> Key features:</b></p>
				<ul><li><p> Provides &lt;IFRAME&gt; and &lt;DIV&gt; modes </p></li>
				<li><p> Capable of handling markdown editing.</p></li>
				<li><p> Contains a modular library to load the necessary functionality on demand.</p></li>
				<li><p> Provides a fully customizable toolbar.</p></li>
				<li><p> Provides HTML view to edit the source directly for developers.</p></li>
				<li><p> Supports third - party library integration.</p></li>
				<li><p> Allows preview of modified content before saving it.</p></li>
				<li><p> Handles images, hyperlinks, video, hyperlinks, uploads, etc.</p></li>
				</ul>";
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.richTextEditor1.Options.enableTabKey = this.checkBox2.Checked;
			this.richTextEditor1.Options.enableAutoUrl = this.checkBox1.Checked;
			this.richTextEditor1.Options.enableHtmlSanitizer = this.checkBox3.Checked;

			this.richTextEditor1.Update();
		}

		private void richTextEditor1_TextChanged(object sender, EventArgs e)
		{
			AlertBox.Show(
				$"<b>TextChanged</b><br/>{JSON.Stringify(this.richTextEditor1.Text)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
