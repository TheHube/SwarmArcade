using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SwarmArcade.Pages;

public class ClumsyBirdModel : PageModel
{
    private readonly ILogger<ClumsyBirdModel> _logger;

    public ClumsyBirdModel(ILogger<ClumsyBirdModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
