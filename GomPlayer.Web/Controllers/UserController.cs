using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GomPlayer.IApplication;
using GomPlayer.Infrastructure.Paging;

namespace GomPlayer.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        /// <summary>
        /// 初始化 <c>UserController</c> 类的新实例。
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        // GET: User
        public ActionResult Index(int id = 1)
        {
            var list = this._userService.List()
                .ToPagedList(id, 10);
            if (Request.IsAjaxRequest())
                return PartialView("_ListPartial", list);
            return View(list);
        }
    }
}