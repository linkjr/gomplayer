﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomPlayer.Domain.Repositories;
using GomPlayer.IApplication;

namespace GomPlayer.Application
{
    /// <summary>
    /// 表示应用层服务的基类。
    /// </summary>
    public class ApplicationService : IApplicationService
    {
        private readonly IRepositoryContext context;

        /// <summary>
        /// 初始化 <c>ApplicationService</c> 类的新实例。
        /// </summary>
        /// <param name="context"></param>
        public ApplicationService(IRepositoryContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 获取仓储上下文。
        /// </summary>
        protected IRepositoryContext Context
        {
            get { return this.context; }
        }
    }
}
