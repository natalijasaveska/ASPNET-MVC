using ASPNET_MVC_01__Controllers.Database;
using ASPNET_MVC_01__Controllers.Models.Domain;
using ASPNET_MVC_01__Controllers.Models.Mappers;
using ASPNET_MVC_01__Controllers.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_MVC_01__Controllers.Controllers
{
    [Route("Order")]
    public class OrderController : Controller
    {
        [HttpGet]
        [Route("ListOrders")]
        public IActionResult Index()
        {
            List<Order> Orders = PizzaDb.ORDERS;
            OrderListViewModel orderListViewModel = Orders.ToOrderListViewModel();

            return View(orderListViewModel);
        }

        [HttpGet]
        [Route("jsonData")]
        public IActionResult JsonData()
        {
            List<Pizza> pizzas = PizzaDb.PIZZAS;
            return Json(pizzas);
        }
    }
}
