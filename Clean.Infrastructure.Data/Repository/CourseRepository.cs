using Clean.Domain.Interfaces;
using Clean.Domain.Models;
using Clean.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        //atributo que representa la asociasion de agregacion con el context
        private readonly UniversityDbContext universityDbContext;

        public CourseRepository(UniversityDbContext universityDbContext)
        {
            this.universityDbContext = universityDbContext;
        }

        public IEnumerable<Course> GetCourses()
        {
            return universityDbContext.courses;
        }
    }
}
