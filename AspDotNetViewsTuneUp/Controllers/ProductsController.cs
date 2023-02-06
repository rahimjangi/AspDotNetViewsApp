using Microsoft.AspNetCore.Mvc;

namespace AspDotNetViewsTuneUp.Controllers
{
    public class ProductsController : Controller
    {
        [Route("products")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("product-serch/{ProductId?}")]
        public IActionResult Search(int? ProductId)
        {
            ViewBag.ProductId = ProductId;
            return View();
        }
        [Route("product-order")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
