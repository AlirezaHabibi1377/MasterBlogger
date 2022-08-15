﻿using System;
using System.Collections.Generic;
using System.Text;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;
using MB.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore
{
    public class MasterBloggerContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }

        public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var assembly = typeof(ArticleMapping).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            modelBuilder.ApplyConfiguration(new CommentMapping());
            modelBuilder.ApplyConfiguration(new ArticleMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
