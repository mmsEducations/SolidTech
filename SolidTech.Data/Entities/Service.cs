
namespace SolidTech.Data.Entities
{
    public class Service : BaseEntity
    {
        public int ServiceId { get; set; }
        public required string Header { get; set; }
        public required string Content { get; set; }
        public required string ImageIcon { get; set; }
    }
}
