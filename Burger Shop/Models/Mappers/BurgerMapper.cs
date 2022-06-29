using Burger_Shop.Models.Domain;
using Burger_Shop.Models.ViewModels;

namespace Burger_Shop.Models.Mappers
{
    public static class BurgerMapper
    {
        public static BurgerViewModel ToBurgerViewModel(this Burger burger)
        {
            return new BurgerViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Rating = burger.Rating,
                Price = burger.Price            };
        }

        public static BurgerDetailsViewModel ToBurgerDetailsViewModel(this Burger burger)
        {
            return new BurgerDetailsViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                Ingredients = burger.Ingredients,
                IsVegetarian = burger.IsVegetarian,
                IsVegan = burger.IsVegan,
                HasFries = burger.HasFries,
                Rating = burger.Rating,
                PhotoUrl = burger.PhotoUrl
            };
        }

        public static BurgerListViewModel ToBurgerListViewModel(this List<Burger> burgers)
        {
            return new BurgerListViewModel
            {
                Burgers = burgers.Select(x => x.ToBurgerViewModel()).ToList()
            };
        }

        public static BurgerDetailsListViewModel ToBurgerDetailsListViewModel(this List<Burger> burgers)
        {
            return new BurgerDetailsListViewModel
            {
                Burgers = burgers.Select(x => x.ToBurgerDetailsViewModel()).ToList()
            };
        }
    }
}
