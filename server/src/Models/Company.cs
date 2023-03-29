using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using server.src.Dtos;

namespace server.src.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string BusinessId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? RegistrationDate { get; set; }
        public CompanyFormType? CompanyForm { get; set; }
        public string? DetailsUri { get; set; }
        public IEnumerable<CompanyName> Names { get; set; } = null!;
        public IEnumerable<Liquidation>? Liquidations { get; set; }
        [NotMapped]
        public IEnumerable<CompanyName>? AuxiliaryNames { get; set; } = new List<CompanyName>();
        public IEnumerable<Address>? Addresses { get; set; }
        public IEnumerable<CompanyForm>? CompanyForms { get; set; }
        public IEnumerable<BusinessLine>? BusinessLines { get; set; }
        public IEnumerable<Language>? Languages { get; set; }
        public IEnumerable<RegistedOffice>? RegistedOffices { get; set; }
        public IEnumerable<ContactDetail>? ContactDetails { get; set; }
        public IEnumerable<RegisteredEntry>? RegisteredEntries { get; set; }
        public IEnumerable<BusinessIdChange>? BusinessIdChanges { get; set; }
    }

   
}