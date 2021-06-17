using GraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.Project.Data
{
    public class GraphQlDbContext : DbContext
    {
        public GraphQlDbContext(DbContextOptions<GraphQlDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
