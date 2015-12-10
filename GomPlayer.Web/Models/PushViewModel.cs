using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GomPlayer.Web.Models
{
    public class PushViewModel
    {
        [Display(Name = "设备编号")]
        [Required(ErrorMessage = "请输入{0}")]
        public string Token { get; set; }

        [Display(Name = "Web地址")]
        [Required(ErrorMessage = "请输入{0}")]
        public string WebUrl { get; set; }

        [Display(Name = "Apk地址")]
        public string ApkUrl { get; set; }
    }
}