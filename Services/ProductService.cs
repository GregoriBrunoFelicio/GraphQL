using GraphQL.Models;
using GraphQL.Project.Data;
using GraphQL.Project.Interfaces;
using System.Collections.Generic;

namespace GraphQL.Project.Services
{
    public class ProductService : IProductService
    {
        private readonly GraphQlDbContext _graphQlDbContext;

        public ProductService(GraphQlDbContext graphQlDbContext)
        {
            _graphQlDbContext = graphQlDbContext;
        }

        public IList<Product> GetAllProducts() => products;

        public Product GetProductById(int id) => products.FirstOrDefault(x => x.Id == id);

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public Product UpdateProduct(Product product, int id)
        {
            products[id] = product;
            return product;
        }

        public void DelteProduct(int id) => products.RemoveAt(id);
    }
}
