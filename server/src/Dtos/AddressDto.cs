namespace server.src.Dtos
{
    public class AddressDto : BaseDtoExtensions
    {
        public string? CareOf { get; set; }
        public string? PostCode { get; set; }
        public string? City { get; set; }
        public string? Languague { get; set; }
        public string? Country { get; set; }
        public AddressType Type { get; set; }
    }

    public enum AddressType
    {
        StreetAddress = 1,
        PostalAdress = 2
    }
}