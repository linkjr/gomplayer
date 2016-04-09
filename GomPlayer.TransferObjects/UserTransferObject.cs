using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Models;

namespace GomPlayer.TransferObjects
{
    public class UserTransferObject
    {
        public Guid ID { get; set; }

        public string RealName { get; set; }

        /// <summary>
        /// 获取或设置性别。
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 获取或设置电话。
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置生日。
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 获取或设置邮箱。
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 获取或设置运营商。
        /// </summary>
        public OperatorOptions Operator { get; set; }

        /// <summary>
        /// 获取或设置创建日期。
        /// </summary>
        public DateTime CreateDate { get; set; }
    }

    public class RegisterUserTransferObject
    {
        public string RealName { get; set; }

        /// <summary>
        /// 获取或设置性别。
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 获取或设置电话。
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置生日。
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 获取或设置邮箱。
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 获取或设置运营商。
        /// </summary>
        public OperatorOptions Operator { get; set; }
    }
}
