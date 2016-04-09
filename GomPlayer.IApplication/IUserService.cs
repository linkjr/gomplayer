using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.TransferObjects;

namespace GomPlayer.IApplication
{
    public interface IUserService
    {
        void Create(RegisterUserTransferObject dataObject);

        IQueryable<UserTransferObject> List();
    }
}
