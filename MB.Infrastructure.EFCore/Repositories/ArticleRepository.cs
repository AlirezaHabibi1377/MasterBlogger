using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.ArticleAgg;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleRepository(MasterBloggerContext context)
        {
            _context = context;
        }
    }
}
