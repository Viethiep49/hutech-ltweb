**Lab 6**

Hãy kết hợp html và css để tạo trang web với nội dung như sau:

![](media/image1.tmp){width="5.503179133858268in"
height="0.6229166666666667in"}![](media/image2.tmp){width="5.458333333333333in"
height="8.494757217847768in"}

Xây dựng cấu trúc thư mục cho website như
sau:![](media/image3.png){width="1.6233770778652667in"
height="1.6227668416447945in"}

**[Phân tích phần cơ bản trang web]{.underline}**

Trang web gồm những phần như: header, slider, aside, content, footer. do
đó sẽ sử dụng thẻ \<div\>\</div\> cho những thành phần này:

\<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\"
\"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"\>

\<html xmlns=\"http://www.w3.org/1999/xhtml\"\>

\<head\>

\<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"
/\>

\<title\>Untitled Document\</title\>

\<link rel=\"stylesheet\" type=\"text/css\" href=\"css/style.css\"/\>

\</head\>

------------------------------------------------------------------------

\<body\>

\<div id=\"header\"\>

**Nội dung header ở đây**

\</div\>

\<div class=\"clear\"\>\</div\> \<!\--xóa định dạng float\--\>

\<div id=\"slider\"\>

**Slider ở đây**

\</div\>

\<div id=\"aside\"\>

**Menu trái ở đây**

\</div\>

\<div id=\"content\"\>

**Nội dung ở đây**

\</div\>

\<div class=\"clear\"\>\</div\>\<!\-- xóa định dạng float\--\>

\<div id=\"footer\"\>

**Chân trang ở đây**

\</div\>

\</body\>

\</html\>

Sử dụng thẻ \<div id=\"container\"\> để bao các thẻ bên trong thẻ
\<body\> mục đích để dễ điều khiển phần khung của trang:

\<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\"
\"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\"\>

\<html xmlns=\"http://www.w3.org/1999/xhtml\"\>

\<head\>

\<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"
/\>

\<title\>Untitled Document\</title\>

\<link rel=\"stylesheet\" type=\"text/css\" href=\"css/style.css\"/\>

\</head\>

------------------------------------------------------------------------

\<body\>

