using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GomPlayer.Web.Models
{
    public class PushViewModel
    {
        [Display(Name = "设备Token")]
        //[Required(ErrorMessage = "请输入{0}")]
        public string Token { get; set; }

        [Display(Name = "推送标题")]
        [Required(ErrorMessage = "请输入{0}")]
        public string Title { get; set; }

        [Display(Name = "推送内容")]
        [Required(ErrorMessage = "请输入{0}")]
        public string Content { get; set; }

        [Display(Name = "Web地址")]
        [Required(ErrorMessage = "请输入{0}")]
        public string WebUrl { get; set; }

        [Display(Name = "Apk地址")]
        [Required(ErrorMessage = "请输入{0}")]
        public string ApkUrl { get; set; }
    }
}