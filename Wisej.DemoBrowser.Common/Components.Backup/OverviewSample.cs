using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using Wisej.Design;
using Wisej.Web;

namespace Wisej.DemoBrowser.Common.Components
{
	public partial class OverviewSample : BaseControl
	{
		public OverviewSample()
		{
			InitializeComponent();
		}

		/// <summary>
		/// The sample icon.
		/// </summary>
		[DesignerActionList()]
		[Description("The sample icon.")]
		public Image SampleImage
		{
			get => this.pictureBoxIcon.Image;
			set => this.pictureBoxIcon.Image = value;
		}

		/// <summary>
		/// The sample icon image source.
		/// </summary>
		[DesignerActionList()]
		[Description("The sample icon.")]
		[TypeConverter("Wisej.Design.ImageSourceConverter, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171")]
		[Editor("Wisej.Design.ImageSourceEditor, Wisej.Framework.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=17bef35e11b84171", typeof(UITypeEditor))]
		public string SampleImageSource
		{
			get => this.pictureBoxIcon.ImageSource;
			set => this.pictureBoxIcon.ImageSource = value;
		}

		/// <summary>
		/// The sample title.
		/// </summary>
		[DesignerActionList()]
		[Description("The sample title.")]
		public string Title
		{
			get => this.labelTitle.Text;
			set => this.labelTitle.Text = value;
		}

		/// <summary>
		/// The sample description.
		/// </summary>
		[DesignerActionList()]
		[Description("The sample description.")]
		public string Description
		{
			get => this.label1Description.Text;
			set => this.label1Description.Text = value;
		}

		private void buttonExplore_Click(object sender, System.EventArgs e)
		{
			var url = (string)this.Tag;
			Application.Navigate(url, "_self");
		}
	}
}
