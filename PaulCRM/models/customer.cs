namespace PaulCRM.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public required string CustomerFirstName { get; set; }
        public required string CustomerLastName { get; set; }
        public required string CustomerPhone { get; set; }
        public required string CustomerPhoneExtension { get; set; }
        public required int BusinessId { get; set; }
        public required Business Business { get; set; }
    }
}