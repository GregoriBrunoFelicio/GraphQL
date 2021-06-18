using GraphQL.Project.Data;
using GraphQL.Project.Interfaces;
using GraphQL.Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Project.Services
{
    public class SubMenuService : ISubmenuService
    {
        private readonly GraphQlDbContext context;

        public SubMenuService(GraphQlDbContext context) => this.context = context;

        public IReadOnlyCollection<SubMenu> GetSubMenus() => context.SubMenus.ToList();

        public IReadOnlyCollection<SubMenu> GetSubMenus(int menuId) =>
            this.context.SubMenus.Where(x => x.MenuId == menuId).ToList();

        public SubMenu AddSubMenu(SubMenu subMenu)
        {
            context.Add(subMenu);
            context.SaveChanges();
            return subMenu;
        }
    }
}
