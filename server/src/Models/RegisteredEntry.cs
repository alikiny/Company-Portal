using System.Runtime.Serialization;

namespace server.src.Models
{
    public class RegisteredEntry : BaseModel
    {
        public DateTime? EndDate { get; set; }
        [MaxLength(2, ErrorMessage = "Language code must have 2 characters"), MinLength(2, ErrorMessage = "Language code must have 2 characters")]
        public string Language { get; set; } = null!;
        public Authority Authority { get; set; }
        public Status Status { get; set; }
        public Register Register { get; set; }
        public string Description { get; set; } = null!;
    }

    public enum Authority
    {
        Vero = 1,
        Prh = 2,
        Dvv = 3
    }

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

    public enum Status
    {
        Common,
        Unregistered,
        Registered
    }
}