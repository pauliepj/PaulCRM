namespace PaulCRM.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        public required string BusinessName { get; set; }
        public required string BusinessAddress1 { get; set; }
        public required string BusinessAddress2 { get; set; }
        public required string BusinessPhone { get; set; }
    }
}