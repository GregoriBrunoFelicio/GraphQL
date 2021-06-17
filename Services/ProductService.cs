using GraphQL.Models;
using GraphQL.Project.Data;
using GraphQL.Project.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Project.Services
{
    public class ProductService : IProductService
    {
        private readonly GraphQlDbContext _graphQlDbContext;

        public ProductService(GraphQlDbContext graphQlDbContext) => _graphQlDbContext = graphQlDbContext;

        public IList<Product> GetAllProducts() => _graphQlDbContext.Products.ToList();

        public Product GetProductById(int id) => _graphQlDbContext.Products.Find(id);

        public Product AddProduct(Product product)
        {
            _graphQlDbContext.Products.Add(product);
            _graphQlDbContext.SaveChanges();
            return product;
        }

        public Product UpdateProduct(Product product, int id)
        {
            var productFromDb = _graphQlDbContext.Products.Find(id);
            _graphQlDbContext.Entry(productFromDb).CurrentValues.SetValues(product);
            _graphQlDbContext.SaveChanges();
            return product;
        }

        public void DelteProduct(int id)
        {
            var productFromDb = _graphQlDbContext.Products.Find(id);
            _graphQlDbContext.Remove(productFromDb);
            _graphQlDbContext.SaveChanges();
        }
    }
}
