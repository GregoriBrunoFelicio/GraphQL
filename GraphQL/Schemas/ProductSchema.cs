using GraphQL.Project.GraphQL.Queries;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(ProductQuery productQueries)
        {

            Query = productQueries;
        }
    }
}
