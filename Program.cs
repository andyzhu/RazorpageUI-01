using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RazorPageUI.DataContext;
using RazorPageUI.Helper;

namespace RazorPageUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Get the IHost whgich will host this application
            var host = CreateHostBuilder(args).Build();
        
            //Find the service layer within out scope
            using (var scope = host.Services.CreateScope())
            {

                //Get the instance of BoardGamesDBContext in our service layer
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<BoardGamesDbContext>();

                //Call the DatAaGenarator (class/object) to initialize the database
                DataGenerator.Initialize(services);
            }

            host.Run();

        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
