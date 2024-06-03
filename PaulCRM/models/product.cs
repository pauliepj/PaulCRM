using System.ComponentModel.DataAnnotations;
namespace PaulCRM.Models
{
    public class Product
    {
        public int ProductId { get; set; }


        [Required(ErrorMessage = "Product name is required.")]

        public required string ProductName { get; set; }


        public required string ProductType { get; set; }


        [Required(ErrorMessage = "Product price is required.")]

        public required double ProductPrice { get; set; }
    }
}