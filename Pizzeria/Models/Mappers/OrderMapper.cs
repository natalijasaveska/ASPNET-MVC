using ASPNET_MVC_01__Controllers.Models.Domain;
using ASPNET_MVC_01__Controllers.Models.ViewModels;

namespace ASPNET_MVC_01__Controllers.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                CreatedAt = order.CreatedAt,
                TotalPrice = order.CalculateTotalPrice(),
                OrderedPizzas = order.Pizzas
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
