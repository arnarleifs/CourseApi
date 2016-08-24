using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CourseApi.FakeRepositories
{
    public class MockSource<T> where T : class
    {
        private List<T> mockList = new List<T>();
        public IEnumerable<T> Where(Expression<Func<T, bool>> where)
        {
            return mockList.Where(where.Compile()).ToList();
        }

        public IEnumerable<T> GetAll()
        {
            return mockList.ToList();
        }

        public T GetById(int id)
        {
            return mockList[id];
        }

        public void Delete(T entity)
        {
            mockList.Remove(entity);
        }

        public void Update(T entity, Expression<Func<T, bool>> where)
        {
            T obj = mockList.Where(where.Compile()).FirstOrDefault();
            int idx = mockList.IndexOf(obj);
            mockList.RemoveAt(idx);
            mockList.Insert(idx, entity);
        }

        public T Add(T entity)
        {
            mockList.Add(entity);

            return mockList[mockList.Count - 1];
        }
    }
}
