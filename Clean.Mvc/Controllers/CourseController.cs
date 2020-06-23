using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Mvc.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            CourseVM courseVM = courseService.GetCourse();
            return View(courseVM);
        }
    }
}
