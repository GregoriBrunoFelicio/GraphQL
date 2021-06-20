using GraphQL.Project.Interfaces;
using GraphQL.Project.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public sealed class MenuType : ObjectGraphType<Menu>
    {
        public MenuType(ISubmenuService submenuService)
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field<ListGraphType<SubMenuType>>("subMenus",
                resolve: context => submenuService.GetSubMenus(context.Source.Id));

        }
    }
}
