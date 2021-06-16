using GraphQL.Models;
using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Mutations
{
    public class ProductMutation : ObjectGraphType
    {
        public ProductMutation(IProductService productService)
        {
            Field<ProductType>("createProduct",
            arguments: new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }),
            resolve: context => productService.AddProduct(context.GetArgument<Product>("product")));

            Field<ProductType>("updateProduct", arguments:
            new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" },
            new QueryArgument<IntGraphType> { Name = "Id" }),
            resolve: context =>
                productService.UpdateProduct(
                    context.GetArgument<Product>("product"),
                    context.GetArgument<int>("Id")));

            Field<StringGraphType>("deleteProduct",
                    arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                    resolve: context =>
                    {
                        var productId = context.GetArgument<int>("id");
                        productService.DelteProduct(productId);
                        return $"The product {productId} has been deleted";
                    });

        }
    }
}
