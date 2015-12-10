using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Models;

namespace GomPlayer.Infrastructure.Repositories.EntityFramework.EntityTypeConfigurations
{
    /// <summary>
    /// 表示对 <c>Device</c> 领域模型的实体类型配置。
    /// </summary>
    public class DeviceEntityTypeConfiguration : EntityTypeConfiguration<Device>
    {
        /// <summary>
        /// 初始化 <c>DeviceEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public DeviceEntityTypeConfiguration()
        {
            base.Property(m => m.DeviceID)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            base.Property(m => m.DeviceToken)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100)
                .IsRequired();
            base.Property(m => m.Phone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(11);
            base.Property(m => m.Model)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            base.Property(m => m.Imei)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);
            base.Property(m => m.Version)
                .HasColumnType("VARCHAR")
                .HasMaxLength(10);

            base.HasMany(m => m.SmsList)
                .WithRequired(m => m.Device)
                .HasForeignKey(m => m.DeviceID);
        }
    }
}
