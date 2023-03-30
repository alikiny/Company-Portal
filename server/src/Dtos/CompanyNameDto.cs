namespace server.src.Dtos
{
    public class CompanyNameDto : BaseDtoExtensions
    {
        public int Order { get; set; }
        public string Name { get; set; } = null!;
        public Source Source { get; set; }
    }
}