using Microsoft.AspNetCore.Mvc;
using MVC01.Models;

namespace MVC01.Controllers
{
    [Route("Prod")]
    public class ProductController : Controller
    {

        #region Actions
        // Base URL/Product/Index
        public IActionResult Index()
        {
            return View();
        }
        // Base URL/Product/GetProduct
        [HttpGet("GetProduct")]
        public IActionResult GetProduct()
        {
            var products = new List<Product>()
            {
              new() { Id = 1, Name = "Iphone 16 PRO MAX"},
              new() { Id = 2, Name = "Iphone 17 PRO MAX"}
            };

            return Json(products);
        }
        // Base URL/Product/GetProductBYId/{id}
        [HttpGet("GetProductById")]
        public IActionResult GetProductById(int id)
        {
            if (id <= 0)
                return BadRequest();
            // else if (id == 0)
            //   return RedirectToAction(nameof(GetProduct));
            else if(id > 50)
                return Redirect("https://www.google.com");
             else
                return Json(new Product() { Id = id });
        }
        #endregion
        #region Routing
        [HttpGet("Json")]
        // Base URL/Product/JsonAction -- Convention routing
        // Base URL/Prod/JsonAction -- Attribute routing
        // Base URL/Prod/Json -- Attribute routing

        public IActionResult JsonAction()
        {
            return Json("Hello From Json Action");
        }

        #endregion

        #region Model Binding

        // Base URL/Product/Search?Name=Iphone17&Color=Black
        // Base URL/Product/Search?Name=Iphone17&Storage=512
        // Base URL/Product/Search?Storage=512

        public IActionResult Search(ProductFilter filter)
        {
            return View();
        }
        // Route: Base URL/Product/GetById/10 -> id = 0 , id2= 0
        // Route: Base URL/Product/GetById?id=20 -> id = 20 , id2= 0

        public IActionResult GetById([FromQuery] int id, [FromQuery(Name = "Id2")] int otherId)
        {
            return Json("");
        }


        #endregion

    }

    internal class Product
    {
        public int?    Id { get; internal set; }
        public string? Name { get; internal set; }
    }

     
}
