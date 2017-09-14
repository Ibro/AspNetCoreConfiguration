using IOptionsConfiguration.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace IOptionsConfiguration.Pages
{
    public class Index : PageModel
    {
        public Index(IOptions<CbnSettings> options)
        {
            MainMessageFromConfig = options.Value.MainMessage;
            Messages = options.Value.Messages;
        }

        //// for this to work, uncomment following line in Startup.cs:
        //// -> services.AddScoped(sp => sp.GetService<IOptionsSnapshot<CbnSettings>>().Value);
        //public Index(CbnSettings settings)
        //{
        //    MainMessageFromConfig = settings.MainMessage;
        //    Messages = settings.Messages;
        //}

        public MessagesOptions Messages { get; set; }

        public string MainMessageFromConfig { get; set; }

        public void OnGet()
        {
        }
    }
}