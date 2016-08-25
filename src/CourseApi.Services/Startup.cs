using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApi.FakeRepositories.Implementations;
using CourseApi.FakeRepositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CourseApi.Services
{
    public static class Startup
    {
        public static void Initialize(IServiceCollection services)
        {
            // All singletons because we want them to live for the entire up-time of the API
            // because we are dealing with mock-data, otherwise we would have them as transient objects
            services.AddSingleton<ICourseRepository, CourseRepository>();
            services.AddSingleton<IStudentRepository, StudentRepository>();
            services.AddSingleton<ICourseLinkRepository, CourseLinkRepository>();
        }
    }
}
