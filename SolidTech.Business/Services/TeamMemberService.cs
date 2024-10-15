namespace SolidTech.Business.Services
{
    public class TeamMemberService : ITeamMemberService
    {
        private readonly SolidTechContext _context;//DI
        private readonly IMapper _mapper;
        public TeamMemberService(SolidTechContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<TeamMemberDto> TeamMembers()
        {
            List<TeamMember> teamMembers = _context.TeamMembers.ToList();
            List<TeamMemberDto> teamMemberDtos = _mapper.Map<List<TeamMemberDto>>(teamMembers);
            return teamMemberDtos;

        }


    }
}
