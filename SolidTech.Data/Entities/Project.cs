
namespace SolidTech.Data.Entities
{
    public class Project : BaseEntity
    {
        public int ProjectId { get; set; }
        public int ProjectCategoryId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public virtual ProjectCategory ProjectCategory { get; set; }
    }

}
