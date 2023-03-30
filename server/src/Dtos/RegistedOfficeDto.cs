using server.src.Models;

namespace server.src.Dtos
{
    public class RegistedOfficeDto : ExtensionWithSourceNLanguage
    {
        public string Name { get; set; } = null!;
        public int Order { get; set; }
    }
}