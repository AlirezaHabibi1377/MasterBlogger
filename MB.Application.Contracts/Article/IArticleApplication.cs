using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        void Create(CreateArticle command);
        List<ArticleViewModel> GetList();
        void Edit(EditArticle command);
        EditArticle Get(long id);
        void Remove(long id);
        void Activate(long id);
    }
}
