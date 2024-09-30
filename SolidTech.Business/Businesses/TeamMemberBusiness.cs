using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Businesses
{
    public class TeamMemberBusiness : ITeamMemberBusiness
    {
        private readonly SolidTechContext _context;
        public TeamMemberBusiness(SolidTechContext context)
        {
            _context = context;
        }

        public List<TeamMember> TeamMemberBusinesss()
        {
            return _context.TeamMembers.ToList();
        }
    }
}
