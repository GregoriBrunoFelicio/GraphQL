using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Project.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Mutations
{
    public class SubMenuMutation : ObjectGraphType
    {
        private readonly ISubmenuService submenuService;

        public SubMenuMutation(ISubmenuService submenuService)
        {
            this.submenuService = submenuService;
            CreateSubMenu();
        }

        private void CreateSubMenu() =>
            Field<SubMenuType>("createSubMenu",
                arguments: new QueryArguments(
                    new QueryArgument<SubMenuInputType> { Name = "SubMenu" }
                ), resolve:
                context =>
                    submenuService.AddSubMenu(context.GetArgument<SubMenu>("subMenu")));
    }
}
