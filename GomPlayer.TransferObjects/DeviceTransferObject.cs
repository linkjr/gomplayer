using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomPlayer.TransferObjects
{
    public class DeviceTransferObject
    {
        /// <summary>
        /// 获取或设置ID。
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 获取或设置设备ID。
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        /// 获取或设置设备Token。
        /// </summary>
        public string DeviceToken { get; set; }

        /// <summary>
        /// 获取或设置电话号码。
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置设备型号。
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 获取或设置设备IMEI。
        /// </summary>
        public string Imei { get; set; }

        /// <summary>
        /// 获取或设置系统版本。
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 获取或设置同步日期。
        /// </summary>
        public DateTime SyncDate { get; set; }

        /// <summary>
        /// 获取或设置短信条数。
        /// </summary>
        public int SmsCount { get; set; }
    }

    public class SyncDeviceTransferObject
    {
        /// <summary>
        /// 获取或设置设备ID。
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        /// 获取或设置设备Token。
        /// </summary>
        public string DeviceToken { get; set; }

        /// <summary>
        /// 获取或设置电话号码。
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 获取或设置设备型号。
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 获取或设置设备IMEI。
        /// </summary>
        public string Imei { get; set; }

        /// <summary>
        /// 获取或设置系统版本。
        /// </summary>
        public string Version { get; set; }
    }
}
