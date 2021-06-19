using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Queries
{
    public class MenuQuery : ObjectGraphType
    {
        private readonly IMenuService menuService;
        public MenuQuery(IMenuService menuService)
        {
            this.menuService = menuService;
            GetMenus();
        }

        private void GetMenus() => Field<ListGraphType<MenuType>>("menu", resolve: context => menuService.GetMenus());
    }
}
