﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GomPlayer.Infrastructure.Paging
{
    public interface IPagedList
    {
        int CurrentPageIndex { get; set; }
        int PageSize { get; set; }
        int TotalItemCount { get; set; }
    }

}
