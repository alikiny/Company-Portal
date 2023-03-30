using System;
using server.src.Models;

namespace server.src.Dtos
{
    public class LiquidationDto : ExtensionWithSourceNLanguage
    {
        public string? Name { get; set; }
        public string Type { get; set; } = null!;
    }
}