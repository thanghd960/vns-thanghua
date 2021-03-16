using System;
namespace Vns.Core.Entities
{
    public class Article : BaseEntity
    {

        public string Title { get; set; }
        public string DescriptionShort { get; set; }
        public string Content { get; set; }
        public int View { get; set; }
        public bool IsHomePage { get; set; }
        public bool IsFeature { get; set; }
        public bool IsTrendingNow { get; set; }
        public int CategoryId { get; set; }
        public int ImageId { get; set; }

        public Article()
        {
            View = 0;
            IsHomePage = false;
            IsFeature = false;
            IsTrendingNow = false;
        }

    }
}
