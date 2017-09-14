using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace IOptionsConfiguration.Pages
{
    public class ConfigInject : PageModel
    {
        public ConfigInject(IConfiguration config)
        {
            CoolestFramework = config["CoolestFramework"];
        }

        public string CoolestFramework { get; set; }

        public void OnGet()
        {
        }
    }
}