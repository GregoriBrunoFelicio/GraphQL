using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("ImageUrl");
        }
    }
}
