﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomPlayer.TransferObjects
{
    public class SmsTransferObject
    {
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
    }

    public class SyncSmsTransferObject
    {
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
    }
}
