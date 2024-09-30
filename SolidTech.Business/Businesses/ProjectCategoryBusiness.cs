﻿using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Businesses
{
    public class ProjectCategoryBusiness : IProjectCategoryBusiness
    {
        private readonly SolidTechContext _context;
        public ProjectCategoryBusiness(SolidTechContext context)
        {
            _context = context;
        }

        public List<ProjectCategory> ProjectCategories()
        {
            return _context.ProjectCategories.ToList();
        }

    }
}
