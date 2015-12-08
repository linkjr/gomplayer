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
        }
    }
}
