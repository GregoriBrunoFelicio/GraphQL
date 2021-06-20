using GraphQL.Project.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public sealed class SubMenuType : ObjectGraphType<SubMenu>
    {
        public SubMenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
            Field(m => m.Description);
            Field(m => m.Price);
            Field(m => m.MenuId);
        }
    }
}
