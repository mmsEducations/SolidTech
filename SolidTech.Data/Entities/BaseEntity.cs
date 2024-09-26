
namespace SolidTech.Data.Entities
{
    public class BaseEntity
    {
        public int Order { get; set; }
        public DateTime CreaDate { get; set; }
        public bool IsDeleted { get; set; }
    }

}
