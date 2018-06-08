using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace RepositoryPattern.Domain
{
    internal static class Config
    {
        public static ITransactionManager GetManager()
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IDbContext, dbModel>();
            unityContainer.RegisterType<ITransactionManager, TransactionManager>();
            unityContainer.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            return unityContainer.Resolve<ITransactionManager>();
        }
    }
}
