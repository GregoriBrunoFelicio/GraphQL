using GraphQL.Project.Data;
using GraphQL.Project.Interfaces;
using GraphQL.Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Project.Services
{
    public class MenuServices : IMenuService
    {
        private readonly GraphQlDbContext context;

        public MenuServices(GraphQlDbContext context) => this.context = context;

        public IReadOnlyCollection<Menu> GetMenus() => context.Menus.ToList();

        public Menu AddMenu(Menu menu)
        {
            context.Add(menu);
            context.SaveChanges();
            return menu;
        }
    }
}
