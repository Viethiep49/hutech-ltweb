using Microsoft.AspNetCore.Mvc;
using thuongmaidientu.Repositories;

namespace thuongmaidientu.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        // Public view: All products or by category
        public async Task<IActionResult> Index(int? categoryId)
        {
            var products = await _productRepository.GetAllAsync();
            if (categoryId.HasValue)
            {
                products = products.Where(p => p.CategoryId == categoryId.Value);
            }
            ViewBag.Categories = await _categoryRepository.GetAllAsync();
            return View(products);
        }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
