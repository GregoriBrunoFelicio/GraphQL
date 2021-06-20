using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public class SubmenuInputType : InputObjectGraphType
    {
        public SubmenuInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Description");
            Field<StringGraphType>("ImageUrl");
            Field<FloatGraphType>("Price");
            Field<IntGraphType>("MenuId");
        }
    }
}
