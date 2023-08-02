namespace MambuStudy.Domain.Models
{
    public class Address
    {
        public string? EncodedKey { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Region { get; set; }
        public string? Postcode { get; set; }
        public int? IndexInList { get; set; }
        public double? Latitude { get; set; }
        public string? Line1 { get; set; }
        public string? Line2 { get; set; }
        public double? Longitude { get; set; }
        public string? ParentKey { get; set; }
    }
}
