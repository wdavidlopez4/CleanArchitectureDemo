using Clean.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Domain.Interfaces
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> GetCourses();
    }
}
