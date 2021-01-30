using Vns.Infrastructure.ModelView.ArticleModelView;
namespace Vns.Infrastructure.Services.IRepository
{
    public interface IArticleRepository
    {
        ResponseData<ArticleModelView> insertArticle(ArticleModelView request);
        ResponseData<int> approveArticle(int id);
        ResponseData<ArticleModelView> updateArticle(ArticleModelView request);
        ResponseData<int> deleteArticle(int id);
        ResponseData<ArticleModelView> getArticleById(int id);
    }
}