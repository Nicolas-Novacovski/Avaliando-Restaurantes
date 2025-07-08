using System.Diagnostics;
using Avaliando_Restaurantes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Avaliando_Restaurantes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
