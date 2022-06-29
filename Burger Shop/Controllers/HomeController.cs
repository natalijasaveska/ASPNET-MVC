using Burger_Shop.Database;
using Burger_Shop.Models;
using Burger_Shop.Models.Domain;
using Burger_Shop.Models.Mappers;
using Burger_Shop.Models.ViewModels;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;

namespace Burger_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<Burger> Burgers = BurgerDatabase.BURGERS;
            BurgerListViewModel burgerListViewModel = Burgers.ToBurgerListViewModel();

            return View(burgerListViewModel);
        }


        [Route("BurgerDetails")]
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


        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}