**[\<div id=\"container\"\>]{.mark}**

\<div id=\"header\"\>

Nội dung header ở đây

\</div\>

\<div class=\"clear\"\>\</div\> \<!---ngăn chiếm dụng ko gian định dạng
float\--\>

\<div id=\"slider\"\>

Slider ở đây

\</div\>

\<div id=\"aside\"\>

Menu trái ở đây

\</div\>

\<div id=\"content\"\>

Nội dung ở đây

\</div\>

\<div class=\"clear\"\>\</div\>\<!\-- ngăn chiếm dụng ko gian định dạng
float\--\>

\<div id=\"footer\"\>

Chân trang ở đây

\</div\>

**[\</div\>]{.mark}**

\</body\>

\</html\>

**[Phần đầu: header]{.underline}**

Phân tích ta sẽ thấy phần header này gồm có 2 phần:

![](media/image4.tmp){width="6.301388888888889in"
height="0.8020833333333334in"}

**- Phần bên trái:**

\+ Phần này chứa logo

\+ Logo sử dụng image nên ta dùng thẻ \<img /\>,

**+ Phần bên phải:**

\+ Danh sách chứa link cũng thuộc dạng danh sách không có thứ tự vì vậy
ta cũng có thể sử dụng thẻ \<ul\>\<li\>.

Để tiện cho việc điều khiển các thẻ, ta sử dụng 2 thẻ \<div\> bao bên
ngoài phần bên trái và bên phải, vậy phần header ta có thể code như sau:

\<div id=\"header\"\>

\<div class=\"logo\"\>

\<img src=\"./images/logo.jpg\" width=\"140\" height=\"110\" /\>

\</div\>

\<div class=\"nav\"\>

\<ul\>

\<li\>\<a href=\"#\"\>Trang chủ\</a\>\</li\>

\<li\>\<a href=\"#\"\>Giới thiệu\</a\>\</li\>

\<li\>\<a href=\"#\"\>Dự án\</a\>\</li\>

\<li\>\<a href=\"#\"\>Liên hệ\</a\>\</li\>

\</ul\>

\</div\>

\</div\>

Hoàn thành xong phần header, click trình duyệt chạy và quan sát kết quả.

![](media/image5.tmp){width="3.100269028871391in"
height="3.3919608486439197in"}

**[PHẦN SLIDER]{.underline}**

![](media/image6.tmp){width="6.301388888888889in" height="2.6625in"}

SLIDER là một tấm hình, vậy ta chỉ cần sử dụng thẻ \<img\> là có thể
hoàn thành được nội dung này:

\<div id=\"slider\"\>

\<img src=\"./images/slider_1.jpg\" alt=\"\" /\>

\</div\>

*Hoàn thành xong phần slider, click trình duyệt xem kết quả.*

![](media/image7.tmp){width="6.301388888888889in"
height="4.379166666666666in"}

**[Phần menu trái : aside]{.underline}**

![](media/image8.tmp){width="1.925in" height="4.497896981627297in"}

Nhìn vào cấu trúc phần menu ở trên, ta thấy nội dung gồm 2 phần tương tự
nhau: phần \"thiết kế mới\", phần \"nội thất cao cấp\".

- Phần tiêu đề \"thiết kế mới\" và "nội thất cao cấp"ta sử dụng \<h2\>

- Phần còn lại là danh sách nhỏ, ta sử dụng thẻ danh sách \<ul\>\<li\>
  kèm thẻ \<a\>

\<div id=\"aside\"\>

\<h2\>Thiết kế mới\</h2\>

\<ul\>

\<li\>\<a href=\"#\"\>Văn phòng\</a\>\</li\>

\<li\>\<a href=\"#\"\>Phòng khách\</a\>\</li\>

\<li\>\<a href=\"#\"\>Phòng ngủ\</a\>\</li\>

\<li\>\<a href=\"#\"\>Phòng sách\</a\>\</li\>

\<li\>\<a href=\"#\"\>Nhà vườn\</a\>\</li\>

\</ul\>

\<h2\>Nội thất cao cấp\</h2\>

\<ul\>

\<li\>\<a href=\"#\"\>Văn phòng\</a\>\</li\>

\<li\>\<a href=\"#\"\>Phòng khách\</a\>\</li\>

\<li\>\<a href=\"#\"\>Phòng ngủ\</a\>\</li\>

\<li\>\<a href=\"#\"\>Phòng sách\</a\>\</li\>

\<li\>\<a href=\"#\"\>Nhà vườn\</a\>\</li\>

\</ul\>

\</div\>

**Chạy thử:**

![](media/image9.tmp){width="2.5835575240594926in"
height="3.6169805336832894in"}

**\**

**+ Phần nội dung: content**

![](media/image10.tmp){width="6.301388888888889in"
height="5.589583333333334in"}

Phần nội dung này ta thấy là các tấm hình được chia làm 3 cột gồm mẫu
thiết kế mới và nội thất cao cấp:

\<div id=\"content\"\>

\<div class=\"mau_thiet_ke_moi\"\>

\<div class=\"san_pham\"\>

\<img src=\"./images/san_pham_1.jpg\"/\>

\<h3\>TKPK 001\</h3\>

\<p\>Mẫu thiết kế phòng khách cho căn hộ mẫu PenHouse\</p\>

\</div\>

\<div class=\"san_pham\"\>

\<img src=\"./images/san_pham_2.jpg\"/\>

\<h3\>TKPK 002\</h3\>

\<p\>Mẫu thiết kế phòng khách cho căn hộ mẫu PenHouse\</p\>

\</div\>

\<div class=\"san_pham\"\>

\<img src=\"./images/san_pham_3.jpg\"/\>

\<h3\>TKPK 003\</h3\>

\<p\>Mẫu thiết kế phòng khách cho căn hộ mẫu PenHouse\</p\>

\</div\>

\</div\>\<!\--End Mau thiet ke moi\--\>

\<div class=\"clear\"\>\</div\>

\<div class=\"noi_that_cao_cap\"\>

\<div class=\"sp_cao_cap\"\>

\<img src=\"./images/san_pham_4.jpg\"/\>

\<h3\>SFD0234\</h3\>

\<p\>\<span style=\"color:#d23434\"\>GF\</span\> interior design tự hào
mang đến hàng loạt các thiết kế công trình văn phòng xuất sắc tại Việt
Nam\</p\>

\<a href=\"#\"\>Chi tiết\</a\>

\</div\>

\<div class=\"sp_cao_cap\"\>

\<img src=\"./images/san_pham_5.jpg\"/\>

\<h3\>SFD0234\</h3\>

\<p\>\<span style=\"color:#d23434\"\>GF\</span\> interior design tự hào
mang đến hàng loạt các thiết kế công trình văn phòng xuất sắc tại Việt
Nam\</p\>

\<a href=\"#\"\>Chi tiết\</a\>

\</div\>

\<div class=\"sp_cao_cap\"\>

\<img src=\"./images/san_pham_6.jpg\"/\>

\<h3\>SFD0234\</h3\>

\<p\>\<span style=\"color:#d23434\"\>GF\</span\> interior design tự hào
mang đến hàng loạt các thiết kế công trình văn phòng xuất sắc tại Việt
Nam\</p\>

\<a href=\"#\"\>Chi tiết\</a\>

\</div\>

\<div class=\"sp_cao_cap\"\>

\<img src=\"./images/san_pham_7.jpg\"/\>

\<h3\>SFD0234\</h3\>

\<p\>\<span style=\"color:#d23434\"\>GF\</span\> interior design tự hào
mang đến hàng loạt các thiết kế công trình văn phòng xuất sắc tại Việt
Nam\</p\>

\<a href=\"#\"\>Chi tiết\</a\>

\</div\>

\<div class=\"sp_cao_cap\"\>

\<img src=\"./images/san_pham_8.jpg\"/\>

\<h3\>SFD0234\</h3\>

\<p\>\<span style=\"color:#d23434\"\>GF\</span\> interior design tự hào
mang đến hàng loạt các thiết kế công trình văn phòng xuất sắc tại Việt
Nam\</p\>

\<a href=\"#\"\>Chi tiết\</a\>

\</div\>

\<div class=\"sp_cao_cap\"\>

\<img src=\"./images/san_pham_9.jpg\"/\>

\<h3\>SFD0234\</h3\>

\<p\>\<span style=\"color:#d23434\"\>GF\</span\> interior design tự hào
mang đến hàng loạt các thiết kế công trình văn phòng xuất sắc tại Việt
Nam\</p\>

\<a href=\"#\"\>Chi tiết\</a\>

\</div\>

\</div\>

\</div\>

Hoàn thành xong phần nội dung chính, click trình duyệt xem kết quả.

![](media/image11.tmp){width="4.533725940507437in"
height="5.317127077865267in"}

**[Phần cuối trang web: Footer]{.underline}**

footer chia ra làm 2 phần:

![](media/image12.tmp){width="6.301388888888889in"
height="0.7958333333333333in"}

Phần bên trái: phần này gồm có tên công ty, địa chỉ và điện thoại, cả 3
đều có thể sử dụng thẻ \<p\> đều được

\<div class=\"dia_chi\"\>

\<p style=\"padding-top:5px;padding-left:10px;\"\>GF Funiture\<br /\>

131 Ngô Gia Tự, P4, Q3, Tp Hồ Chí Minh\<br /\>

Điện thoại: 08 38 324587\</p\>

\</div\>

Phần bên phải: phần này gồm một danh sách các icon.

\<div class=\"icon\"\>

\<img src=\"images/icon_1.jpg\" /\>

\</div\>

\<div class=\"icon\"\>

\<img src=\"images/icon_2.jpg\" /\>

\</div\>

\<div class=\"icon\"\>

\<img src=\"images/icon_3.jpg\" /\>

\</div\>

------------------------------------------------------------------------

Hoàn thành xong phần liên footer, click trình duyệt xem kết quả.

![](media/image13.tmp){width="3.0919346019247596in"
height="2.725236220472441in"}

Với cấu trúc bên trên ta đã hoàn thành phần html cho trang web, việc còn
lại là sử dụng css để điều khiển các thành phần theo đúng design là
được.

**CSS**

*Từ kết quả của bài tập HTML trên, ta sẽ thêm thư mục css, bên trong có
chứa file style.css, và tạo một liên kết từ file html ban đầu tới file
style.css vừa tạo*

Từ kết quả của bài tập HTML, ta thêm vào một số class cho các thẻ để
tiện điều khiển nội dung, khi này ta có file index.html như sau:

**File style.css**

Giả sử giao diện có chiều rộng 960px và canh giữa, ta viết css cho
container như sau:

![](media/image14.tmp){width="1.675145450568679in"
height="0.9500820209973754in"}

Thuộc tính margin: auto; có ý nghĩa là margin-top , margin-bottom,
margin-left và margin-right có giá trị auto, do mang giá trị auto nên
trình duyệt sẽ tự động sắp xếp margin canh đều cho cả 2 bên trái và
phải, vì vậy thành phần sẽ nằm giữa.

**Chạy thử????**

**[Phần đầu: header]{.underline}**

![](media/image15.tmp){width="1.6in" height="1.8625951443569553in"}

*[Click để xem trình duyệt hiển thị]{.underline}*

Do nav là menu lệnh nên ta viết tiếp css cho nó như sau

![](media/image16.tmp){width="4.075353237095363in"
height="4.600399168853893in"}

**Chạy thử???.**

**[Phần slider:]{.underline}**

Là một tấm hình ta viết css cho slider như sau:

#slider

{

width:940px;

margin:10px 10px;

}

*Click để xem trình duyệt hiển thị*

Để các thành phần không chiếm chỗ của nhau ta viết thêm css cho class
clear như sau

.clear

{

clear:both;

}

# **[Phần menu trái: aside]{.underline}**

![](media/image17.tmp){width="4.692073490813648in"
height="5.017101924759405in"}

*Click để xem trình duyệt hiển thị*

Ta thấy phần gNav đã tương đối giống với design, chúng ta cần phải thêm
chiều cao, kết hợp với padding để đưa danh sách nằm canh giữa (theo
chiều dọc), ta code như sau:

div#gNav ul {

background: url(../images/bg_gnav.gif) repeat-x;

border: 1px solid #000;

height: 22px;

padding: 12px 0;

}

