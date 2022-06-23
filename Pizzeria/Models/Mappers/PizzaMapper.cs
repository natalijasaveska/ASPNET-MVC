using ASPNET_MVC_01__Controllers.Models.Domain;
using ASPNET_MVC_01__Controllers.Models.ViewModels;

namespace ASPNET_MVC_01__Controllers.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToPizzaViewModel (this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price
            };
        }

        public static PizzaListViewModel ToPizzaListViewModel (this List<Pizza> pizzas)
        {
            return new PizzaListViewModel
            {
                Pizzas = pizzas.Select(x => x.ToPizzaViewModel()).ToList()
            };
        }
        
        public static PizzaDetailsViewModel ToPizzaDetailsViewModel (this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static PizzaDetailsListViewModel ToPizzaDetailsListViewModel (this List<Pizza> pizzas)
        {
            return new PizzaDetailsListViewModel
            {
                PizzasDetails = pizzas.Select(x => x.ToPizzaDetailsViewModel()).ToList()
            };
        }

    }
}
