using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SwarmArcade.Pages;

public class SwarmModel : PageModel
{
    private readonly ILogger<SwarmModel> _logger;

    public SwarmModel(ILogger<SwarmModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
