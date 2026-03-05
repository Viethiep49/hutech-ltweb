using Microsoft.AspNetCore.Mvc;
using _2380600637_TruongVietHiep_Buoi4.Models;
using System.Collections.Generic;
using System.Linq;

namespace _2380600637_TruongVietHiep_Buoi4.Controllers
{
    public class CongViecController : Controller
    {
        private static List<CongViec> congViecs = new List<CongViec>
        {
            new CongViec { Id = 1, TenCongViec = "Đi chợ", TrangThaiHoanThanh = true },
            new CongViec { Id = 2, TenCongViec = "Chơi thể thao", TrangThaiHoanThanh = false },
            new CongViec { Id = 3, TenCongViec = "Chơi game", TrangThaiHoanThanh = false },
            new CongViec { Id = 4, TenCongViec = "Học bài", TrangThaiHoanThanh = true }
        };

        public IActionResult Index()
        {
            return View(congViecs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CongViec congViec)
        {
            if (ModelState.IsValid)
            {
                if(congViecs.Any(x => x.Id == congViec.Id))
                {
                    ModelState.AddModelError("Id", "Mã công việc đã tồn tại.");
                    return View(congViec);
                }
                congViecs.Add(congViec);
                return RedirectToAction(nameof(Index));
            }
            return View(congViec);
        }

        public IActionResult Edit(int id)
        {
            var task = congViecs.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(CongViec congViec)
        {
            if (ModelState.IsValid)
            {
                var existingTask = congViecs.FirstOrDefault(t => t.Id == congViec.Id);
                if (existingTask != null)
                {
                    existingTask.TenCongViec = congViec.TenCongViec;
                    existingTask.TrangThaiHoanThanh = congViec.TrangThaiHoanThanh;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(congViec);
        }

        public IActionResult Details(int id)
        {
            var task = congViecs.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        public IActionResult Delete(int id)
        {
            var task = congViecs.FirstOrDefault(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var task = congViecs.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                congViecs.Remove(task);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
