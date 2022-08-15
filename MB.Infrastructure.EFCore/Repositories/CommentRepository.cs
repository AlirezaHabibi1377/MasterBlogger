using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MB.Application.Contracts.Comment;
using MB.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MasterBloggerContext _context;

        public CommentRepository(MasterBloggerContext context)
        {
            _context = context;
        }

        public void CreateAndSave(Comment entity)
        {
            _context.Comments.Add(entity);
            _context.SaveChanges();
        }

        public List<CommentViewModel> GetList()
        {
            return  _context.Comments.Include(x => x.Article)
                .Select(x => new CommentViewModel
                {
                    Id = x.Id,
                    CreationDate = x.CreationDate.ToString(CultureInfo.InvariantCulture),
                    Email = x.Email,
                    Message = x.Message,
                    Name = x.Name,
                    Status = x.Status,
                    Article = x.Article.Title
                }).ToList();
        }
    }
}
