using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.CommentAgg;

namespace MB.Infrastructure.EFCore.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MasterBloggerContext _context;

        public CommentRepository(MasterBloggerContext context)
        {
            _context = context;
        }
    }
}
