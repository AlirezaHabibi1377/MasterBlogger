using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MB.Application.Contracts.Article;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public void CreateAndSave(Article entity)
        {
            _context.Articles.Add(entity);
            Save();
        }

        public List<ArticleViewModel> GetList()
        {
            return _context.Articles.Include(x => x.ArticleCategory)
                .Select(x => new ArticleViewModel
                {
                    Id = x.Id,
                    Title = x.Title,
                    ArticleCategory = x.ArticleCategory.Title,
                    IsDeleted = x.IsDeleted,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture)
                }).ToList();
        }

        public Article Get(long id)
        {
            return _context.Articles.FirstOrDefault(x=>x.Id==id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Exist(string title)
        {
            return _context.ArticleCategories.Any(x => x.Title == title);
        }
    }
}
