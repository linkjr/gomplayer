using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.TransferObjects;

namespace GomPlayer.IApplication
{
    public interface IPushService
    {
        void Push(PushTransferObject dataObject);
    }
}
