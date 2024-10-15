
namespace SolidTech.Data.Entities
{
    public class TeamMember : BaseEntity
    {
        public int TeamMemberId { get; set; }
        public required string NameLastname { get; set; }
        public required string Title { get; set; }
        public required string Linkedin { get; set; }
        public required string Image { get; set; }
        public int Order { get; set; }

        //public required string FaceBook { get; set; }
        //public required string Twitter { get; set; }
        //public required string Instagram { get; set; }
    }
}
