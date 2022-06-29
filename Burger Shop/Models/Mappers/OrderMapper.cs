using Burger_Shop.Models.Domain;
using Burger_Shop.Models.ViewModels;

namespace Burger_Shop.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                FullName = order.FullName,
                TotalPrice = order.CalculateTotalPrice()
            };
        }

        public static OrderListViewModel ToOrderListViewModel(this List<Order> orders)
        {
            return new OrderListViewModel
            {
                Orders = orders.Select(x => x.ToOrderViewModel()).ToList()
            };
        }

    }

}
