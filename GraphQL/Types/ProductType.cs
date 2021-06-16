using GraphQL.Models;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Types
{
    public sealed class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field(p => p.Price);
        }
    }
}
