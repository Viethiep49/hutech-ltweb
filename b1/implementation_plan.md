# Kế hoạch thực hiện bài tập Lab 6 - HTML & CSS

Dựa trên tài liệu yêu cầu `bai1_html css.docx`, dưới đây là kế hoạch chi tiết để xây dựng trang web.

## 1. Cấu trúc thư mục
Theo yêu cầu, cấu trúc thư mục sẽ như sau:
```
mssv_hoten/ (Ví dụ: lab6_project)
├── index.html
├── css/
│   └── style.css
└── images/ (Đã có sẵn)
    ├── logo.jpg
    ├── slider_1.jpg
    ├── san_pham_1.jpg ... san_pham_9.jpg
    ├── icon_1.jpg ... icon_3.jpg
```

## 2. Các bước thực hiện

### Bước 1: Khởi tạo dự án
- Tạo thư mục dự án (ví dụ `lab6_project` hoặc làm trực tiếp tại thư mục hiện tại nếu muốn).
- Tạo thư mục `css`.
- Đảm bảo thư mục `images` đã chứa đầy đủ ảnh (đã kiểm tra và thấy đầy đủ).
- Tạo file `index.html`.
- Tạo file `css/style.css`.

### Bước 2: Xây dựng HTML (`index.html`)
Sử dụng `DOCTYPE XHTML 1.0 Transitional` theo yêu cầu.

**Cấu trúc chính:**
- `div#container`: Bao quanh toàn bộ nội dung.
- `div#header`:
    - `div.logo`: Chứa ảnh `logo.jpg`.
    - `div.nav`: Chứa menu `ul > li > a` (Trang chủ, Giới thiệu, Dự án, Liên hệ).
- `div#slider`: Chứa ảnh `slider_1.jpg`.
- `div#aside` (Menu trái):
    - Tiêu đề `h2` ("Thiết kế mới", "Nội thất cao cấp").
    - Danh sách `ul > li > a`.
- `div#content` (Nội dung chính):
    - `div.mau_thiet_ke_moi`:
        - Các khối `div.san_pham` (Ảnh, Tiêu đề h3, Mô tả p).
    - `div.noi_that_cao_cap`:
        - Các khối `div.sp_cao_cap` (Ảnh, Tiêu đề h3, Mô tả p, Link chi tiết).
- `div#footer`:
    - `div.dia_chi`: Thông tin liên hệ.
    - `div.icon`: Các icon mạng xã hội/liên kết.
- Sử dụng `div.clear` để ngắt dòng float.

### Bước 3: Định kiểu CSS (`css/style.css`)
Thực hiện style theo từng phần như mô tả trong tài liệu:

1.  **Thiết lập chung**:
    - `body`, `container` (width: 960px, margin: auto).
2.  **Header**:
    - Float logo sang trái, nav sang phải.
    - Style cho menu (inline, padding, text-decoration, colors).
3.  **Slider**:
    - Kích thước, canh lề.
4.  **Aside (Menu trái)**:
    - Background, border, padding cho các mục menu.
5.  **Content**:
    - Layout 3 cột cho sản phẩm.
    - Style cho `mau_thiet_ke_moi` và `noi_that_cao_cap`.
    - Typography cho h3, p.
    - Button "Chi tiết".
6.  **Footer**:
    - Chia cột cho phần địa chỉ và icon.

### Bước 4: Kiểm tra và Hoàn thiện
- Mở `index.html` trên trình duyệt để kiểm tra hiển thị.
- So sánh với các hình ảnh mẫu trong file docx.
- Tinh chỉnh CSS nếu cần thiết (khoảng cách, màu sắc, phông chữ).

## 3. Ghi chú
- Tài liệu yêu cầu tuân thủ cấu trúc XHTML cũ (`xmlns`, thẻ đóng `/>`).
- Các class và id phải đặt đúng tên như trong hướng dẫn (`#header`, `.san_pham`, `.sp_cao_cap`, v.v.).
