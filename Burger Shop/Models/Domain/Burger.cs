namespace Burger_Shop.Models.Domain
{
    public class Burger
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public bool IsVegetarian { get; set; }  

        public bool IsVegan { get; set; }

        public bool HasFries { get; set; }

        public int Rating { get; set; } 

        public string PhotoUrl { get; set; }    

        public int IngredientsCounter()
        {
            return Ingredients.Count();
        }
    }
}
