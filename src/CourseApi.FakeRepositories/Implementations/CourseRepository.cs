using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApi.FakeRepositories.Interfaces;
using CourseApi.Models;

namespace CourseApi.FakeRepositories.Implementations
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository()
        {
            // Initialize list
            Add(new Course
            {
                Id = 1,
                Name = "Test Course",
                TemplateId = "TEST-11-F",
                EndTime = DateTime.Now.AddMonths(3),
                StartTime = DateTime.Now
            });
        }
    }
}
