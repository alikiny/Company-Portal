using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.src.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateOnly RegistrationDate { get; set; }
    }
}