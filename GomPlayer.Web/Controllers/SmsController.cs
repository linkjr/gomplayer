using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GomPlayer.IApplication;
using GomPlayer.Infrastructure.Paging;

namespace GomPlayer.Web.Controllers
{
    public class SmsController : Controller
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

        // GET: Sms
        public ActionResult Index(int id = 1, Guid? deviceId = null)
        {
            var list = this.smsService.List(deviceId)
                .ToPagedList(id, 10);
            if (Request.IsAjaxRequest())
                return PartialView("_ListPartial", list);
            return View(list);
        }
    }
}