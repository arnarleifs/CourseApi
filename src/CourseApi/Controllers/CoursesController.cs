using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseApi.Controllers
{
    [Route("api/v1")]
    public class CoursesController : Controller
    {
        // GET api/v1/courses
        [HttpGet]
        [Route("courses", Name = "GetCourses")]
        public IEnumerable<string> Get()
        {
            return new string[] { "Course1", "Course2" };
        }

        // GET api/v1/courses/5
        [HttpGet]
        [Route("courses/{id:int}", Name = "GetCourseById")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/v1/courses
        [HttpPost]
        [Route("courses", Name = "CreateCourse")]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/v1/courses/1
        [HttpPut]
        [Route("courses/{id:int}", Name = "UpdateCourseById")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/v1/courses/1
        [HttpDelete]
        [Route("courses/{id:int}", Name = "DeleteCourseById")]
        public void Delete(int id)
        {
        }
    }
}
