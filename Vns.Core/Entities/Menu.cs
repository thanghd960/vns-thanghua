using System;
namespace Vns.Core.Entities
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool IsUser { get; set; }
        public bool IsAdmin { get; set; }
    }
}
