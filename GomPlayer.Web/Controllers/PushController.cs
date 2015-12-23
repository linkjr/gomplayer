using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GomPlayer.IApplication;
using GomPlayer.TransferObjects;
using GomPlayer.Web.Models;

namespace GomPlayer.Web.Controllers
{
    public class PushController : Controller
    {
        private readonly IPushService _pushService;

        public PushController(IPushService pushService)
        {
            this._pushService = pushService;
        }

        // GET: Push
        public ActionResult Index(string token)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Index(PushViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var dataObject = new PushTransferObject
            {
                Token = model.Token,
                Title = model.Title,
                Content = model.Content,
                WebUrl = model.WebUrl,
                ApkUrl = model.ApkUrl
            };
            this._pushService.Push(dataObject);
            return Json(new { result = true, msg = "推送成功" });
        }
    }
}