using System;
namespace Vns.Core.Commons.BaseResponse
{
    public class DetailResponse<TEntity> : BaseResponse
    {
        public TEntity Data { get; set; }
    }
}
