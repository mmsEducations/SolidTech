namespace SolidTech.Business.Interfaces
{
    public interface IProjectService
    {
        List<ProjectDto> Projects();
        public List<ProjectDto> GetLastProjects();
    }
}