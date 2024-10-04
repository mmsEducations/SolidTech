using AutoMapper;
using SolidTech.Business.Dtos;
using SolidTech.Data.Entities;

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
