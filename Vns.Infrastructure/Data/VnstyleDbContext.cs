using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vns.Core.Entities;

namespace Vns.Infrastructure.Data
{
    public class VnstyleDbContext : IdentityDbContext
    {
        public VnstyleDbContext(DbContextOptions<VnstyleDbContext> options)
                    : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<ArticleImage> ArticleImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<CategoryArticle> Categories { get; set; }
    }
}
