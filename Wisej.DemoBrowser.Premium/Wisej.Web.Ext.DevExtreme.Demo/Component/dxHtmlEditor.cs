using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxHtmlEditor : TestBase
	{
		public dxHtmlEditor()
		{
			InitializeComponent();

			this.dxHtmlEditor1.Instance.onValueChanged += new WidgetEventHandler(dxHtmlEditor1_WidgetEvent);
		}

		private void dxHtmlEditor1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxHtmlEditor1.Options.valueType = this.comboBox1.SelectedItem;
			this.dxHtmlEditor1.Options.isValid = this.checkBox1.Checked;
			this.dxHtmlEditor1.Options.toolbar = new
			{
				items = this.checkedListBox1.CheckedItems
			};
			this.dxHtmlEditor1.Options.mediaResizing = new
			{
				enabled = this.checkBox2.Checked
			};

			this.dxHtmlEditor1.Update();
		}

		private void checkedListBox1_AfterItemCheck(object sender, ItemCheckEventArgs e)
		{
			var comboString = "";
			foreach (var checkedItem in checkedListBox1.CheckedItems)
			{
				comboString += $"{checkedItem}, ";
			}
			this.userComboBox1.Text = comboString;
		}

        private void dxHtmlEditor_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;

			this.dxHtmlEditor1.Options = new
			{
				toolbar = new
                {
					items = new object[]
                    {
						"undo",
						"redo",
						"separator",
						new
                        {
							formatName = "size",
							formatValues = new string[]
                            {
								"8pt",
								"10pt",
								"12pt",
								"14pt",
								"18pt",
								"24pt",
								"36pt"
							}
						},
						new
						{
							formatName = "font",
							formatValues = new string[]
							{
								"Arial",
								"Courier New",
								"Georgia",
								"Impact",
								"Lucida Console",
								"Tahoma",
								"Times New Roman",
								"Verdana"
							}
						},
						"separator",
						"bold",
						"italic",
						"strike",
						"underline",
						"separator",
						"alignLeft",
						"alignCenter",
						"alignRight",
						"alignJustify",
						"separator",
						new
						{
							formatName = "header",
							formatValues = new object[]
							{
								false,
								1,
								2,
								3,
								4,
								5
							}
						},
						"separator",
						"orderedList",
						"bulletList",
						"separator",
						"color",
						"background",
						"separator",
						"link",
						"image",
						"separator",
						"clear",
						"codeBlock",
						"blockquote"
					},
					mediaResizing = new
                    {
						enabled = true
                    },
					value = "dxHtmlEditor1"
				}
			};

			this.dxHtmlEditor1.Update();
		}
	}
}
