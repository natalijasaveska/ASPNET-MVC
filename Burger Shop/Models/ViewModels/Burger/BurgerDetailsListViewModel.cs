namespace Burger_Shop.Models.ViewModels
{
        public class BurgerDetailsListViewModel
        {
            public List<BurgerDetailsViewModel> Burgers { get; set; }

            public List<IngredientViewModel> Ingredients { get; set; }
        }
}
