using Burger_Shop.Models.Domain;
using Burger_Shop.Models.ViewModels;

namespace Burger_Shop.Models.Mappers
{
    public static class IngredientMapper
    {
        public static IngredientViewModel ToIngredientViewModel(this Ingredient ingredient)
        {
            return new IngredientViewModel
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
            };
        }

        public static IngredientListViewModel ToIngredientListViewModel(this List<Ingredient> ingredients)
        {
            return new IngredientListViewModel
            {
                Ingredients = ingredients.Select(x => x.ToIngredientViewModel()).ToList()
            };
        }
    }
}

