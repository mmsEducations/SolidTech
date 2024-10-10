﻿using Microsoft.AspNetCore.Mvc;
using SolidTech.Business.Dtos;
using SolidTech.Business.Interfaces;

namespace SolidTech.Presentation.Controllers
{
    public class SolutionController : Controller
    {
        //Roting mekanizması : Controller/Action->Solution/Index
        private readonly ISolutionService _solutionService;

        public SolutionController(ISolutionService solutionService)
        {
            _solutionService = solutionService;
        }


        public IActionResult Index()
        {
            List<SolutionDto> solutions = _solutionService.GetServices();
            return View(solutions);
        }
    }
}
