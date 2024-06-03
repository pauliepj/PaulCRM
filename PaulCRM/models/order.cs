namespace PaulCRM.Models
{
    public class Order
    {
        public required int OrderId { get; set; }
        public string? OrderType { get; set; }
        public required DateTime OrderDate { get; set; }
        public required double OrderSubtotal { get; set; }
        public required double OrderTotal { get; set; }
        public required string OrderBillingAddress { get; set; }
        public required string OrderShippingAddress { get; set; }
        public required string OrderStatus{ get; set; }
        public required int BusinessId { get; set; }
        public required Business Business { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}