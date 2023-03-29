using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.src.Models
{
    public class RegistedOffice : ExtensionWithSourceNLanguage
    {
        public string Name { get; set; } = null!;
        public int Order { get; set; }
    }
}