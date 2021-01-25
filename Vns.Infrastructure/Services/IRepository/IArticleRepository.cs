using Vns.Infrastructure.ModelView.ArticleModelView;
using Vns.Infrastructure.ModelView.ImageModelView;
namespace Vns.Infrastructure.Services.IRepository
{
    public interface IArticleRepository
    {
        ResponseData<ArticleModelRequest> insertArticle(ArticleModelRequest request);
        ResponseData<int> approveArticle(int id);
        ResponseData<ArticleModelRequest> updateArticle(ArticleModelRequest request);
        ResponseData<int> deleteArticle(int id);
        ResponseData<ArticleModelRequest> getArticleById(int id);
    }
}