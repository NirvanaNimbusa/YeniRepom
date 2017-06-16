using System.Data.Common;
using Abp.Zero.EntityFramework;
using MyNewWebSite.Authorization.Roles;
using MyNewWebSite.MultiTenancy;
using MyNewWebSite.Users;

namespace MyNewWebSite.EntityFramework
{
    public class MyNewWebSiteDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MyNewWebSiteDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyNewWebSiteDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyNewWebSiteDbContext since ABP automatically handles it.
         */
        public MyNewWebSiteDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyNewWebSiteDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyNewWebSiteDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
