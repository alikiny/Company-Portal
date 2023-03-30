using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.src.Models;

namespace server.src.Dtos
{
    public class LiquidationDto : ExtensionWithSourceNLanguage
    {
        public string? Name { get; set; }
        public string Type { get; set; } = null!;
    }
}