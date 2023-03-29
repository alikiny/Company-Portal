namespace server.src.Models
{
    /* properties: id, registrationDate, endDate, version*/
    public class BaseModelExtension : BaseModel
    {
        public DateTime? EndDate { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Version must be greater than or equal to {1}.")]
        public int Version { get; set; }
    }
}