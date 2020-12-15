using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Boss")]
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
            [FromQuery] ActivityQueryModel query)
        {
            ViewBag.currentFirstNameParam = query.FirstName;
            ViewBag.currentLastNameParam = query.LastName;
            ViewBag.currentFromDateParam = query.FromDate;
            ViewBag.currentToDateParam = query.ToDate;
            ViewBag.currentActivityTypeParam = (int)query.ActivityType;

            var result = await _activityServices.List(query);

            return View(result);
        }
    }
}
