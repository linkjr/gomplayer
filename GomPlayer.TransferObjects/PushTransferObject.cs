using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tang.Infrastructure.Net.Push;

namespace GomPlayer.TransferObjects
{
    public class PushTransferObject
    {
        public string Token { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Icon_Res { get; set; }

        public string WebUrl { get; set; }

        public string ApkUrl { get; set; }
    }
}
