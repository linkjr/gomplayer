using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.TransferObjects;

namespace GomPlayer.IApplication
{
    public interface IDeviceService
    {
        void Sync(SyncDeviceTransferObject dataObject);

        IQueryable<DeviceTransferObject> List();
    }
}
