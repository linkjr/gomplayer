using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Models;
using GomPlayer.Domain.Repositories;

namespace GomPlayer.Infrastructure.Repositories.EntityFramework
{
    public class SmsRepository : EntityFrameworkRepository<Sms>, ISmsRepository
    {
        public SmsRepository(IRepositoryContext context)
            : base(context) { }
    }
}
