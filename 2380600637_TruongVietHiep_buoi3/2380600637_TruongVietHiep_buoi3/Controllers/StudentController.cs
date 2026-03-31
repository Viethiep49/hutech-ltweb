using Microsoft.AspNetCore.Mvc;
using _2380600637_TruongVietHiep_buoi3.Models;
using System.Collections.Generic;
using System.Linq;

namespace _2380600637_TruongVietHiep_buoi3.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> dsSinhVien = new List<Student>();
        public IActionResult Index()
        {
            return View();
        }
    
     [HttpPost]
        public IActionResult ShowKQ(Student sv)
        {
            dsSinhVien.Add(sv);

            int soLuong = dsSinhVien.Count(x => x.ChuyenNganh == sv.ChuyenNganh);

            ViewBag.SoLuong = soLuong;

            return View(sv);
        }
    } }

