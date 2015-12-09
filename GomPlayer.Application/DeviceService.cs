using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Models;
using GomPlayer.Domain.Repositories;
using GomPlayer.IApplication;
using GomPlayer.TransferObjects;

namespace GomPlayer.Application
{
    public class DeviceService : ApplicationService, IDeviceService
    {
        private readonly IDeviceRepository repository;

        public DeviceService(
            IRepositoryContext context,
            IDeviceRepository repository)
            : base(context)
        {
            this.repository = repository;
        }

        public void Sync(SyncDeviceTransferObject dataObject)
        {
            var ar = this.repository.FindAll().FirstOrDefault(m => m.DeviceID == dataObject.DeviceID);
            if (ar == null)
            {
                ar = new Device
                {
                    DeviceID = dataObject.DeviceID,
                    DeviceToken = dataObject.DeviceToken,
                    Phone = dataObject.Phone,
                    Model = dataObject.Model,
                    Imei = dataObject.Imei,
                    Version = dataObject.Version,
                    SyncDate = DateTime.Now
                };
                this.repository.Create(ar);
            }
            else
            {
                ar = new Device
                {
                    DeviceID = dataObject.DeviceID,
                    DeviceToken = dataObject.DeviceToken,
                    Phone = dataObject.Phone,
                    Model = dataObject.Model,
                    Imei = dataObject.Imei,
                    Version = dataObject.Version,
                    SyncDate = DateTime.Now
                };
                this.repository.Modify(ar);
            }
            this.Context.Commit();
        }


        public IQueryable<DeviceTransferObject> List()
        {
            var list = from m in this.repository.FindAll()
                       select new DeviceTransferObject
                       {
                           ID = m.ID,
                           DeviceID = m.DeviceID,
                           DeviceToken = m.DeviceToken,
                           Phone = m.Phone,
                           Model = m.Model,
                           Imei = m.Imei,
                           Version = m.Version,
                           SyncDate = m.SyncDate
                       };
            return list;
        }
    }
}
