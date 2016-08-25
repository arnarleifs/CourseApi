using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApi.FakeRepositories.Interfaces;
using CourseApi.Models;
using CourseApi.Services.Interfaces;

namespace CourseApi.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }
        public IEnumerable<Course> GetAllCourses()
        {
            return courseRepository.GetAll();
        }

        public Course GetById(int id)
        {
            return courseRepository.Get(c => c.Id == id);
        }

        public Course AddCourse(Course course)
        {
            course.Id = courseRepository.NextId++;
            return courseRepository.Add(course);
        }

        public void UpdateCourse(int id, Course course)
        {
            course.Id = id;
            courseRepository.Update(course, c => c.Id == id);
        }

        public void DeleteCourse(int id)
        {
            courseRepository.Delete(courseRepository.Get(c => c.Id == id));
        }
    }
}
