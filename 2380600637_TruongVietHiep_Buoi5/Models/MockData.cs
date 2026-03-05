using System.Collections.Generic;

namespace _2380600637_TruongVietHiep_Buoi5.Models
{
    public static class MockData
    {
        public static List<Category> Categories { get; set; } = new List<Category>
        {
            new Category { Id = 1, Name = "Cuộc sống" },
            new Category { Id = 2, Name = "Lập trình" },
            new Category { Id = 3, Name = "Sức khỏe" }
        };

        public static List<Book> Books { get; set; } = new List<Book>
        {
            new Book 
            { 
                Id = 1, 
                Title = "Cho Tôi Xin Một Vé Đi Tuổi Thơ", 
                Author = "Nguyễn Nhật Ánh", 
                CategoryId = 1, 
                Price = 61600, 
                ImageUrl = "https://cdn0.fahasa.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/8/9/8934974154944_2.jpg",
                Description = "Truyện đưa người đọc trở về tuổi thơ tinh nghịch với những cái nhìn đời ngộ nghĩnh của lũ trẻ."
            },
            new Book 
            { 
                Id = 2, 
                Title = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", 
                Author = "Nguyễn Nhật Ánh", 
                CategoryId = 1, 
                Price = 75000, 
                ImageUrl = "https://cdn0.fahasa.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/8/9/8934974154937.jpg",
                Description = "Câu chuyện tuổi thơ đầy xúc động, mộc mạc và chân thành."
            },
            new Book 
            { 
                Id = 3, 
                Title = "Mắt Biếc", 
                Author = "Nguyễn Nhật Ánh", 
                CategoryId = 1, 
                Price = 85000, 
                ImageUrl = "https://cdn0.fahasa.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/8/9/8934974154951.jpg",
                Description = "Câu chuyện tình buồn lãng mạn và đầy trắc trở."
            },
            new Book 
            { 
                Id = 4, 
                Title = "Bảy Bước Tới Mùa Hè", 
                Author = "Nguyễn Nhật Ánh", 
                CategoryId = 1, 
                Price = 72000, 
                ImageUrl = "https://cdn0.fahasa.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/m/image_195509_1_45260.jpg",
                Description = "Câu chuyện vui nhộn học trò ở một làng quê."
            },
            new Book 
            { 
                Id = 5, 
                Title = "Java Core Fundamentals", 
                Author = "Oracle Press", 
                CategoryId = 2, 
                Price = 250000, 
                ImageUrl = "https://cdn0.fahasa.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/9/7/9781260463415_1.jpg",
                Description = "Comprehensive guide to Java."
            },
            new Book 
            { 
                Id = 6, 
                Title = "ASP.NET Core MVC In Action", 
                Author = "Andrew Lock", 
                CategoryId = 2, 
                Price = 300000, 
                ImageUrl = "https://cdn0.fahasa.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/9/7/9781617298301.jpg",
                Description = "A complete resource for ASP.NET Core MVC."
            }
        };
    }
}
