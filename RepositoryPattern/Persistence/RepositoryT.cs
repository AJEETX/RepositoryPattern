using System.Collections.Generic;

namespace RepositoryPattern
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T GetById(int id);
        void Update(T entity);
        void Add(T entity);
        void Delete(int id);
    }
    class Repository<T> : IRepository<T> where T : class
    {
        IDbContext _ctx;
        public Repository(IDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(T entity)
        {
            _ctx.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _ctx.Set<T>().Remove(entity);
        }

        public IEnumerable<T> Get()
        {
            return _ctx.Set<T>();
        }

        public T GetById(int id)
        {
            return _ctx.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _ctx.Set<T>().Attach(entity);
        }
    }
}
