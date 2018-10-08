using System;
using Blackbird.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blackbird.Infrastructure.ORM
{
    public class BlackbirdDbContext : DbContext
    {
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
