using ASPNET_MVC_01__Controllers.Database;
using ASPNET_MVC_01__Controllers.Models.Domain;
using ASPNET_MVC_01__Controllers.Models.Mappers;
using ASPNET_MVC_01__Controllers.Models.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_01__Controllers.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> Pizzas = PizzaDb.PIZZAS;
            PizzaListViewModel pizzaListViewModel = Pizzas.ToPizzaListViewModel();
            ViewData["PizzaCount"] = Pizzas.Count;

            return View(pizzaListViewModel);
        }

        [HttpGet]
        [Route("Pizza-details")]
        public IActionResult Details([FromQuery]int id)
        {
            var pizza = PizzaDb.PIZZAS.FirstOrDefault(x => x.Id == id);
            PizzaViewModel pizzaViewModel = pizza.ToPizzaViewModel();
            ViewData["Message"] = "The pizza is great!";

            if (pizza is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(pizzaViewModel);

        }
    }
}
