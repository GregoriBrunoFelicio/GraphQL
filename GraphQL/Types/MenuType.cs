using GraphQL.Project.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public sealed class MenuType : ObjectGraphType<Menu>
    {
        public MenuType()
        {
            Field(m => m.Id);
            Field(m => m.Name);
            Field(m => m.ImageUrl);
        }
    }
}
