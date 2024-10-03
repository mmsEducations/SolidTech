using SolidTech.Business.Interfaces;
using SolidTech.Business.Services;

namespace SolidTech.Presentation.InFrustracture.Extensions
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<ISolutionService, SolutionService>();
            services.AddScoped<IProjectCategoryService, ProjectCategoryService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ICustomerCommentService, CustomerCommentService>();
            services.AddScoped<ITeamMemberService, TeamMemberService>();

            return services;
        }

    }
}
