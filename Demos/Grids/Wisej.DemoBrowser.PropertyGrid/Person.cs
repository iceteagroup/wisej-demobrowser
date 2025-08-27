using Bogus;
using System;
using System.ComponentModel;
using System.Drawing;
using UITypeEditor = Wisej.Web.UITypeEditor;

namespace Wisej.DemoBrowser.PropertyGrid
{
    public class Person
	{
		[Category("Cardholder Properties")]
		[Description("The Cardholder's unique identifier.")]
		public int Id { get; set; }

		[Category("Cardholder Properties")]
		[Description("The Cardholder's first name.")]
		public string FirstName { get; set; }

		[Category("Cardholder Properties")]
		[Description("The Cardholder's last name.")]
		public string LastName { get; set; }

		[Category("Cardholder Properties")]
		[Description("The Cardholder's address.")]
		public string Address { get; set; }

		[Category("Cardholder Properties")]
		[Description("The Cardholder's gender.")]
		public GenderType Gender { get; set; }


		[Category("Cardholder Properties")]
		[Description("The Cardholder's Favorite color.")]
		[Editor(typeof(ColorPicker), typeof(UITypeEditor))]
		public Color FavoriteColor { get; set; }

		[Category("Cardholder Properties")]
		[Description("The Cardholder's Date of birth.")]
		public DateTime Birthday { get; set; }

		[Category("Cardholder Properties")]
		[Description("The Cardholder's VIP status.")]
		public bool IsVIP
		{
			get => _isVip;
			set => _isVip = value;
		}
		private bool _isVip = true;
	
		[Browsable(false)]
		public static Person Instance
		{
			get
			{
				if (_instance != null)
				{
					return _instance;
				}
				else
				{
					var faker = new Faker<Person>()
						.RuleFor(u => u.LastName, f => f.Name.LastName())
						.RuleFor(u => u.Id, f => f.Random.Int(0, 1000000))
						.RuleFor(u => u.FirstName, f => f.Name.FirstName())
						.RuleFor(u => u.Address, f => f.Address.StreetAddress())
						.RuleFor(u => u.Gender, f => f.PickRandom<GenderType>())
						.RuleFor(u => u.Birthday, f => f.Date.Past(18, DateTime.Now))
						.RuleFor(u => u.FavoriteColor, f => Color.FromArgb(f.Random.Byte(), f.Random.Byte(), f.Random.Byte()));
					_instance = faker.Generate();

					return _instance;
				}
			}
		}

		private static Person _instance = null;
	}

	public enum GenderType
	{
		Male,
		Female,
		Other
	}
}