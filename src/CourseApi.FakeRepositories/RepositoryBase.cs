using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CourseApi.FakeRepositories
{
    public abstract class RepositoryBase<T> where T : class
    {
        private MockSource<T> mockSource;

        protected RepositoryBase()
        {
            mockSource = new MockSource<T>();
        }
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return mockSource.Where(where).ToList();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return mockSource.GetAll();
        }

        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return mockSource.Where(where).FirstOrDefault();
        }

        public virtual T GetById(int id)
        {
            return mockSource.GetById(id);
        }

        public virtual void Delete(T entity)
        {
            mockSource.Delete(entity);
        }

        public virtual void Update(T entity, Expression<Func<T, bool>> where)
        {
            mockSource.Update(entity, where);
        }

        public virtual T Add(T entity)
        {
            return mockSource.Add(entity);
        }
    }
}
