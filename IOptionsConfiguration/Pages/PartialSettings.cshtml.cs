using IOptionsConfiguration.Configuration;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;

namespace IOptionsConfiguration.Pages
{
    public class PartialSettings : PageModel
    {
        public PartialSettings(IOptions<MessagesOptions> iOptionsMessages)
        {
            Messages = iOptionsMessages.Value;
        }

        public string MainMessageFromConfig { get; set; }
        public MessagesOptions Messages { get; set; }

        public void OnGet()
        {
        }
    }
}