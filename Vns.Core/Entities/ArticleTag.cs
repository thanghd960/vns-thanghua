using System;
namespace Vns.Core.Entities
{
    public class ArticleTag : BaseEntity
    {
        public int ArticleId { get; set; }
        public int HashTag { get; set; }
    }
}
