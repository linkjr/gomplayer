using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using GomPlayer.IApplication;
using GomPlayer.TransferObjects;

namespace GomPlayer.Api.Controllers
{
    public class SmsController : ApiController
    {
        private readonly ISmsService smsService;

        /// <summary>
        /// 初始化 <c>SmsController</c> 类的新实例。
        /// </summary>
        /// <param name="smsService"></param>
        public SmsController(ISmsService smsService)
        {
            this.smsService = smsService;
        }

        /// <summary>
        /// 同步短信。
        /// </summary>
        /// <param name="list">短信列表。</param>
        /// <param name="deviceID">设备编号。</param>
        public object Sync(IEnumerable<SyncSmsTransferObject> list, string deviceID)
        {
            this.smsService.Sync(list, deviceID);
            return Json(new { msg = "同步成功", result = true });
        }
    }
}
