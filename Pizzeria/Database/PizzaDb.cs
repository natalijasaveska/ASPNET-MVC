using ASPNET_MVC_01__Controllers.Models.Domain;

namespace ASPNET_MVC_01__Controllers.Database
{
    public class PizzaDb
    {

        public static List<Pizza> PIZZAS = new List<Pizza>()
        {
            new Pizza() { Id = 1, Name = "Margherita", Price = 6.5m, IsOnPromotion = false },
            new Pizza() { Id = 2, Name = "Neapolitan", Price = 7m, IsOnPromotion = true },
            new Pizza() { Id = 3, Name = "Pepperoni", Price = 10m, IsOnPromotion = false },
            new Pizza() { Id = 4, Name = "Calzone", Price = 9.5m, IsOnPromotion = true },
            new Pizza() { Id = 5, Name = "Sicilian", Price = 11m, IsOnPromotion = false },
            new Pizza() { Id = 6, Name = "Hawaiian", Price = 12.5m, IsOnPromotion = false }
        };

        public static List<Order> ORDERS = new List<Order>()
        {
            new Order() { Id = 1, CreatedAt = new DateTime(2022,05,06), Pizzas = new List<Pizza>()
                { 
                 PIZZAS.Find(x => x.Id == 5), PIZZAS.Find(x => x.IsOnPromotion == true)
                }
            },

            new Order() { Id = 2, CreatedAt = new DateTime(2022,05,08), Pizzas = new List<Pizza>()
                {
                 PIZZAS.ElementAt(2), PIZZAS.Find(x => x.Price < 7)
                }
            }
        };
    }
}
