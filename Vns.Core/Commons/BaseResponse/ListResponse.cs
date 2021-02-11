using System;
using Vns.Core.Commons.Paging;

namespace Vns.Core.Commons.BaseResponse
{
    public class ListResponse<TEntity> : BaseResponse
    {
        public IPagedList<TEntity> Data { get; set; }
    }
}
