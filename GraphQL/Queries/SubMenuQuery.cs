using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Queries
{
    public class SubMenuQuery : ObjectGraphType
    {
        private readonly ISubmenuService submenuService;

        public SubMenuQuery(ISubmenuService submenuService)
        {
            this.submenuService = submenuService;
            GetSubMenus();
        }

        public void GetSubMenus() =>
            Field<ListGraphType<SubMenuType>>(
                "subMenu",
                resolve: context => submenuService.GetSubMenus());

        public void GetSubMenusByMenuId() =>
            Field<SubMenuType>("subMenu",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context =>
                    submenuService.GetSubMenus(context.GetArgument<int>("Id")));

    }
}
