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
        public IActionResult GetCourseById(int id)
        {
            var course = courseService.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            return new ObjectResult(course);
        }

        // POST api/v1/courses
        [HttpPost]
        [Route("courses", Name = "CreateCourse")]
        public IActionResult CreateCourse([FromBody]Course value)
        {
            if (value == null || value.Name == null || value.TemplateId == null || 
                value.StartTime == null || value.EndTime == null)
            {
                return BadRequest();
            }
            var course = courseService.AddCourse(value);

            return Created(Url.Link("GetCourseById", new {id = course.Id}), course);
        }

        // PUT api/v1/courses/1
        [HttpPut]
        [Route("courses/{id:int}", Name = "UpdateCourseById")]
        public IActionResult UpdateCourseById(int id, [FromBody]Course value)
        {
            if (value == null || value.Name == null || value.TemplateId == null ||
                value.StartTime == null || value.EndTime == null)
            {
                return BadRequest();
            }

            var course = courseService.GetById(id);

            if (course == null)
            {
                return NotFound();
            }

            courseService.UpdateCourse(id, value);
            return new NoContentResult();
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
            if (value == null || value.SSN <= 0 || value.Name == null)
            {
                return BadRequest();
            }
            var student = studentService.CreateStudentByCourseId(id, value);
            return StatusCode(201);
        }
    }
}
