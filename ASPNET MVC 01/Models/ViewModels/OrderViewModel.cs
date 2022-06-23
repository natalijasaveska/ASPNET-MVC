using ASPNET_MVC_01__Controllers.Models.Domain;

namespace ASPNET_MVC_01__Controllers.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        
        public DateTime CreatedAt { get; set; }

        public decimal TotalPrice { get; set; }

        public List<Pizza> OrderedPizzas { get; set; }

    }
}
