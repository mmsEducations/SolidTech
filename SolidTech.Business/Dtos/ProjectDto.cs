namespace SolidTech.Business.Dtos
{
    public class ProjectDto
    {
        public int ProjectId { get; set; }
        public int ProjectCategoryId { get; set; }
        public required string Name { get; set; }
        public required string Image { get; set; }
    }

}
