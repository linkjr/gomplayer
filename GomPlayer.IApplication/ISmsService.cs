using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.TransferObjects;

namespace GomPlayer.IApplication
{
    public interface ISmsService : IApplicationService
    {
        void Sync(IEnumerable<SyncSmsTransferObject> list, string deviceID);

        IQueryable<SmsTransferObject> List(Guid? deviceID = null);
    }
}
