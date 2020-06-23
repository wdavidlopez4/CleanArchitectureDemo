using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.ViewModels;
using Clean.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.ApplicationCore.Services
{
    public class CourseService : ICourseService
    {
        //atributo que representa la asociacion de agregacio con courseRepository
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public CourseVM GetCourse()
        {
            return new CourseVM()
            {
                Courses = courseRepository.GetCourses()
            };
        }
    }
}
