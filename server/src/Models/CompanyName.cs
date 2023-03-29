using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.src.Models
{
    public class CompanyName : BaseModelExtension
    {
        public int Order { get; set; }
        public string Name { get; set; } = null!;
        public Source Source { get; set; }
        public Company Company { get; set; }
    }
}