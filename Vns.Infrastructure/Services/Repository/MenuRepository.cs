using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vns.Core.Commons;
using Vns.Core.Entities;
using Vns.Infrastructure.Data;
using Vns.Infrastructure.Services.IRepository;

namespace Vns.Infrastructure.Services.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private List<Menu> menuAdmin = new List<Menu>()
            {
                new Menu
                {
                    Id = 1,
                    Name = "Giới Thiệu",
                    Url = "/about",
                    Controller = "about",
                    Action = "index",
                    CreatedBy = "Admin",
                    CreatedDate = new DateTime(),
                    ApprovedBy = "Admin",
                    ApprovedDate = new DateTime(),
                    Index = 1,
                    Status = true,
                    IsUser = false,
                    IsAdmin = true
                },
                 new Menu
                {
                    Id = 2,
                    Name = "Bài viết",
                    Url = "/articles",
                    Controller = "about",
                    Action = "index",
                    CreatedBy = "Admin",
                    CreatedDate = new DateTime(),
                    ApprovedBy = "Admin",
                    ApprovedDate = new DateTime(),
                    Index = 1,
                    Status = true,
                    IsUser = false,
                    IsAdmin = true
                },
                new Menu
                {
                    Id = 3,
                    Name = "Nghệ nhân",
                    Url = "/artists",
                    Controller = "about",
                    Action = "index",
                    CreatedBy = "Admin",
                    CreatedDate = new DateTime(),
                    ApprovedBy = "Admin",
                    ApprovedDate = new DateTime(),
                    Index = 3,
                    Status = true,
                    IsUser = false,
                    IsAdmin = true
                },
                new Menu {
                    Id = 4,
                    Name = "Bình luận",
                    Url = "/comments",
                    Controller = "about",
                    Action = "index",
                    CreatedBy = "Admin",
                    CreatedDate = new DateTime(),
                    ApprovedBy = "Admin",
                    ApprovedDate = new DateTime(),
                    Index = 4,
                    Status = true,
                    IsUser = false,
                    IsAdmin = true
                },
            };

        public List<Menu> getMenuAdmin()
        {
            return menuAdmin;
        }

        public List<Menu> getMenuUser()
        {
            throw new NotImplementedException();
        }
    }
}
