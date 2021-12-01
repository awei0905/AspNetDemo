using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Retreive server/local IP address
            var feature = HttpContext.Features.Get<IHttpConnectionFeature>();
            LocalIPAddr = feature?.LocalIpAddress?.ToString();

        }
        public string LocalIPAddr { get; private set; }

    }
}