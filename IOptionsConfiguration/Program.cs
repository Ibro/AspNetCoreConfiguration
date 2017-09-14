using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace IOptionsConfiguration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost
                .CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(
                    (WebHostBuilderContext context, IConfigurationBuilder builder) =>
                    {
                        builder.Sources.Clear();

                        //builder
                        //    .AddEnvironmentVariables()
                        //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                        builder
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .AddEnvironmentVariables();

                    })
                .UseStartup<Startup>()
                .Build();
        }
    }
}