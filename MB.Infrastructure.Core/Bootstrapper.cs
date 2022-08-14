using MB.Application;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using MB.Domain.ArticleCategoryAgg.Services;
using MB.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.Core
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
            services.AddTransient<IArticleCategoryValidatorService, ArticleCategoryValidatorService>();

            services.AddDbContext<MasterBloggerContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}
