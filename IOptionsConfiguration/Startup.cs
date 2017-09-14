using IOptionsConfiguration.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace IOptionsConfiguration
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //var messages = new MessagesOptions();
            //Configuration.GetSection("Messages").Bind(messages);

            //var messagesBindByKey = new MessagesOptions();
            //Configuration.Bind("Messages", messagesBindByKey);

            //Uncomment following line for IOptions<MessagesOptions> injection to work
            //inside of PartialSettings Page constructor
            //services.Configure<MessagesOptions>(Configuration.GetSection("Messages"));

            services.Configure<CbnSettings>(Configuration);
            //services.AddScoped(sp => sp.GetService<IOptionsSnapshot<CbnSettings>>().Value);
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}