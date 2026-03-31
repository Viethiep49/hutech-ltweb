using System.ComponentModel.DataAnnotations;

namespace _2380600637_TruongVietHiep_Buoi5.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sách là bắt buộc.")]
        [StringLength(100, ErrorMessage = "Tên sách không được vượt quá 100 ký tự.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tên tác giả là bắt buộc.")]
        [StringLength(50, ErrorMessage = "Tên tác giả không được vượt quá 50 ký tự.")]
        public string Author { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn danh mục.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Giá bán là bắt buộc.")]
        [Range(1000, 10000000, ErrorMessage = "Giá bán phải nằm trong khoảng từ 1,000 VND đến 10,000,000 VND.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Đường dẫn hình ảnh là bắt buộc.")]
        [Url(ErrorMessage = "Đường dẫn hình ảnh không hợp lệ.")]
        public string ImageUrl { get; set; } = string.Empty;

        [StringLength(1000, ErrorMessage = "Mô tả không được vượt quá 1000 ký tự.")]
        public string Description { get; set; } = string.Empty;
    }
}
