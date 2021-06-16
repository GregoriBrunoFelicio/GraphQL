using GraphQL.Models;
using GraphQL.Project.GraphQL.Types;
using GraphQL.Project.Interfaces;
using GraphQL.Types;

namespace GraphQL.Project.GraphQL.Mutations
{
    public class ProductMutation : ObjectGraphType
    {
        private readonly IProductService _productService;
        public ProductMutation(IProductService productService)
        {
            _productService = productService;
            CreateProduct();
            UpdateProduct();
            DeleteProduct();
        }

        private void CreateProduct() =>
            Field<ProductType>("createProduct",
                arguments: new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }),
                resolve: context => _productService.AddProduct(context.GetArgument<Product>("product")));

        private void UpdateProduct() =>
            Field<ProductType>("updateProduct", arguments:
                new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" },
                    new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context => _productService.UpdateProduct(
                    context.GetArgument<Product>("product"),
                    context.GetArgument<int>("Id")));

        private void DeleteProduct() =>
            Field<StringGraphType>("deleteProduct",
                   arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                    resolve: context =>
                    {
                        var productId = context.GetArgument<int>("id");
                        _productService.DelteProduct(productId);
                        return $"The product {productId} has been deleted";
                    });

    }
}
