using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using Wisej.Web;

namespace Wisej.DemoBrowser.PropertyGrid
{
	public class Person
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
		public GenderType Gender { get; set; }

		public Color FavoriteColor { get; set; }
		public DateTime Dob { get; set; }

		public bool IsVIP
		{
			get => _isVip;
			set => _isVip = value;
		}

		[Browsable(false)]
		public string Details
		{
			get
			{
				if (_instance == null) throw new NullReferenceException();
				var sb = new StringBuilder();

				sb.Append($"ID: {Id}");
				sb.Append(Environment.NewLine);
				sb.Append($"First name: {FirstName}");
				sb.Append(Environment.NewLine);
				sb.Append($"Last name: {LastName}");
				sb.Append(Environment.NewLine);
				sb.Append($"Gender: {Enum.GetName(typeof(GenderType), Gender)}");
				sb.Append(Environment.NewLine);
				sb.Append($"Address: {Address}");

				return sb.ToString();
			}
		}
	


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
								.RuleFor(u => u.Id, f => Guid.NewGuid())
								.RuleFor(u => u.FirstName, f => f.Name.FirstName())
								.RuleFor(u => u.LastName, f => f.Name.LastName())
								.RuleFor(u => u.Address, f => f.Address.StreetAddress())
								.RuleFor(u => u.Gender, f => f.PickRandom<GenderType>())
								.RuleFor(u => u.FavoriteColor, f => Color.FromArgb(f.Random.Byte(), f.Random.Byte(), f.Random.Byte()))
								.RuleFor(u => u.Dob, f => f.Date.Past(18, DateTime.Now));
					_instance = faker.Generate();

					return _instance;
				}
			}
		}

		public override string ToString()
		{
			return this.Details;
		}

		private bool _isVip = true;
		private static Person _instance = null;
	}


	public enum GenderType
	{
		Male,
		Female,
		Other
	}
}