using GraphQL.Project.Models;
using System.Collections.Generic;

namespace GraphQL.Project.Interfaces
{
    public interface IMenuService
    {
        IReadOnlyCollection<Menu> GetMenus();
        Menu AddMenu(Menu menu);
    }
}
