using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Wisej.DemoBrowser.DataGridView
{
	public static class DataGenerator
	{
		public static List<Order> GenerateOrderData(int orderCount)
		{
			var products = new[] {"Product 1", "Product 2", "Product 3", "Product 4"};
			var orderIds = 0;

			var faker = new Faker<Order>()
						.StrictMode(true)
						.RuleFor(o => o.OrderId, f => orderIds++)
						.RuleFor(o => o.Item, f => f.PickRandom(products))
						.RuleFor(o => o.Quantity, f => f.Random.Number(1, 10))
						.RuleFor(o => o.UnitPrice, f=>Decimal.Round(f.Random.Decimal(39.99M,1299.95M),2))
						.RuleFor(o => o.LotNumber, f => f.Random.Number(1, 10));


			return faker.Generate(orderCount);
		}

		public static List<Person> GeneratePersonData(int personCount)
		{
			var userIds = 0;
			var designation = new[]
			{
				"Developer",
				"Manager",
				"CEO",
				"CTO",
				"Designer",
				"Project Manager"
			};

			var faker = new Faker<Person>()
						.CustomInstantiator(f => new Person(userIds++, f.Random.Replace("###-##-####")))
						.RuleFor(u => u.FirstName, f => f.Name.FirstName())
						.RuleFor(u => u.LastName, f => f.Name.LastName())
						.RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
						.RuleFor(u => u.Gender, f => f.PickRandom<PersonGender>())
						.RuleFor(u => u.CartId, f => Guid.NewGuid())
						.RuleFor(u => u.Age, f => f.Random.Number(18, 84))
						.RuleFor(u => u.Address, f => f.Address.FullAddress())
						.RuleFor(u => u.Mail, f => f.Internet.Email())
						.RuleFor(u => u.Designation, f => f.PickRandom<string>(designation))
						.RuleFor(u => u.Rating, f => f.Random.Int(1, 5).ToString())
						.RuleFor(u=>u.Avatar,f=>f.Internet.Avatar())
						.RuleFor(u => u.Progress, f => f.Random.Int(1, 100));

			return faker.Generate(personCount);
		}
	}
}