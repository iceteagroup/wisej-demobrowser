using Bogus;
using System;
using System.Collections.Generic;
using Wisej.DemoBrowser.Common;

namespace Wisej.DemoBrowser.DataGridView
{
    public static class DataGenerator
	{
		public static List<Person> GeneratePersonData(int personCount)
		{
			var userIds = 0;
			var earlyBirthday = DateTime.Now.AddYears(-60);


			var faker = new Faker<Person>()
						.CustomInstantiator(f => new Person(userIds++, f.Random.Replace("xxx-xx-####")))
						.RuleFor(u => u.FirstName, f => f.Name.FirstName())
						.RuleFor(u => u.LastName, f => f.Name.LastName())
						.RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
						.RuleFor(u => u.Gender, f => f.PickRandom<PersonGender>())
						.RuleFor(u => u.CartId, f => Guid.NewGuid())
						.RuleFor(u => u.Age, f => f.Random.Number(18, 84))
						.RuleFor(u => u.Address, f => f.Address.FullAddress())
						.RuleFor(u => u.Mail, f => f.Internet.Email())
						.RuleFor(u => u.Birthday, f => f.Date.Between(earlyBirthday, DateTime.Now))
						.RuleFor(u => u.Rating, f => f.Random.Int(1, 5).ToString())
						.RuleFor(u=>u.Avatar,f=> ImageHelper.GetRandomPerson())
						.RuleFor(u => u.AccountActive, f => f.Random.Bool());

			return faker.Generate(personCount);
		}
	}
}