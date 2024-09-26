﻿
namespace SolidTech.Data.Entities
{
    public class ProjectCategory : BaseEntity
    {
        public int ProjectCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Order { get; set; }
        public DateTime CreaDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
