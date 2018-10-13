using System;
using Blackbird.Domain.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Blackbird.Persistence.Context
{
    public class DbContextInitializer
    {
        public static void Initialize(BlackbirdDbContext context)
        {
            var initializer = new DbContextInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(BlackbirdDbContext context)
        {
            SeedPeople(context);

            SeedCustomers(context);

            SeedProducts(context);

            SeedPurchases(context);
        }

        private void SeedPeople(BlackbirdDbContext context)
        {
            var people = new[]
            {
                new Person("Geovane de Godoi", "geovane.godoi@mail.com", new DateTime(1986, 05, 12)),
                new Person("Vanessa Godoi", "vanessa.godoi@mail.com", new DateTime(1988, 03, 13)),
                new Person("Alice Godoi", "alice.godoi@mail.com", new DateTime(2017, 06, 29))
            };
            context.People.AddRange(people);
            context.SaveChanges();
        }

        private void SeedCustomers(BlackbirdDbContext context)
        {
            var customers = new List<Customer>();
            foreach (var person in context.People)
            {
                customers.Add(new Customer(person.Name, person.Email, person.Birthdate,ToLogin(person.Name), "123456"));
            }
            context.Customers.AddRange(customers.ToArray());
            context.SaveChanges();
        }

        private void SeedProducts(BlackbirdDbContext context)
        {

        }

        private void SeedPurchases(BlackbirdDbContext context)
        {

        }

        private static string ToLogin(string Name)
        {
            var split = Name.Split(" ");
            return $"{split[0]}.{split[split.Count() - 1]}".ToLower();
        }
    }
}
