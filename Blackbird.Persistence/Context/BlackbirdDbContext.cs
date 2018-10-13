using System;
using Blackbird.Commom.IoC;
using Blackbird.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blackbird.Persistence.Context
{
    public class BlackbirdDbContext : DbContext
    {
        public static BlackbirdDbContext Create()
        {
            var options = new DbContextOptionsBuilder<BlackbirdDbContext>()
                                .UseInMemoryDatabase("BLACKBIRDDB")
                                .Options;

            return new BlackbirdDbContext(options);
        }

        public BlackbirdDbContext(DbContextOptions<BlackbirdDbContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
