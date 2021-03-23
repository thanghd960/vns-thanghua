using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vns.Core.Entities;
using Vns.Infrastructure.Services;

namespace Vns.Infrastructure.Data
{
    public class VnstyleDbContext : IdentityDbContext, IDbContext
    {
        public VnstyleDbContext(DbContextOptions<VnstyleDbContext> options)
                    : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTag> ArticleTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            InitCategory(builder);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var table = entityType.GetTableName();
                if (table.StartsWith("AspNet"))
                {
                    entityType.SetTableName(table.Substring(6));
                }
            };
            
            


        }

        public int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : class, new()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
            // return Database.
        }


        private void InitCategory(ModelBuilder builder)
        {
            List<Category> categories = new List<Category>();
            Category category1 = new Category()
            {
                Id = 1,
                Name = "TA",
                Description = "Hình Xăm",
                Index = 1,
                Status = true,
                ApprovedBy = "admin",
                ApprovedDate = DateTime.Now,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now
            };


            Category category2 = new Category()
            {
                Id = 2,
                Name = "PI",
                Description = "Xỏ khuyên",
                Index = 2,
                Status = true,
                ApprovedBy = "admin",
                ApprovedDate = DateTime.Now,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now
            };

            Category category3 = new Category()
            {
                Id = 3,
                Name = "PF",
                Description = "Artist",
                Index = 3,
                Status = true,
                ApprovedBy = "admin",
                ApprovedDate = DateTime.Now,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now
            };

            Category category4 = new Category()
            {
                Id = 4,
                Name = "EV",
                Description = "Sự kiện",
                Index = 4,
                Status = true,
                ApprovedBy = "admin",
                ApprovedDate = DateTime.Now,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now
            };

            Category category5 = new Category()
            {
                Id = 5,
                Name = "CO",
                Description = "Khoá học",
                Index = 5,
                Status = true,
                ApprovedBy = "admin",
                ApprovedDate = DateTime.Now,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now
            };

            Category category6 = new Category()
            {
                Id = 6,
                Name = "IN",
                Description = "Giới thiệu",
                Index = 6,
                Status = true,
                ApprovedBy = "admin",
                ApprovedDate = DateTime.Now,
                CreatedBy = "admin",
                CreatedDate = DateTime.Now
            };

            categories.Add(category1);
            categories.Add(category2);
            categories.Add(category3);
            categories.Add(category4);
            categories.Add(category5);
            categories.Add(category6);

            builder.Entity<Category>().HasData(categories);
        }
    }
}
