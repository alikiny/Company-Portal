using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.src.Models;

namespace server.src.Dtos
{
    public class LanguageDto : ExtensionWithSourceNLanguage
    {
        public string Name { get; set; } = null!;
        public int Order { get; set; }
    }
}