using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CourseApi.Services.Interfaces;
using CourseApi.Models;

namespace CourseApi.Controllers
{
    [Route("api/v1")]
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        private readonly IStudentService studentService;

        public CoursesController(ICourseService courseService, IStudentService studentService)
        {
            this.courseService = courseService;
            this.studentService = studentService;
        }
        // GET api/v1/courses
        [HttpGet]
        [Route("courses", Name = "GetCourses")]
        public IEnumerable<Course> GetCourses()
        {
            return courseService.GetAllCourses();
        }

        // GET api/v1/courses/5
        [HttpGet]
        [Route("courses/{id:int}", Name = "GetCourseById")]
        public Course GetCourseById(int id)
        {
            return courseService.GetById(id);
        }

        // POST api/v1/courses
        [HttpPost]
        [Route("courses", Name = "CreateCourse")]
        public IActionResult CreateCourse([FromBody]Course value)
        {
            var course = courseService.AddCourse(value);

            return Created(Url.Link("GetCourseById", new {id = course.Id}), course);
        }

        // PUT api/v1/courses/1
        [HttpPut]
        [Route("courses/{id:int}", Name = "UpdateCourseById")]
        public void UpdateCourseById(int id, [FromBody]Course value)
        {
            courseService.UpdateCourse(id, value);
        }

        // DELETE api/v1/courses/1
        [HttpDelete]
        [Route("courses/{id:int}", Name = "DeleteCourseById")]
        public IActionResult DeleteCourseById(int id)
        {
            courseService.DeleteCourse(id);
            return StatusCode(204);
        }

        [HttpGet]
        [Route("courses/{id:int}/students", Name = "GetStudentsByCourseId")]
        public IEnumerable<Student> GetStudentsByCourseId(int id)
        {
            return studentService.GetAllStudentsByCourseId(id);
        }

        [HttpPost]
        [Route("courses/{id:int}/students", Name = "CreateStudentByCourseId")]
        public IActionResult CreateStudentByCourseId(int id, [FromBody]Student value)
        {
            var student = studentService.CreateStudentByCourseId(id, value);
            return StatusCode(201);
        }
    }
}
