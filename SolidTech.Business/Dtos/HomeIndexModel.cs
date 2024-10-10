namespace SolidTech.Business.Dtos
{
    public class HomeIndexModel
    {
        public List<SolutionDto>? Solutions { get; set; }
        public List<ProjectCategoryDto>? ProjectCategories { get; set; }
        public List<ProjectDto>? Projects { get; set; }
        public List<TeamMemberDto>? TeamMembers { get; set; }
        public List<CustomerCommentDto>? CustomerComments { get; set; }

        public void Create(List<SolutionDto> solutions, List<ProjectCategoryDto> projectCategories,
            List<ProjectDto> projects, List<TeamMemberDto> teamMembers, List<CustomerCommentDto> customerComments)
        {
            Solutions = solutions;
            ProjectCategories = projectCategories;
            Projects = projects;
            TeamMembers = teamMembers;
            CustomerComments = customerComments;
        }

    }
}
