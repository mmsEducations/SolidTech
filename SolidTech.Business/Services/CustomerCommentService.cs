using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Services
{
    public class CustomerCommentService : ICustomerCommentService
    {
        private readonly SolidTechContext _context;
        public CustomerCommentService(SolidTechContext context)
        {
            _context = context;
        }

        public List<CustomerComment> CustomerComments()
        {
            return _context.CustomerComments.ToList();
        }
    }
}
