using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GomPlayer.IApplication;
using GomPlayer.Infrastructure.Paging;

namespace GomPlayer.Web.Controllers
{
    public class DeviceController : Controller
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

        // GET: Device
        public ActionResult Index(int id = 1)
        {
            var list = this.deviceService.List().ToPagedList(id, 20);
            if (Request.IsAjaxRequest())
                return PartialView("_ListPartial", list);
            return View(list);
        }
    }
}