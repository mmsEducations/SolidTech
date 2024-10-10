namespace SolidTech.Business.Dtos
{
    public class ProjectWithCategoriesIndexModel
    {
        public List<ProjectCategoryDto>? ProjectCategories { get; set; }
        public List<ProjectDto>? Projects { get; set; }

        public void Create(List<ProjectCategoryDto> projectCategories, List<ProjectDto> projects)
        {
            ProjectCategories = projectCategories;
            Projects = projects;
        }
    }
}
