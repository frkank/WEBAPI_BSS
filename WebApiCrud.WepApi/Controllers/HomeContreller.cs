using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCrud.Bussiness.Abstract;
using WebApiCrud.Entity;
using WebApiCrud.WepApi.Model;

namespace WebApiCrud.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeContreller : ControllerBase
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public HomeContreller(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        [HttpGet("GetProducts")]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }
        [HttpGet("GetCategories")]
        public IEnumerable<Category> GetCategories()
        {
            return _categoryService.GetAll();
        }
        [HttpPost("SetProduct")]
        public Product SetProduct([FromBody] Product product)
        {
            Product product1 = new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice,
                CreateDate = product.CreateDate,
                CategoryId = product.CategoryId
            };
            return _productService.Create(product1);
        }
        [HttpPost("SetCategory")]
        public Category SetCategory([FromBody] Category category)
        {
            return _categoryService.Create(category);
        }
        [HttpPut("UpdateProduct")]
        public Product UpdateProduct([FromBody] Product product)
        {
            Product product1 = new Product()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice,
                CreateDate = product.CreateDate,
                CategoryId = product.CategoryId
            };
            return _productService.Update(product1);
        }
        [HttpPut("UpdateCategory")]
        public Category UpdateCategory([FromBody] Category category)
        {
            return _categoryService.Update(category);

        }
        [HttpDelete("product/{productId}")]
        public void DeleteProduct(int productId)
        {
            _productService.Delete(_productService.GetById(productId));
        }
        [HttpDelete("category/{categoryId}")]
        public void DeleteCategory(int categoryId)
        {
            _categoryService.Delete(_categoryService.GetById(categoryId));
        }
    }
}
