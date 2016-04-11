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
        private readonly ISmsRepository _smsRepository;
        private readonly IDeviceRepository _deviceRepository;

        public SmsService(
            IRepositoryContext context,
            ISmsRepository smsRepository,
            IDeviceRepository deviceRepository)
            : base(context)
        {
            this._smsRepository = smsRepository;
            this._deviceRepository = deviceRepository;
        }

        public void Sync(IEnumerable<SyncSmsTransferObject> list, string deviceID)
        {
            var device = this._deviceRepository.FindAll().FirstOrDefault(m => m.DeviceID == deviceID);
            if (device == null)
                throw new Exception("设备不存在");

            var smsList = this._smsRepository.FindAll();
            foreach (var sms in list)
            {
                var ar = smsList.FirstOrDefault(m =>
                        m.Content == sms.Content
                        && m.Phone == sms.Phone
                        && m.ReceivePhone == sms.ReceivePhone
                        && m.SendDate == sms.SendDate);
                if (ar != null)
                    continue;

                ar = new Sms(sms.Name, sms.Phone, sms.Content, sms.SendDate, sms.ReceivePhone, device.ID);
                this._smsRepository.Create(ar);
            }
            this.Context.Commit();
        }


        public IQueryable<SmsTransferObject> List(Guid? deviceID = null)
        {
            var list = from m in this._smsRepository.FindAll()
                       where m.DeviceID == (deviceID.HasValue ? deviceID : m.DeviceID)
                       orderby m.SendDate descending
                       select new SmsTransferObject
                       {
                           ID = m.ID,
                           Name = m.Name,
                           Phone = m.Phone,
                           Content = m.Content,
                           SendDate = m.SendDate,
                           Device_ID = m.DeviceID,
                           ReceivePhone = m.ReceivePhone,
                           DeviceID = m.Device.DeviceID
                       };
            return list;
        }
    }
}
