using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _2380600637_TruongVietHiep_Buoi5.Models;

namespace _2380600637_TruongVietHiep_Buoi5.ViewComponents
{
    public class CategorySidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categoryCounts = MockData.Categories.Select(c => new
            {
                Category = c,
                Count = MockData.Books.Count(b => b.CategoryId == c.Id)
            }).ToList();

            return View(categoryCounts);
        }
    }
}
