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
                ImageUrl = "https://th.bing.com/th/id/OIP.5F7n17QHU-9D2QsdAtlieAHaHa?w=197&h=197&c=7&r=0&o=7&dpr=1.3&pid=1.7&rm=3",
                Description = "Truyện đưa người đọc trở về tuổi thơ tinh nghịch với những cái nhìn đời ngộ nghĩnh của lũ trẻ."
            },
            new Book 
            { 
                Id = 2, 
                Title = "Cuộc Sống Rất Giống Cuộc Đời", 
                Author = "Nguyễn Nhật Ánh", 
                CategoryId = 1, 
                Price = 75000, 
                ImageUrl = "https://lh3.googleusercontent.com/VVQ6cnql29pO91fpDzYO2zoEw9Ro-nzEMTV2hqpAb5H5kjtWa6bQap9PnOT03CJ6J2qs1XzMuNGKGdniSsw1hg24RMfk4ZbKgZ2OxeFPypUPeTpiWsmB7xLG5_P1YRN1D-RmNkw",
                Description = "Đàn ông tuổi 15 mơ ước thành đàn ông tuổi 20..."
            }
        };
    }
}
