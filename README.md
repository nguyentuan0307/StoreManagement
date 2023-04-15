# Cách update Database lên SQL SERVER trên Local
# Bước 1 : Điều chỉnh lại đường dẫn
### Vào appsettings.json, sửa đoạn lệnh trong ConnectionStrings thành trên máy mình, nên viết 1 tên Database chưa có trong máy tính, nếu có rồi hãy xóa trước khi chạy lệnh Update phía dưới
<img width="663" alt="image" src="https://user-images.githubusercontent.com/87991717/232224364-32002c69-0efa-4e71-927c-358ad598e660.png">
# Bước 2 : Xóa thư mục Migrations
# Bước 3 : Sử dụng các lệnh của Entity
### Bật chế độ console bằng cách vào Tools -> NuGet Package Manager -> Package Manager Console
<img width="474" alt="image" src="https://user-images.githubusercontent.com/87991717/232224470-a3090165-691a-410b-8023-e77d2fd64bf6.png">
### Tại cửa sổ Console, Nhập Add-Migration <Tên migration> // Tên migration tự cho, thường sẽ là CreateDatabase
<img width="310" alt="image" src="https://user-images.githubusercontent.com/87991717/232224553-ce17319b-5c64-497e-b684-787b1fdcae1b.png">
### Lúc này, một thư mục mới đã được tạo ra
<img width="207" alt="image" src="https://user-images.githubusercontent.com/87991717/232224566-cc9797c5-423c-4341-9a7c-cf25c81342bd.png">
### Sau khi đã có thư mục này, ta sẽ cập nhật nó lên database trên máy mình bằng lệnh : Update-Database
<img width="172" alt="image" src="https://user-images.githubusercontent.com/87991717/232224606-50a93da2-0367-4a84-9380-6e2696fbd2b8.png">
### Nếu kết quả trả về Done. Là đã thành công
<img width="374" alt="image" src="https://user-images.githubusercontent.com/87991717/232224708-ddc17eae-2afb-49af-a12e-e5b87eaffbb1.png">
## Lúc này database đã được cập nhật trên máy tính, thế là xong, Chạy code và test thôi.Sử dụng  Username : admin1, password : admin1
