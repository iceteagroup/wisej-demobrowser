using System;
using System.ComponentModel;
using System.Drawing.Design;
using Wisej.Design;
using Wisej.Web;
namespace Wisej.DemoBrowser.Common.Components
{
	public partial class OverviewDocItem : BaseControl
	{
		public OverviewDocItem()
		{
			InitializeComponent();
		}

		/// <summary>
		/// The title of the doc item.
		/// </summary>
		[DesignerActionList()]
		[Description("The title of the doc item.")]
		public string Title
		{
			get => this.labelItemName.Text;
			set => this.labelItemName.Text = value;
		}

		/// <summary>
		/// The image source of the icon.
		/// </summary>
		[DesignerActionList()]
		[Description("The image source of the icon.")]
		[TypeConverter("Wisej.Design.ImageSourceConverter, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171")]
		[Editor("Wisej.Design.ImageSourceEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
		public string SampleIconSource
		{
			get => this.pictureBoxIcon.ImageSource;
			set => this.pictureBoxIcon.ImageSource = value;
		}

		/// <summary>
		/// The documentation URL for the item.
		/// </summary>
		[DesignerActionList()]
		[Description("The documentation URL for the item.")]
		public string URL
		{
			get => this._url;
			set => this._url = value;
		}
		private string _url = "http://docs.wisej.com";

		private void buttonDocsLink_Click(object sender, EventArgs e)
		{
			Application.Navigate(this.URL, "_blank");
		}
	}
}
