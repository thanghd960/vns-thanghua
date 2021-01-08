using System;
namespace Vns.Core.Entities
{
    public class SocialMedia : BaseEntity
    { 
        public string Name { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
    }
}
