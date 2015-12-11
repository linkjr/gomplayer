using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GomPlayer.Infrastructure
{
    public static class RegularHelper
    {
        private const string PHONE = @"^1[34578]\d{9}$";
        public static bool IsPhone(this string value)
        {
            return Regex.IsMatch(value, PHONE);
        }
    }
}
