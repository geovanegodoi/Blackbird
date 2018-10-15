using System;
using Blackbird.Domain.Entities;
using System.Linq;
using System.Collections.Generic;

namespace Blackbird.Persistence.Context
{
    public class DbContextInitializer
    {
        public static void Initialize()
        {
            var initializer = new DbContextInitializer();
            initializer.SeedEverything(BlackbirdDbContext.Create());
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
            if (context.Customers.Any())
            {
                return;
            }
            var customers = new List<Customer>();
            foreach (var person in context.People)
            {
                customers.Add(new Customer(person.Name, person.Email, person.Birthdate,ToLogin(person.Name), "123456"));
            }
            context.Customers.AddRange(customers);
            context.SaveChanges();
        }

        private void SeedProducts(BlackbirdDbContext context)
        {
            if (context.Products.Any())
            {
                return;
            }
            var codes = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", 
                                       "I", "J", "K", "L", "M", "N", "O", "P", 
                                       "Q", "R", "S", "T", "U", "W", "X", "Y", "Z" };
            var products = new List<Product>();
            foreach (var code in codes)
            {
                products.Add(new Product($"Product {code}", $"This is the description of the product {code}"));
            }
            context.Products.AddRange(products);
            context.SaveChanges();
        }

        private void SeedPurchases(BlackbirdDbContext context)
        {
            if (context.Purchases.Any())
            {
                return;
            }
        }

        private static string ToLogin(string Name)
        {
            var split = Name.Split(" ");
            return $"{split[0]}.{split[split.Count() - 1]}".ToLower();
        }
    }
}
