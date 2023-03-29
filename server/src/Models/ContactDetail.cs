using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.src.Models
{
    public class ContactDetail : ExtensionWithSourceNLanguage
    {
        public string Value { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}