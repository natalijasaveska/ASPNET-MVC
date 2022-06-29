using Burger_Shop.Database;
using Burger_Shop.Models.Domain;
using Burger_Shop.Models.Mappers;
using Burger_Shop.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Burger_Shop.Controllers
{
    public class OrderController : Controller
    {

        public IActionResult Index()
        {
            List<Order> Orders = BurgerDatabase.ORDERS; ;
            OrderListViewModel orderListViewModel = Orders.ToOrderListViewModel();

            return View(orderListViewModel);
        }

        [HttpGet]
        public IActionResult CreateOrder()
        {
            ViewBag.Burgers = BurgerDatabase.BURGERS.Select(x => x.ToBurgerViewModel()).ToList();

            OrderViewModel orderViewModel = new OrderViewModel()
            {
            };

            return View(orderViewModel);
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderViewModel order)
        {
            int id = BurgerDatabase.GetNextOrderId();

            Burger selectedBurger = BurgerDatabase.BURGERS.SingleOrDefault(x => x.Id == order.BurgerId);

            if (selectedBurger is null)
            {
                return NotFound();
            }

            Order newOrder = new Order()
            {
                Id = order.Id,
                FullName = order.FullName,
                Burgers = new List<Burger>()
                {
                   selectedBurger
                }
            };

            BurgerDatabase.ORDERS.Add(newOrder);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Order order = BurgerDatabase.ORDERS.SingleOrDefault(x => x.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order.ToOrderViewModel());
        }

        [HttpPost]
        public IActionResult Edit(int id, OrderViewModel order)
        {
            Order orderToUpdate = BurgerDatabase.ORDERS.SingleOrDefault(x => x.Id == id);

            if (orderToUpdate is null)
            {
                return NotFound();
            }

            orderToUpdate.FullName = order.FullName;

            return View(orderToUpdate.ToOrderViewModel());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Order order = BurgerDatabase.ORDERS.SingleOrDefault(x => x.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            return View(order.ToOrderViewModel());
        }

        [HttpPost]
        public IActionResult Delete(int id, OrderViewModel order)
        {
            Order orderToDelete = BurgerDatabase.ORDERS.SingleOrDefault(x => x.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            BurgerDatabase.ORDERS.Remove(orderToDelete);

            return RedirectToAction("Index");
        }
    }
}

