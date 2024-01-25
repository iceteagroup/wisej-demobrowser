using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using Wisej.Web;
using Wisej.Web.Ext.ChatControl;

namespace Wisej.DemoBrowser.ChatControl.Controls
{
	/// <summary>
	/// A simple message control for displaying links.
	/// </summary>
	public partial class LinkMessageControl : MessageControl
	{

		private static string LINKPREVIEW_API_KEY = File.ReadAllText(Application.MapPath("LinkPreview.lic"));


		#region Constructors

		public LinkMessageControl() 
		{
			InitializeComponent();
		}

		public LinkMessageControl(string link, string text=null)
		{
			InitializeComponent();

			this.Text = text;
			this.Link = link;
			this.labelLinkName.Text = text ?? link;
			this.pictureBoxPreview.SizeMode = PictureBoxSizeMode.Cover;
			this.ImageSource = $"https://api.linkpreview.net/?key={LINKPREVIEW_API_KEY}&q={link}";

			LoadPreview();
		}

		#endregion

		#region Event Handler

		private void LinkMessageControl_Click(object sender, EventArgs e)
		{
			if (this.AutoOpen)
				Application.Navigate(this.Link, this.Target);
		}

		#endregion

		#region Properties

		public string Text;

		public string Link;

		public string ImageSource;

		public Image Image;

		/// <summary>
		/// Gets or sets whether links are automatically opened when clicked.
		/// </summary>
		public bool AutoOpen
		{
			get
			{
				return this._autoOpen;
			}
			set
			{
				if (this._autoOpen != value) 
				{
					this._autoOpen = value;
				}
			}
		}
		private bool _autoOpen = true;

		/// <summary>
		/// Gets or sets the navigation target.
		/// </summary>
		public string Target
		{
			get
			{
				return this._target;
			}
			set
			{
				if (this._target != value) 
				{
					this._target = value;
				}
			}
		}
		private string _target = "_blank";



		#endregion

		#region Methods

		private async void LoadPreview()
		{
			try
			{
				var client = new HttpClient();
				var response = await client.GetAsync(this.ImageSource);
				response.EnsureSuccessStatusCode();

				string text = await response.Content.ReadAsStringAsync();

				// Parse the JSON response
				var data = JSON.Parse(text);
				var image = data.image;
				this.pictureBoxPreview.ImageSource = image;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
		}

		#endregion

	}
}
