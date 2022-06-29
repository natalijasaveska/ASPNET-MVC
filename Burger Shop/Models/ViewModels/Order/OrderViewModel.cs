using System.ComponentModel.DataAnnotations;

namespace Burger_Shop.Models.ViewModels
{
    public class OrderViewModel
    {

        [Display(Name = "Id of order")]
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }

        [Display(Name = "Burger")]
        public int BurgerId { get; set; }
    }
}
