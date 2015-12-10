using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GomPlayer.IApplication;
using GomPlayer.TransferObjects;

namespace GomPlayer.Api.Controllers
{
    /// <summary>
    /// 表示设备的Api控制器类。
    /// </summary>
    public class DeviceController : ApiController
    {
        private readonly IDeviceService deviceService;

        /// <summary>
        /// 初始化 <c>DeviceController</c> 类的新实例。
        /// </summary>
        /// <param name="deviceService"></param>
        public DeviceController(IDeviceService deviceService)
        {
            this.deviceService = deviceService;
        }

        /// <summary>
        /// 同步设备信息。
        /// </summary>
        /// <param name="dataObject">设备的传输对象。</param>
        [HttpPost]
        public object Sync([FromBody]SyncDeviceTransferObject dataObject)
        {
            this.deviceService.Sync(dataObject);
            return Json(new { msg = "同步成功", result = true });
        }

        /// <summary>
        /// 设备列表。
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IQueryable<DeviceTransferObject> Get()
        {
            var list = this.deviceService.List();
            return list;
        }
    }
}
