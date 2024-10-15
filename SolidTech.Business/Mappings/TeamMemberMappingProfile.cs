namespace SolidTech.Business.Mappings
{
    public class TeamMemberMappingProfile : Profile
    {
        public TeamMemberMappingProfile()
        {
            CreateMap<TeamMember, TeamMemberDto>()
                     .ReverseMap();
        }
    }
}
