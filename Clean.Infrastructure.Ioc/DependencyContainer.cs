using Clean.ApplicationCore.Interfaces;
using Clean.ApplicationCore.Services;
using Clean.Domain.Interfaces;
using Clean.Infrastructure.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clean.Infrastructure.Ioc
{
    public class DependencyContainer
    {
        //registra los servicios
        public static void RegisterServices(IServiceCollection services)
        {
            //Application core
            services.AddScoped<ICourseService, CourseService>();

            //Infrastructure data
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
