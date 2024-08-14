using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CrudsitoWeb.Pages
{
    public class VistaEliminar : PageModel
    {
        private readonly ILogger<VistaEliminar> _logger;

        public VistaEliminar(ILogger<VistaEliminar> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}