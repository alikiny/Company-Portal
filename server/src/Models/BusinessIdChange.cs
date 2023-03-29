using System.Runtime.Serialization;

namespace server.src.Models
{
    public class BusinessIdChange
    {
        public Guid Id { get; set; }
        public Source Source { get; set; }
        public string Description { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string? ChangeDate { get; set; }
        public string OldBusinessId { get; set; } = null!;
        public string NewBusinessId { get; set; } = null!;
        [MaxLength(2, ErrorMessage = "Language code must have 2 characters"), MinLength(2, ErrorMessage = "Language code must have 2 characters")]
        public string Language { get; set; } = null!;
        public Register Register { get; set; }
        public Change Change { get; set; }
    }

    public enum Change
    {
        [EnumMember(Value = "Business ID removal")]
        Removal = 2,

        [EnumMember(Value = "Combining of double IDs")]
        Combine = 3,

        [EnumMember(Value = "ID changed")]
        IDChanged = 5,

        [EnumMember(Value = " Fusion")]
        Fusion = 44,

        [EnumMember(Value = "Operator continuing VAT activities")]
        ContinueVAT = 45,

        [EnumMember(Value = "Relation to predecessor")]
        Predecesssor = 46,

        [EnumMember(Value = "Division")]
        Division = 47,

        [EnumMember(Value = "Bankruptcy relationship")]
        Bankruptcy = 48,

        [EnumMember(Value = " Operations continued by a private trader")]
        PrivateTrader = 49,

        [EnumMember(Value = "Partial division")]
        PartialDivision = 57
    }
}