using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PieShop.Models;
using System;
using Microsoft.AspNetCore;

namespace PieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);

            // Initializing the DB 
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    DbInitializer.Seed(services); 
                }
                catch (Exception e)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "An error occurred sedding the DB");
                }
            }

            host.Run(); // Original syntax
        }

        public static IWebHost BuildWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
               .UseKestrel()
               .UseContentRoot(Directory.GetCurrentDirectory()) // Getting the wwwroot directory
               .UseStartup<Startup>()
               .Build();
    }
}
