using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public class ProductInputType : InputObjectGraphType
    {
        public ProductInputType()
        {
            Field<IntGraphType>("Id");
            Field<StringGraphType>("Name");
            Field<FloatGraphType>("Price");
        }
    }
}
