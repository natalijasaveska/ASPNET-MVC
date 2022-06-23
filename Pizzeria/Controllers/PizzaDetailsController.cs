using ASPNET_MVC_01__Controllers.Database;
using ASPNET_MVC_01__Controllers.Models.Mappers;
using ASPNET_MVC_01__Controllers.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_01__Controllers.Controllers
{
    public class PizzaDetailsController : Controller
    {
        [HttpGet]
        public IActionResult Index([FromQuery] int id)
        {
            var pizza = PizzaDb.PIZZAS.FirstOrDefault(x => x.Id == id);
            PizzaDetailsViewModel pizzaDetailsViewModel = pizza.ToPizzaDetailsViewModel();
            ViewData["Message"] = "The pizza is great!";

            if (pizza is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(pizzaDetailsViewModel);

        }
    }
}
