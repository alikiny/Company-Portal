using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace server.src.Models
{
    public class Company
    {
        [Key]
        public string BusinessId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateOnly RegistrationDate { get; set; }
        public CompanyFormType? CompanyForm { get; set; }
        public string? DetailsUri { get; set; }
        public IEnumerable<CompanyName> Names { get; set; } = null!;
        public IEnumerable<Liquidation>? Liquidations { get; set; }
        [NotMapped]
        public IEnumerable<CompanyName>? AuxiliaryNames
        {
            get => Names.AsQueryable().Where(n => n.Order > 0);
        }
        public IEnumerable<Address>? Addresses { get; set; }
        public IEnumerable<CompanyForm>? CompanyForms { get; set; }
        public IEnumerable<BusinessLine>? BusinessLines { get; set; }
        public IEnumerable<Language>? Languages { get; set; }
        public IEnumerable<RegistedOffice>? RegistedOffices { get; set; }
        public IEnumerable<ContactDetail>? ContactDetails { get; set; }
        public IEnumerable<RegisteredEntry>? RegisteredEntries { get; set; }
        public IEnumerable<BusinessIdChange>? BusinessIdChanges { get; set; }
    }

    public enum Source
    {
        Common,
        Prh,
        Vero,
        Ytj
    }

    public enum CompanyFormType
    {
        OY,
        OYJ,
        OK,
        AOY,
        VOJ
    }
}