*Click để xem trình duyệt hiển thị*

### Phần nội dung : content

![](media/image18.tmp){width="1.5751367016622921in"
height="0.958416447944007in"}

*Click để xem trình duyệt hiển thị*

Mẫu thiết kế mới :

.mau_thiet_ke_moi

{

width:720px;

padding-top:62px;

}

.san_pham

{

width:220px;

float:left;

margin:0 10px;

}

.san_pham h3

{

color:#303131;

font-size:15px;

font-family:Tahoma, Geneva, sans-serif;

}

.san_pham p

{

color:#787a7b;

font-size:12px;

font-family:Tahoma, Geneva, sans-serif;

line-height:24px;

}

Sản phẩm cao cấp:

.noi_that_cao_cap

{

width:720px;

padding-top:42px;

}

.sp_cao_cap

{

width:220px;

float:left;

margin:10px;

}

.sp_cao_cap h3

{

color:#d23434;

font-size:15px;

font-family:Tahoma, Geneva, sans-serif;

}

.sp_cao_cap p

{

color:#787a7b;

font-size:12px;

font-family:Tahoma, Geneva, sans-serif;

line-height:24px;

}

.sp_cao_cap a

{

text-decoration:none;

color:#fff;

background-color:#d23434;

padding:0 15px;

float:right;

line-height:30px;

}

### Phần : footer

Phần footer ta thấy có cấu trúc chia làm hai, ta sẽ sử dụng thuộc tính
float và width cho 2 thành phần:

![](media/image19.tmp){width="3.0085936132983377in"
height="1.3251148293963255in"}

Viết css cho 2 thành phần địa chỉ và icon:

![](media/image20.tmp){width="4.308706255468066in"
height="3.0502646544181977in"}

**~Kết\ thúc:\ lưu\ bài\ với\ folder\ mssv_hoten\ rồi\ upload\ lên\ google\ driver\ (của\ mình).\ nộp\ đường\ đẫn\ vào\ class\ room.~**
