using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace server.src.Dtos
{
    public class CompanyDto
    {
        public string BusinessId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime? RegistrationDate { get; set; }
        public CompanyFormType? CompanyForm { get; set; }
        public string? DetailsUri { get; set; }
        public IEnumerable<CompanyNameDto> Names { get; set; } = null!;
        public IEnumerable<LiquidationDto>? Liquidations { get; set; }
        [NotMapped]
        public IEnumerable<CompanyNameDto>? AuxiliaryNames { get; set; } = new List<CompanyNameDto>();
        public IEnumerable<AddressDto>? Addresses { get; set; }
        public IEnumerable<CompanyFormDto>? CompanyForms { get; set; }
        public IEnumerable<BusinessLineDto>? BusinessLines { get; set; }
        public IEnumerable<LanguageDto>? Languages { get; set; }
        public IEnumerable<RegistedOfficeDto>? RegistedOffices { get; set; }
        public IEnumerable<ContactDetailDto>? ContactDetails { get; set; }
        public IEnumerable<RegisteredEntryDto>? RegisteredEntries { get; set; }
        public IEnumerable<BusinessIdChangeDto>? BusinessIdChanges { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Source
    {
        Common,
        Prh,
        Vero,
        Ytj
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CompanyFormType
    {
        OY,
        OYJ,
        OK,
        AOY,
        VOJ
    }
}