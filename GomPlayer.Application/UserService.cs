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
    public class UserService : ApplicationService, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(
            IRepositoryContext context,
            IUserRepository userRepository)
            : base(context)
        {
            this._userRepository = userRepository;
        }

        public void Create(RegisterUserTransferObject dataObject)
        {
            if (dataObject == null)
                throw new Exception("dataObject为空");

            var ar = new User(dataObject.RealName, dataObject.Gender, dataObject.Phone, dataObject.Birthday, dataObject.Email, dataObject.Operator);
            this._userRepository.Create(ar);
            base.Context.Commit();
        }


        public IQueryable<UserTransferObject> List()
        {
            var list = from m in this._userRepository.FindAll()
                       select new UserTransferObject
                       {
                           ID = m.ID,
                           RealName = m.RealName,
                           Gender = m.Gender,
                           Phone = m.Phone,
                           Birthday = m.Birthday,
                           Email = m.Email,
                           Operator = m.Operator,
                           CreateDate = m.CreateDate
                       };
            return list;
        }
    }
}
