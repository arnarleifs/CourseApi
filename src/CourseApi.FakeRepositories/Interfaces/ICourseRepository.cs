using CourseApi.Models;

namespace CourseApi.FakeRepositories.Interfaces
{
    public interface ICourseRepository : IRepository<Course>
    {
        int NextId { get; set; }
    }
}
