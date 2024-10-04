namespace SolidTech.Business.Dtos
{
    public class TeamMemberDto
    {
        public int TeamMemberId { get; set; }
        public required string NameLastname { get; set; }
        public required string Title { get; set; }
        public required string Linkedin { get; set; }
        public required string Image { get; set; }
    }

}
