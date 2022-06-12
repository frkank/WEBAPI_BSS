using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCrud.Entity;

namespace WebApiCrud.WepApi.Model
{
    public class AllModel
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        //public List<ProductCategory> ProductCategories { get; set; }
        
    }
}
