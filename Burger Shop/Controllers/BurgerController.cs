using Burger_Shop.Database;
using Burger_Shop.Models.Domain;
using Burger_Shop.Models.Mappers;
using Burger_Shop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Burger_Shop.Controllers
{
    public class BurgerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Burger> Burgers = BurgerDatabase.BURGERS;
            BurgerDetailsListViewModel burgerDetailsListViewModel = Burgers.ToBurgerDetailsListViewModel();

            return View(burgerDetailsListViewModel);
        }


        [Route("Details")]
        public IActionResult Details([FromQuery] int id)
        {
            var burger = BurgerDatabase.BURGERS.FirstOrDefault(x => x.Id == id);
            BurgerDetailsViewModel burgerDetailsViewModel = burger.ToBurgerDetailsViewModel();

            if (burger is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(burgerDetailsViewModel);

        }
    }
}
