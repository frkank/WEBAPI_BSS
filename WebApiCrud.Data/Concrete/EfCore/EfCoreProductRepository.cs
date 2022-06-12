using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Data.Abstract;
using WebApiCrud.Entity;

namespace WebApiCrud.Data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, WebApiCrudContext>, IProductRepository
    {
        public void Create(Product entity, int[] categoryIds)
        {
            using (var context = new WebApiCrudContext())
            {
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public Product GetByIdWithCategories(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            using (var context = new WebApiCrudContext())
            {
                //var products = context.Products.ToList();
                //foreach (var item in products)
                //{
                //    item.Category = context.Categories.Find(item.CategoryId);
                //}
                return context.Products.Include(x => x.Category).ToList();
            }
        }

        public void Update(Product entity, int[] categoryIds)
        {
            throw new NotImplementedException();
        }
    }

}
