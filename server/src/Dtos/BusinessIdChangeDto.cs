namespace server.src.Dtos
{
    public class BusinessIdChangeDto
    {
        public Source Source { get; set; }
        public string? Description { get; set; }
        public string? Reason { get; set; }
        public string? ChangeDate { get; set; }
        public string? OldBusinessId { get; set; }
        public string? NewBusinessId { get; set; }
        [MaxLength(2, ErrorMessage = "Language code must have 2 characters"), MinLength(2, ErrorMessage = "Language code must have 2 characters")]
        public string? Language { get; set; }
        //public Change Change { get; set; }
        public string? Change { get; set; }
    }

    /* Because of data defect in prh api, we cannot use enum type for Change
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        PartialDivision = 57,

        [EnumMember(Value = "DIF")]
        DIF,
    } */
}