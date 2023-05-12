using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SwarmArcade.Pages;

public class _2048Model : PageModel
{
    private readonly ILogger<_2048Model> _logger;

    public _2048Model(ILogger<_2048Model> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
