using MB.Application.Contracts.Article;
using System.Collections.Generic;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        void CreateAndSave(Article entity);
        List<ArticleViewModel> GetList();
    }
}
