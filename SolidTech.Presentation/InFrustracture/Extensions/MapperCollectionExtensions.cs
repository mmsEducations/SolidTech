
namespace SolidTech.Presentation.InFrustracture.Extensions
{
    public static class MapperCollectionExtensions
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(SolutionMappingProfile));
            services.AddAutoMapper(typeof(CustomerCommentMappingProfile));
            services.AddAutoMapper(typeof(ProjectMappingProfile));
            services.AddAutoMapper(typeof(ProjectCategoryMappingProfile));
            services.AddAutoMapper(typeof(TeamMemberMappingProfile));
            services.AddAutoMapper(typeof(MessageMappingProfile));

            return services;
        }
    }
}
