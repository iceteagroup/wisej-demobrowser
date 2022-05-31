using System;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.DemoBrowser.PropertyGrid
{
	public partial class PersonCard : UserControl, IWisejHandler
	{
		public Person Person
		{
			get => Person.Instance;
		}

		public PersonCard()
		{
			InitializeComponent();
		}

		private void PersonCard_Load(object sender, EventArgs e)
		{
			lblIssued.Text += DateTime.Now.ToShortDateString();

			lblFirstNameTxt.DataBindings.Add(new Binding("Text", Person, "FirstName"));
			lblLastNameTxt.DataBindings.Add(new Binding("Text", Person, "LastName"));
			lblGenderTxt.DataBindings.Add(new Binding("Text", Person, "Gender"));
			lblAddressTxt.DataBindings.Add(new Binding("Text", Person, "Address"));
			lblID.DataBindings.Add(new Binding("Text", Person, "Id"));
			pnlFavColor.DataBindings.Add(new Binding("BackColor", Person, "FavoriteColor"));
			lblDobTxt.DataBindings.Add(new Binding("Text", Person, "Birthday"));
			pbVip.DataBindings.Add(new Binding("Visible", Person, "IsVip"));

			var postback = $"{Application.StartupUrl}{this.GetPostbackURL()}";
			barcode1.Text = $"{postback}&action=alert";
		}

        #region WisejHandler Implementation

        public bool Compress => false;

		public void ProcessRequest(HttpContext context)
		{
			switch (context.Request["action"])
            {
				case "alert":
					context.Response.StatusCode = 200;
					context.Response.ContentType = "text/html";
					context.Response.Write($"Scanned {Person.FirstName} Successfully!");

					new Toast($"{context.Request.UserHostName} Scanned {Person.FirstName}'s QR Code").Show();
					Application.Update(this);
					break;
            }
		}

		#endregion

	}
}
