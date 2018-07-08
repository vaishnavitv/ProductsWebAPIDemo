using ProductsWebAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsWebAPIDemo.Controllers
{
    public class ProductsController : ApiController
    {
        List<Product> products = new List<Product>()
        {
            new Product{ Id = 1, Name = "Hardware", Category = "Hardware", Price= 600},
            new Product{ Id = 2, Name = "Mouse", Category = "Peripherals", Price= 20},
            new Product{ Id = 3, Name = "Monitor", Category = "Peripherals", Price= 200},
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
           Product product = products.FirstOrDefault<Product>(p => p.Id.Equals(id));
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
