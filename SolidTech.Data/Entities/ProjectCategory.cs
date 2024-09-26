using System.ComponentModel.DataAnnotations;

namespace SolidTech.Data.Entities
{
    public class ProjectCategory
    {
        [Key]
        public int ProjectCategoryId { get; set; }
        [MaxLength(100)]
        public string CategoryName { get; set; }
        public int Order { get; set; }
        public DateTime CreaDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
