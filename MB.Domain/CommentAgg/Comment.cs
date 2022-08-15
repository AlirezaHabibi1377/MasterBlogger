﻿using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.ArticleAgg;

namespace MB.Domain.CommentAgg
{
    public class Comment
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public int Status { get; private set; }
        public DateTime CreationDate { get; private set; }
        public long ArticleId1 { get; private set; }
        public Article Article { get; private set; }

        protected Comment()
        {
        }

        public Comment(string name, string email, string message, long articleId1)
        {
            Name = name;
            Email = email;
            Message = message;
            ArticleId1 = articleId1;
            CreationDate = DateTime.Now;
            Status = Statuses.New;
        }
    }
}
