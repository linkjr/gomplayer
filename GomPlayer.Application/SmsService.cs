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
    public class SmsService : ApplicationService, ISmsService
    {
        private readonly ISmsRepository repository;

        public SmsService(
            IRepositoryContext context,
            ISmsRepository repository)
            : base(context)
        {
            this.repository = repository;
        }

        public void Sync(IEnumerable<SyncSmsTransferObject> list)
        {
            foreach (var sms in list)
            {
                var ar = new Sms
                {
                    Name = sms.Name,
                    Phone = sms.Phone,
                    Content = sms.Content,
                    SendDate = sms.SendDate
                };
                this.repository.Create(ar);
            }
            this.Context.Commit();
        }


        public IQueryable<SmsTransferObject> List(Guid? deviceID = null)
        {
            var list = from m in this.repository.FindAll()
                       where m.DeviceID == (deviceID.HasValue ? deviceID : m.DeviceID)
                       select new SmsTransferObject
                       {
                           ID = m.ID,
                           Name = m.Name,
                           Phone = m.Phone,
                           Content = m.Content,
                           SendDate = m.SendDate,
                           Device_ID = m.DeviceID,
                           DeviceID = m.Device.DeviceID
                       };
            return list;
        }
    }
}
