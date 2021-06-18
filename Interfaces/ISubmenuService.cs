using GraphQL.Project.Models;
using System.Collections.Generic;

namespace GraphQL.Project.Interfaces
{
    public interface ISubmenuService
    {
        IReadOnlyCollection<SubMenu> GetSubMenus();
        IReadOnlyCollection<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}
