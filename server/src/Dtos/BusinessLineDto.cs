using server.src.Models;

namespace server.src.Dtos
{
    public class BusinessLineDto : ExtensionWithSourceNLanguage
    {
        public int Order { get; set; }
        public string Name { get; set; } = null!;
    }
}