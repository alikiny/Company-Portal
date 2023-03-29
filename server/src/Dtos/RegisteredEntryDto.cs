using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace server.src.Dtos
{
    public class RegisteredEntryDto : BaseDto
    {
        public DateTime? EndDate { get; set; }
        [MaxLength(2, ErrorMessage = "Language code must have 2 characters"), MinLength(2, ErrorMessage = "Language code must have 2 characters")]
        public string Language { get; set; } = null!;
        public Authority Authority { get; set; }
        public Status Status { get; set; }
        public Register Register { get; set; }
        public string Description { get; set; } = null!;
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Authority
    {
        Vero = 1,
        Prh = 2,
        Dvv = 3
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Register
    {
        [EnumMember(Value = "Trade Register")]
        Trade = 1,

        [EnumMember(Value = "Register of Foundations")]
        Foundation,

        [EnumMember(Value = "Register of Associations")]
        Association,

        [EnumMember(Value = "Tax Administration")]
        Tax,

        [EnumMember(Value = "Prepayment Register")]
        Prepayment,

        [EnumMember(Value = "VAT Register")]
        VAT,

        [EnumMember(Value = "Employer Register")]
        Employer = 7,

        [EnumMember(Value = "Register of bodies liable for tax on insurance premiums")]
        Other
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Status
    {
        Common,
        Unregistered,
        Registered
    }
}