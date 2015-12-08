using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Models;
using GomPlayer.Infrastructure.Repositories.EntityFramework.EntityTypeConfigurations;

namespace GomPlayer.Infrastructure.Repositories.EntityFramework
{
    public class GomPlayerDbContext : DbContext
    {
        /// <summary>
        /// 初始化 <c>EAMDbContext</c> 类的新实例。
        /// </summary>
        public GomPlayerDbContext()
            : base(nameOrConnectionString: "DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GomPlayerDbContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DeviceEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SmsEntityTypeConfiguration());
            modelBuilder.Properties<byte[]>()
                .Where(m => m.Name == "RowVersion")
                .Configure(m => m.IsRowVersion());
            modelBuilder.Properties<DateTime>()
                .Configure(m =>
                    m.HasColumnType("DateTime2"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
