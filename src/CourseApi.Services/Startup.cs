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
            services.AddSingleton<ICourseRepository, CourseRepository>();
        }
    }
}
