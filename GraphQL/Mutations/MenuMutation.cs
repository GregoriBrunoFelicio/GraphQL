using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Project.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Mutations
{
    public class MenuMutation : ObjectGraphType
    {
        private readonly IMenuService menuService;

        public MenuMutation(IMenuService menuService)
        {
            this.menuService = menuService;
            CreateMenu();
        }

        private void CreateMenu() =>
            Field<MenuType>("createMenu",
                arguments: new QueryArguments(
                    new QueryArgument<MenuInputType> { Name = "menu" }
                ), resolve:
                context =>
                    menuService.AddMenu(context.GetArgument<Menu>("menu")));
    }
}
