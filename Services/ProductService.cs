using GraphQL.Models;
using GraphQL.Project.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Project.Services
{
    public class ProductService : IProductService
    {
        private static readonly IList<Product> products = new List<Product>
        {
            new Product
            {
                Id = 0, Name = "Coffe", Price = 2
            },
            new Product
            {
                Id = 1, Name = "Tea", Price = 3
            }
        };

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
