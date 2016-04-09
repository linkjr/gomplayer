using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomPlayer.Domain.Models
{
    public class User : AggregateRoot
    {
        #region ctor

        protected User() { }

        public User(string realName, string gender, string phone, DateTime birthday, string email, OperatorOptions @operator)
        {
            this.RealName = realName;
            this.Gender = gender;
            this.Phone = phone;
            this.Birthday = birthday;
            this.Email = email;
            this.Operator = @operator;
            this.CreateDate = DateTime.Now;
        }

        #endregion


        #region Properties

        /// <summary>
        /// 获取或设置真实姓名。
        /// </summary>
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

        #endregion


        #region Method



        #endregion
    }

    /// <summary>
    /// 表示运营商的项。
    /// </summary>
    public enum OperatorOptions
    {
        SKT = 1,
        KT = 2,
        LG = 3
    }
}
