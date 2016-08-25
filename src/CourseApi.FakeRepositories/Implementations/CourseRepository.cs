using System;
using CourseApi.FakeRepositories.Interfaces;
using CourseApi.Models;

namespace CourseApi.FakeRepositories.Implementations
{
    public sealed class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository()
        {
            // Initialize list
            Add(new Course
            {
                Id = 1,
                Name = "Computer Physics",
                TemplateId = "T-111-CPH",
                EndTime = DateTime.Now.AddMonths(3),
                StartTime = DateTime.Now
            });
            Add(new Course
            {
                Id = 2,
                Name = "Human Mind Reading",
                TemplateId = "T-510-HUM",
                EndTime = DateTime.Now.AddMonths(3),
                StartTime = DateTime.Now
            });
            Add(new Course
            {
                Id = 3,
                Name = "Robotologicious",
                TemplateId = "T-410-ROB",
                EndTime = DateTime.Now.AddMonths(3),
                StartTime = DateTime.Now
            });
            Add(new Course
            {
                Id = 4,
                Name = "Google Analytics 101",
                TemplateId = "T-101-GANA",
                EndTime = DateTime.Now.AddMonths(3),
                StartTime = DateTime.Now
            });
        }
    }
}
