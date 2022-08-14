using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        ArticleCategory Get(long Id);
        void Add(ArticleCategory entity);
        void Save();
        bool Exists(string title);
    }
}
