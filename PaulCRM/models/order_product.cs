namespace PaulCRM.Models
{
    public class OrderProduct
    {
        public required int OrderProductId { get; set; }
        public required int ProductId { get; set; }
        public required Product Product { get; set; }
        public required int OrderId { get; set; }
        public required Order Order { get; set; }
        public required int OrderProductQuantity { get; set; }
        public required double ProductQuantityPrice { get; set; }

    }
}