
namespace SolidTech.Data.Entities
{
    public class ProjectCategory : BaseEntity
    {
        public int ProjectCategoryId { get; set; }
        public required string CategoryName { get; set; }
        public int Order { get; set; }

    }
}
