using System;
using Wisej.Web;
using static Wisej.Web.Shape;

namespace Wisej.DemoBrowser.Controls
{
	public partial class LinkItem : Web.Button
	{
		public LinkItem()
		{
			InitializeComponent();
		}

		internal void SetLastItem()
		{
			this.CssStyle = "border-radius: 0px;";
		}
	}
}
