using Clean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.ApplicationCore.ViewModels
{
    public class CourseVM
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
