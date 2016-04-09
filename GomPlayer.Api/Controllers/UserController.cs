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
    /// 表示用户的Api控制器类。
    /// </summary>
    public class UserController : ApiController
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

        /// <summary>
        /// 注册。
        /// </summary>
        /// <param name="dataObject"></param>
        /// <returns></returns>
        [HttpPost]
        public object Register([FromBody]RegisterUserTransferObject dataObject)
        {
            this._userService.Create(dataObject);
            return Json(new { msg = "注册成功", result = true });
        }

        /// <summary>
        /// 列表。
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IQueryable<UserTransferObject> List()
        {
            var list = this._userService.List();
            return list;
        }
    }
}
