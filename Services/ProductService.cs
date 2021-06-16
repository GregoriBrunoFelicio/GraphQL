using GraphQL.Interfaces;
using GraphQL.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Services
{
    public class ProductService : IProduct
    {
        private static readonly IList<Product> products = new List<Product>
        {
            new Product
            {
                Id = 0, Name = "Coffe"
            },
            new Product
            {
                Id = 1, Name = "Tea"
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
