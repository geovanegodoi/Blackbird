using System;
namespace Blackbird.Infrastructure.ORM
{
    public class DbContextInitializer
    {
        public static void Initialize(BlackbirdDbContext context)
        {

        }

        private void SeedEverything(BlackbirdDbContext context)
        {
            SeedCustomers(context);

            SeedPeople(context);

            SeedProducts(context);

            SeedPurchases(context);
        }

        private void SeedCustomers(BlackbirdDbContext context)
        {

        }

        private void SeedPeople(BlackbirdDbContext context)
        {

        }

        private void SeedProducts(BlackbirdDbContext context)
        {

        }

        private void SeedPurchases(BlackbirdDbContext context)
        {

        }
    }
}
