using System;
using Blackbird.Commom.IoC;
using Blackbird.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blackbird.Persistence.ORM
{
    public class BlackbirdDbContext : DbContext
    {
        public static BlackbirdDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<BlackbirdDbContext>()
                                .UseInMemoryDatabase("BLACKBIRDDB")
                                .Options;

            return new BlackbirdDbContext(options);
        }

        public BlackbirdDbContext(DbContextOptions<BlackbirdDbContext> options)
            : base(options)
        {
            DbContextInitializer.Initialize(this);
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
