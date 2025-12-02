using CCMovieDatabase.Data;
using CCMovieDatabase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CCMovieDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly MovieContext _context;

        public TestController(MovieContext context)
        {
            _context = context;
        }

        public ActionResult<IEnumerable<ProductDTO>> Index()
        {
            string extraInfo = "test";

            var productData = _context.Products
                .Include(p => p.Category)
                .Select(p => new ProductDTO()
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    CategoryId = p.CategoryId,
                    //Category = p.Category,
                    CategoryName = p.Category.Name,
                    Tag = extraInfo,
                })
                .ToList();

            return productData;
        }

    }
}
