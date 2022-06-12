using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCrud.Bussiness.Abstract;
using WebApiCrud.Data.Abstract;
using WebApiCrud.Entity;

namespace WebApiCrud.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category Create(Category entity)
        {
            return _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category Update(Category entity)
        {
            return _categoryRepository.Update(entity);
        }
    }
}
