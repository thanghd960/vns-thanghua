using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vns.Core.Entities;

namespace Vns.Infrastructure.Services.IRepository
{
    public interface IMenuRepository
    {
        List<Menu> getMenuAdmin();
        List<Menu> getMenuUser();
    }
}
