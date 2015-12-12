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
    /// 表示对 <c>Sms</c> 领域模型的实体类型配置。
    /// </summary>
    public class SmsEntityTypeConfiguration : EntityTypeConfiguration<Sms>
    {
        /// <summary>
        /// 初始化 <c>SmsEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public SmsEntityTypeConfiguration()
        {
            base.Property(m => m.Name)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(20)
                .IsRequired();
            base.Property(m => m.Phone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();
            base.Property(m => m.Content)
                .HasColumnType("NVARCHAR")
                .HasMaxLength(1000)
                .IsRequired();
            base.Property(m => m.ReceivePhone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            base.HasRequired(m => m.Device)
                .WithMany(m => m.SmsList)
                .HasForeignKey(m => m.DeviceID);
        }
    }
}
