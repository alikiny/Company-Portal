using server.src.Dtos;

namespace server.src.Models
{
    /* properties: registrationDate, endDate, version, language, source*/
    public class ExtensionWithSourceNLanguage : BaseDtoExtensions
    {
        [MaxLength(2, ErrorMessage = "Language code must have 2 characters"), MinLength(2, ErrorMessage = "Language code must have 2 characters")]
        public string Language { get; set; } = null!;
        public Source Source { get; set; }
    }
}