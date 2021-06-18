using System.Collections.Generic;

namespace GraphQL.Project.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public virtual ICollection<SubMenu> SubMenus { get; set; }
    }
}
