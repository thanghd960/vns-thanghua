using System;
using System.Collections.Generic;
using Vns.Core.Entities;

namespace Vns.Infrastructure.ModelView.ArticleModel
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FriendlyUrl { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public List<Image> Images { get; set; }
        public List<Tag> Tags { get; set; }
        public int Viewed { get; set; }
        public string PublishDate { get; set; }
        public string PublishBy { get; set; }

        public ERootCategory Category { get; set; }
    }
}
