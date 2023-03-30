using server.src.Models;

namespace server.src.Dtos
{
    public class CompanyFormDto : ExtensionWithSourceNLanguage
    {
        public string Name { get; set; } = null!;
        public string? Type { get; set; }
    }
}