using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApi.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TemplateId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
