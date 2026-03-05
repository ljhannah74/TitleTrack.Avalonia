namespace TitleTrack.Domain.Entities
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Street { get; set; }
        public string? AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string County { get; set; }
        public string PropertyType { get; set; }
    }
}