using Vns.Core.Commons.BaseResponse;
using Vns.Core.Commons.Paging;
using Vns.Infrastructure.ModelView.ArticleModel;

namespace Vns.Infrastructure.Services.IRepository
{
    public interface IArticleRepository
    {   
        DetailResponse<int> Approve(int? id);
        DetailResponse<int> Inactive(int? id);
        DetailResponse<ArticleDto> Insert(ArticleDto request);
        DetailResponse<ArticleDto> Update(ArticleDto request);
        DetailResponse<ArticleDto> GetDetail(int? id);
        IPagedList<ArticleDto> GetList(ArticleRequest request);
        DetailResponse<int> Remove(int? id);

    }
}