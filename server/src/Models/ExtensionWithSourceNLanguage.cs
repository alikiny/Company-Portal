namespace server.src.Models
{
    /* properties: id, registrationDate, endDate, version, language, source*/
    public class ExtensionWithSourceNLanguage : BaseModelExtension
    {
        [MaxLength(2, ErrorMessage = "Language code must have 2 characters"), MinLength(2, ErrorMessage = "Language code must have 2 characters")]
        public string Language { get; set; } = null!;
        public Source Source { get; set; }
    }
}