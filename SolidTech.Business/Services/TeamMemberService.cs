using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Services
{
    public class TeamMemberService : ITeamMemberService
    {
        private readonly SolidTechContext _context;
        public TeamMemberService(SolidTechContext context)
        {
            _context = context;
        }

        public List<TeamMember> TeamMemberBusinesss()
        {
            return _context.TeamMembers.ToList();
        }
    }
}
