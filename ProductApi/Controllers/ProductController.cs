using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Services;
using System.Runtime.CompilerServices;

namespace ProductApi.Controllers
{
    public class ProductController :ControllerBase  
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet]
        public IEnumerable<Product> ProductList()
        {
            var productList = productService.GetProductList();
            return productList;
        }
        [HttpGet]
        public Product GetProductById(int id)
        {
            var product = productService.GetProductById(id);
            return product;
        }
        [HttpPost]
        public Product AddProduct(Product product)
        {
            var result = productService.AddProduct(product);
            return result;
        }
        [HttpPut]
        public Product UpdateProduct(Product product)
        {
            var result = productService.UpdateProduct(product); 
            return result;
        }
        [HttpDelete("{id}")]
        public bool DeleteProduct(int Id)
        {
            return productService.DeleteProduct(Id);
        }

    }
}
