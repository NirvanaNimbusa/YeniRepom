using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MyNewWebSite.EntityFramework;

namespace MyNewWebSite.Migrator
{
    [DependsOn(typeof(MyNewWebSiteDataModule))]
    public class MyNewWebSiteMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MyNewWebSiteDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}