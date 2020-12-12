using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Common.Enum;
using Team_Todo_Management.IServices;
using Team_Todo_Management.ViewModels;

namespace Team_Todo_Management.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityServices _activityServices;
        private readonly IMapper _mapper;

        public ActivityController(IActivityServices activityServices, IMapper mapper)
        {
            _activityServices = activityServices;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index(
            [FromQuery] string firstName,
            [FromQuery] string lastName,
            [FromQuery] ActivityTypeEnum activityType,
            [FromQuery] int page = 1,
            [FromQuery] int limit = 20)
        {
            var result = await _activityServices
                .List(page, limit);

            return View(result);
        }
    }
}
