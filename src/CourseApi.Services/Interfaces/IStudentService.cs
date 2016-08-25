using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApi.Models;

namespace CourseApi.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudentsByCourseId(int id);
        Student CreateStudentByCourseId(int id, Student student);
    }
}
