using System;
using System.Collections.Generic;
using System.Web.Http;
using WebAPI_Example.Models;

namespace WebAPI_Example.Controllers
{
    public class ProductsController : ApiController
    {
        public IEnumerable<Product> Get()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 55000 },
                new Product { Id = 2, Name = "Smartphone", Price = 25000 },
                new Product { Id = 3, Name = "Headphones", Price = 3000 }
            };
            return products;
        }
    }
}
