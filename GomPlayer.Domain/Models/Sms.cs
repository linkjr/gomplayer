﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomPlayer.Domain.Models
{
    /// <summary>
    /// 表示短信的领域模型。
    /// </summary>
    public class Sms : AggregateRoot
    {
        #region ctor

        protected Sms() { }

        public Sms(string name, string phone, string content, DateTime sendDate, string receivePhone, Guid deviceID)
        {
            this.Name = name;
            this.Phone = phone;
            this.Content = content;
            this.SendDate = sendDate;
            this.ReceivePhone = receivePhone;
            this.DeviceID = deviceID;
            this.CreateDate = DateTime.Now;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 获取或设置发送人姓名。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 获取或设置发送人电话。
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置内容。
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 获取或设置送达时间。
        /// </summary>
        public DateTime SendDate { get; set; }

        /// <summary>
        /// 获取或设置接收人电话。
        /// </summary>
        public string ReceivePhone { get; set; }

        /// <summary>
        /// 获取或设置设备ID。
        /// </summary>
        public Guid DeviceID { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 获取或设置所属设备。
        /// </summary>
        public virtual Device Device { get; set; }

        #endregion
    }
}
