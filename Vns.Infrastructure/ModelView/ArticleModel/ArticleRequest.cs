using System;
using Vns.Core.Commons.Enum;
using Vns.Core.Commons.Generic;

namespace Vns.Infrastructure.ModelView.ArticleModel
{
    public class ArticleRequest: PagingRequest
    {
        public int CategoryId { get; set; }
        public EStatus Status { get; set; }
    }
}
