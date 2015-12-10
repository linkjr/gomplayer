using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomPlayer.Domain.Models
{
    /// <summary>
    /// 表示设备的领域模型。
    /// </summary>
    public class Device : AggregateRoot
    {
        #region ctor

        protected Device() { }

        public Device(string deviceID, string deviceToken, string phone, string model, string imei, string version)
        {
            this.DeviceID = deviceID;
            this.DeviceToken = deviceToken;
            this.Phone = phone;
            this.Model = model;
            this.Imei = imei;
            this.Version = version;
            this.SyncDate = DateTime.Now;
            this.CreateDate = DateTime.Now;
        }

        #endregion

        #region Properties

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
        /// 获取或设置创建日期。
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 获取或设置短信列表。
        /// </summary>
        public IList<Sms> SmsList { get; set; }

        #endregion

        #region Methods

        public void Sync(string deviceID, string deviceToken, string phone, string model, string imei, string version)
        {
            this.DeviceID = deviceID;
            this.DeviceToken = deviceToken;
            this.Phone = phone;
            this.Model = model;
            this.Imei = imei;
            this.Version = version;
            this.SyncDate = DateTime.Now;
        }

        #endregion
    }
}
