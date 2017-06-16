using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyNewWebSite.EntityFramework.Repositories
{
    public abstract class MyNewWebSiteRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyNewWebSiteDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyNewWebSiteRepositoryBase(IDbContextProvider<MyNewWebSiteDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyNewWebSiteRepositoryBase<TEntity> : MyNewWebSiteRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyNewWebSiteRepositoryBase(IDbContextProvider<MyNewWebSiteDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
