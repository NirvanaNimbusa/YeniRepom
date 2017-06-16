using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using MyNewWebSite.EntityFramework;

namespace MyNewWebSite
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(MyNewWebSiteCoreModule))]
    public class MyNewWebSiteDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MyNewWebSiteDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
