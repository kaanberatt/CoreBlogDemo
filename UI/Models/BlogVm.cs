using System.Collections.Generic;
using EntityLayer.Concrete;

namespace UI.Models
{
    public class BlogVm
    {
        public Blog Blog {get; set;} 
        public List<Category> Categories { get; set; }
    }
}