namespace SolidTech.Data.Entities
{
    public class Project : BaseEntity
    {
        public int ProjectId { get; set; }
        public int ProjectCategoryId { get; set; }

        public required string Name { get; set; }
        public required string Image { get; set; }
        public int Order { get; set; }

        public virtual ProjectCategory? ProjectCategory { get; set; } //Navigation Property
    }

}
/*
    
  ProjectCategories
  ProjectCategoryId ProjectCategoryName
  1                 Web
  2                 Mobil

  Projects
  ProjectId  Name                ProjectCategoryId
  1          Online E-commerce   1
 
 */