using Microsoft.AspNetCore.Mvc;

namespace Avaliando_Restaurantes.Controllers
{
    public class RestaurantesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
