using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApi.FakeRepositories.Interfaces;
using CourseApi.Models;

namespace CourseApi.FakeRepositories.Implementations
{
    public sealed class CourseLinkRepository : RepositoryBase<CourseLink>, ICourseLinkRepository
    {
        public CourseLinkRepository()
        {
            // Initialize all students linked to courses
            Add(new CourseLink
            {
                CourseId = 1,
                SSN = 1110601919
            });
        }
    }
}
