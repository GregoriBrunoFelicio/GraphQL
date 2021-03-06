using GraphQL.Project.GraphQL.Mutations;
using GraphQL.Project.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(ProductQuery productQueries, ProductMutation productMutation)
        {
            Query = productQueries;
            Mutation = productMutation;
        }
    }
}
