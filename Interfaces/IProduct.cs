using GraphQL.Models;
using System.Collections.Generic;

namespace GraphQL.Interfaces
{
    public interface IProduct
    {
        IList<Product> GetAllProducts();
        Product GetProductById(int id);
        Product AddProduct(Product product);
        Product UpdateProduct(Product product, int id);
        void DelteProduct(int id);
    }
}
