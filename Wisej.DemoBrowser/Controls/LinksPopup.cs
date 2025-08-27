using System;
using System.Drawing;
using System.Linq;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.DemoBrowser.Controls
{
	public partial class LinksPopup : Wisej.Web.UserPopup
	{
		public LinksPopup()
		{
			InitializeComponent();
		}

		public void Populate(DynamicObject[] links)
		{
			this.flexLayoutPanel1.Controls.Clear();

			foreach (dynamic link in links) 
			{
				var b = new LinkItem
				{
					Text = link.title 
				};

				if (links.LastOrDefault() == link)
					b.SetLastItem();

				b.Click += (s, e) => Application.Navigate(link.url, "_blank");

				this.flexLayoutPanel1.Controls.Add(b);
			}
		}
	}
}
