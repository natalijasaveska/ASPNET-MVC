using Burger_Shop.Models.ViewModels;

namespace Burger_Shop.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        
        public string Address { get; set; }

        public bool IsDelivered { get; set; }

        public List<Burger> Burgers { get; set; }

        public string Location { get; set; }

        public decimal CalculateTotalPrice()
        {
            return Burgers.Sum(x => x.Price);
        }
    }
}

