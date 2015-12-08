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
    public class SmsController : ApiController
    {
        private readonly ISmsService smsService;

        /// <summary>
        /// 初始化 <c>SmsController</c> 类的新实例。
        /// </summary>
        /// <param name="deviceService"></param>
        public SmsController(ISmsService deviceService)
        {
            this.smsService = deviceService;
        }

        /// <summary>
        /// 同步短信。
        /// </summary>
        /// <param name="list">短信列表。</param>
        public void Sync(IEnumerable<SyncSmsTransferObject> list)
        {
            this.smsService.Sync(list);
        }
    }
}
