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
    /// 表示对 <c>User</c> 领域模型的实体类型配置。
    /// </summary>
    public class UserEntityTypeConfiguration : EntityTypeConfiguration<User>
    {
        /// <summary>
        /// 初始化 <c>UserEntityTypeConfiguration</c> 类的新实例。
        /// </summary>
        public UserEntityTypeConfiguration()
        {
            base.Property(m => m.RealName)
                .HasMaxLength(100)
                .IsRequired();
            base.Property(m => m.Gender)
                .HasColumnType("VARCHAR")
                .HasMaxLength(10)
                .IsRequired();
            base.Property(m => m.Phone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired();
            base.Property(m => m.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(100);
        }
    }
}
