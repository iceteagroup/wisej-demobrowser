using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Wisej.DemoBrowser.Bubbles
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Leads { get; set; }
        public int Sales { get; set; }
        public static List<Employee> GetEmployees()
        {

            string[] positions = new[]
            {
                "Sales manager",
                "SVP",
                "Director",
                "Advisor"
            };

            List<Employee> employees;
            Faker<Employee> faker = new Faker<Employee>()
                                    .RuleFor(u => u.Id, () => Guid.NewGuid())
                                    .RuleFor(u => u.Name, f => f.Name.FullName())
                                    .RuleFor(u => u.Position, f => f.PickRandom<string>(positions))
                                    .RuleFor(u => u.Sales, f => f.Random.Int(3,52))
                                    .RuleFor(u => u.Leads, f => Decimal.Round(f.Random.Decimal(1.3M, 3.8M), 3));

            employees = faker.Generate(20);

            return employees;
        }
    }
}
