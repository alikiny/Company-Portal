using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.src.Models
{
    public class BusinessLine : ExtensionWithSourceNLanguage
    {
        public int Order { get; set; }
        public string Name { get; set; } = null!;
    }
}