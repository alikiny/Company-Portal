using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using server.src.Dtos;

namespace server.src.Models
{
    public class BusinessIdChange : BusinessIdChangeDto
    {
        public Guid Id { get; set; }
    }
}