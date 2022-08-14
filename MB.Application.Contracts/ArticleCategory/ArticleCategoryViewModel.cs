using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.ArticleCategory
{
    public class ArticleCategoryViewModel
    { 
        public long Id { get; set; }
        public string Title { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
