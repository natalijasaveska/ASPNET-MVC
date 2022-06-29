using Burger_Shop.Models.Domain;

namespace Burger_Shop.Models.ViewModels
{
    public class BurgerDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool IsVegetarian { get; set; }

        public bool IsVegan { get; set; }

        public bool HasFries { get; set; }

        public int Rating { get; set; }

        public string PhotoUrl { get; set; }
        
        public List<Ingredient> Ingredients { get; set; }
    }
}
