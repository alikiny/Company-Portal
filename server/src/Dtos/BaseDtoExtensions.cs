namespace server.src.Dtos
{
    public class BaseDtoExtensions : BaseDto
    {
        public DateTime? EndDate { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Version must be greater than or equal to {1}.")]
        public int? Version { get; set; }
    }
}