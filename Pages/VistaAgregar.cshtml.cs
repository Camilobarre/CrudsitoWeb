using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudsitoWeb.Pages;

public class VistaAgregarModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public VistaAgregarModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
