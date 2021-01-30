using System;
using System.Collections.Generic;
using Vns.Core.Entities;

namespace Vns.Infrastructure.ModelView.ArticleModelView
{
    public class ArticleModelView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public int Viewed { get; set; }
        public List<Image> Images { get; set; }
        public List<Tag> Tags { get; set; }
        public CategoryArticle category { get; set; }
    }
}
