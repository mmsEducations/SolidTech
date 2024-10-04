namespace SolidTech.Business.Dtos
{
    public class SolutionDto
    {
        public int SolutionId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string ImageIcon { get; set; }
        public int Order { get; set; }
    }
}
