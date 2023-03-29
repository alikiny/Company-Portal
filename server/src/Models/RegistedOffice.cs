using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.src.Dtos;

namespace server.src.Models
{
    public class RegistedOffice : RegistedOfficeDto
    {
        public Guid Id { get; set; }
    }
}