using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApi.FakeRepositories.Interfaces;
using CourseApi.Models;

namespace CourseApi.FakeRepositories.Implementations
{
    public sealed class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository()
        {
            // Initializing students in the system
            Add(new Student
            {
                SSN = 1110601919,
                Name = "Bobby Harris"
            });
            Add(new Student
            {
                SSN = 1606893319,
                Name = "Arnar Leifsson"
            });
            Add(new Student
            {
                SSN = 1212902319,
                Name = "Tryggvi Sævarsson"
            });
            Add(new Student
            {
                SSN = 1510882519,
                Name = "Sighvatur Skúlason"
            });
            Add(new Student
            {
                SSN = 2509852609,
                Name = "Margeir Þórsson"
            });
        }
    }
}
