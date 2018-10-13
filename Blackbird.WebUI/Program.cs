using Blackbird.Persistence.Context;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Blackbird.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DbContextInitializer.Initialize();

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
