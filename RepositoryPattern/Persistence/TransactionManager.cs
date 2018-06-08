using System;
using System.Collections;

namespace RepositoryPattern
{
    public interface ITransactionManager:IDisposable
    {
        IRepository<T> CreateRepository<T>() where T : class;
        int Save();
    }
    class TransactionManager : ITransactionManager
    {
        IDbContext _ctx;
        Hashtable _repositories;
        public TransactionManager(IDbContext ctx)
        {
            _ctx = ctx;
        }
        public IRepository<T> CreateRepository<T>() where T : class
        {
            if (_repositories == null)
                _repositories = new Hashtable();
            var type = typeof(T).Name;
            if (!_repositories.Contains(type))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _ctx);
                _repositories.Add(type,repositoryInstance);
            }
            return (IRepository<T>)_repositories[type];
        }

        public int Save()
        {
            return _ctx.Save();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~TransactionManager() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
