using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Models;
using GomPlayer.Domain.Repositories;

namespace GomPlayer.Infrastructure.Repositories.EntityFramework
{
    public class UserRepository : EntityFrameworkRepository<User>, IUserRepository
    {
        public UserRepository(IRepositoryContext context)
            : base(context) { }
    }
}
