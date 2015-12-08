using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GomPlayer.Infrastructure.Repositories.EntityFramework;

namespace GomPlayer.Infrastructure.Repositories.EntityFramework
{
   public class GomPlayerRepositoryContext : EntityFrameworkRepositoryContext
    {
        private readonly DbContext _context;

        #region Properties

        public override DbContext Context
        {
            get { return this._context; }
        }

        #endregion

        #region ctor

        public GomPlayerRepositoryContext()
        {
            this._context = new GomPlayerDbContext();

        }

        #endregion
    }
}
