using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApi.FakeRepositories.Interfaces;
using CourseApi.Models;
using CourseApi.Services.Interfaces;

namespace CourseApi.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        private readonly ICourseLinkRepository courseLinkRepository;

        public StudentService(IStudentRepository studentRepository, ICourseLinkRepository courseLinkRepository)
        {
            this.studentRepository = studentRepository;
            this.courseLinkRepository = courseLinkRepository;
        }
        public IEnumerable<Student> GetAllStudentsByCourseId(int id)
        {
            var courseLinks = courseLinkRepository.GetMany(c => c.CourseId == id);
            List<Student> students = new List<Student>();
            foreach (var link in courseLinks)
            {
                students.Add(studentRepository.Get(s => s.SSN == link.SSN));
            }

            return students;
        }

        public Student CreateStudentByCourseId(int id, Student student)
        {
            courseLinkRepository.Add(new CourseLink
            {
                CourseId = id,
                SSN = student.SSN
            });

            return studentRepository.Add(student);
        }
    }
}
