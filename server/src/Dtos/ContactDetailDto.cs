using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.src.Models;

namespace server.src.Dtos
{
    public class ContactDetailDto : ExtensionWithSourceNLanguage
    {
        public string Value { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}