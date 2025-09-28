#### BÀI TẬP VỀ NHÀ 01
Họ và tên: Lương Quang Hà Mssv: K225480106010
### ĐỀ TÀI : Máy tạo châm ngôn cá nhân
TẠO SOLUTION GỒM CÁC PROJECT SAU: ###
1. DLL đa năng, keyword: c# window library -› **Class Library (-NET Framework)**: giải bài toán bất kỳ, độc lạ càng tốt, có dấu ấn cá nhân trong kết quả, biên dịch ra
2. Console sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả. keyword: c# window Console => **Console App (-NET Framework)**, biên dịch ra EXE
3. Windows Form Application sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form;
keyword: c# window Desktop => **Windows Form Application (-NET Framework)**, biên dịch ra EXE
4. Web đơn giản, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập
được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên, kết quả gửi lại json cho client, js phía client sẽ nhận được gson này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược.
keyword: c# window web => **ASP.NET Web Application (.NET Framework)** + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy
### CÁCH LÀM: ###
Bài 1 : DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/3743b235-eb42-42ba-b885-e29855edc027" />

Bài 2: Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE.

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/9c22f7ff-94e1-47d7-ae8c-be8a001428dc" />

Kết quả:
Nhập từ khóa để hiện ra châm ngôn
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/8c5fd1e7-bf44-4734-b163-8c48d7577a2b" />

Bài 3 Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE.

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/2af2c5a2-0832-470a-9303-f23697ceaae3" />

Bài 4 Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/54d77831-3ffe-414d-8511-d9aaa1f0ea6b" />
 Kết quả sau khi chạy thử chương trình:

 <img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/ed67ddcc-44c3-4708-9b18-963a29690938" />

Cấu hình iss

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/1e8a75bf-9ae4-400d-92b1-75ce1911e31d" />



