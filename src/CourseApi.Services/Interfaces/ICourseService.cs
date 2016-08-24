using System.Collections.Generic;
using CourseApi.Models;

namespace CourseApi.Services.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
        Course GetById(int id);
        Course AddCourse(Course course);
        void UpdateCourse(int id, Course course);
        void DeleteCourse(int id);
    }
}
