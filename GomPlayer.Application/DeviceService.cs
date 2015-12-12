using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Models;
using GomPlayer.Domain.Repositories;
using GomPlayer.IApplication;
using GomPlayer.Infrastructure;
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
            if (dataObject == null)
                throw new Exception("dataObject为空");
            if (!string.IsNullOrEmpty(dataObject.Phone))
                //if (!dataObject.Phone.IsPhone())
                //    throw new Exception("电话格式不正确");
            if (!string.IsNullOrEmpty(dataObject.Version))
                if (dataObject.Version.Length > 10)
                    throw new Exception("版本长度超过10");

            var ar = this.repository.FindAll().FirstOrDefault(m => m.DeviceID == dataObject.DeviceID);
            if (ar == null)
            {
                ar = new Device(dataObject.DeviceID, dataObject.DeviceToken, dataObject.Phone, dataObject.Model, dataObject.Imei, dataObject.Version);
                this.repository.Create(ar);
            }
            else
            {
                ar.Sync(dataObject.DeviceID, dataObject.DeviceToken, dataObject.Phone, dataObject.Model, dataObject.Imei, dataObject.Version);
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
