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

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        // GET api/v1/courses
        [HttpGet]
        [Route("courses", Name = "GetCourses")]
        public IEnumerable<Course> Get()
        {
            return courseService.GetAllCourses();
        }

        // GET api/v1/courses/5
        [HttpGet]
        [Route("courses/{id:int}", Name = "GetCourseById")]
        public Course Get(int id)
        {
            return courseService.GetById(id);
        }

        // POST api/v1/courses
        [HttpPost]
        [Route("courses", Name = "CreateCourse")]
        public IActionResult Post([FromBody]Course value)
        {
            var course = courseService.AddCourse(value);

            return Created(Url.Link("GetCourseById", new {id = course.Id}), course);
        }

        // PUT api/v1/courses/1
        [HttpPut]
        [Route("courses/{id:int}", Name = "UpdateCourseById")]
        public void Put(int id, [FromBody]Course value)
        {
            courseService.UpdateCourse(id, value);
        }

        // DELETE api/v1/courses/1
        [HttpDelete]
        [Route("courses/{id:int}", Name = "DeleteCourseById")]
        public IActionResult Delete(int id)
        {
            courseService.DeleteCourse(id);
            return StatusCode(204);
        }
    }
}
