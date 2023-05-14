using ComputerRepair.Models;
using Microsoft.EntityFrameworkCore;

namespace ComputerRepair.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Requestx> Requests { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(u => u.RoleID);

            modelBuilder.Entity<Requestx>()
                .HasOne(ds => ds.Service)
                .WithMany(u => u.Requests)
                .HasForeignKey(ds => ds.ServiceID);
            modelBuilder.Entity<Requestx>()
                .HasOne(ds => ds.Device)
                .WithMany(u => u.Requests)
                .HasForeignKey(ds => ds.DeviceID);

            modelBuilder.Entity<Requestx>()
                .HasOne(r => r.Invoice)
                .WithMany(i => i.Requests)
                .HasForeignKey(r => r.InvoiceID);

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.CustomerID);

            var roles = new List<Role>
            {
                new Role { RoleID = 1, RoleName = "Admin" },
                new Role { RoleID = 2, RoleName = "Employee" }
            };
            var users = new List<User>
            {
                new User
                {
                    UserID = 1,
                    Username = "admin1",
                    Password = "admin1",
                    Email = "admin1@gmail.com",
                    FullName = "Nguyễn Văn A",
                    Phone = "0123456789",
                    Address = "Thành phố Hồ Chí Minh",
                    RoleID =1
                },
                new User
                {
                    UserID = 2,
                    Username = "admin2",
                    Password = "admin2",
                    Email = "admin2@gmail.com",
                    FullName = "Nguyễn Văn B",
                    Phone = "01234523489",
                    Address = "Thành phố Hồ Chí Minh",
                    RoleID = 1
                }, new User
                {
                    UserID = 3,
                    Username = "employee1",
                    Password = "employee1",
                    Email = "employee1@gmail.com",
                    FullName = "Lê Văn A",
                    Phone = "0234823434",
                    Address = "Thành phố Hồ Chí Minh",
                    RoleID = 2
                }, new User
                {
                    UserID = 4,
                    Username = "employee2",
                    Password = "employee2",
                    Email = "employee2@gmail.com",
                    FullName = "Lê Văn B",
                    Phone = "0284928394",
                    Address = "Thành phố Hồ Chí Minh",
                    RoleID=2
                }
            };
            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerID = 1,
                    CustomerName = "Trần Hoàng A",
                    Phone = "0234823423",
                    Email = "tranhoanga@gmail.com",
                    Address = "Thành phố Hồ Chí Minh"
                },new Customer
                {
                    CustomerID = 2,
                    CustomerName = "Trần Hoàng A",
                    Phone = "0234823423",
                    Email = "tranhoangb@gmail.com",
                    Address = "Thành phố Hồ Chí Minh"
                },new Customer
                {
                    CustomerID = 3,
                    CustomerName = "Trần Hoàng C",
                    Phone = "0232343423",
                    Email = "tranhoangc@gmail.com",
                    Address = "Thành phố Hồ Chí Minh"
                },new Customer
                {
                    CustomerID = 4,
                    CustomerName = "Trần Hoàng D",
                    Phone = "0234822453",
                    Email = "tranhoangd@gmail.com",
                    Address = "Thành phố Hồ Chí Minh"
                },new Customer
                {
                    CustomerID = 5,
                    CustomerName = "Trần Hoàng E",
                    Phone = "0223452323",
                    Email = "tranhoange@gmail.com",
                    Address = "Thành phố Hồ Chí Minh"
                },new Customer
                {
                    CustomerID = 6,
                    CustomerName = "Trần Hoàng F",
                    Phone = "0234752423",
                    Email = "tranhoangf@gmail.com",
                    Address = "Thành phố Hồ Chí Minh"
                },
            };
            var devices = new List<Device>
            {
                new Device
                {   DeviceID=1,
                    DeviceName = "Bàn phím",
                    Description = "Bàn phím máy tính cơ học đen trắng",
                    Manufacturer = "Logitech",
                    WarrantyPeriod = 0,
                    Quantity = 10
                },
                new Device
                {
                    DeviceID=2,
                    DeviceName = "Chuột",
                    Description = "Chuột máy tính không dây màu đen",
                    Manufacturer = "Microsoft",
                    WarrantyPeriod = 0,
                    Quantity = 15
                },
                new Device
                {
                    DeviceID=3,
                    DeviceName = "Màn hình",
                    Description = "Màn hình LCD 24 inch màu đen",
                    Manufacturer = "Samsung",
                    WarrantyPeriod = 0,
                    Quantity = 5
                },
                new Device
                {
                    DeviceID=4,
                    DeviceName = "Pin",
                    Description = "Pin laptop chính hãng",
                    Manufacturer = "Samsung",
                    WarrantyPeriod = 0,
                    Quantity = 5
                },
                new Device
                {
                    DeviceID=5,
                    DeviceName = "Không",
                    Description = "Không sử dụng linh kiện",
                    Manufacturer = "Không",
                    WarrantyPeriod = 0,
                    Quantity = 0
                }
            };
            var services = new List<Service>
            {
                new Service { ServiceID = 1,ServiceName = "Thay pin laptop", Description = "Thay pin laptop chính hãng" },
                new Service { ServiceID = 2,ServiceName = "Cài đặt phần mềm", Description = "Cài đặt phần mềm đa dạng" },
                new Service { ServiceID = 3,ServiceName = "Sửa màn hình", Description = "Sửa màn hình laptop, máy tính" },
                new Service { ServiceID = 4,ServiceName = "Vệ sinh laptop", Description = "Vệ sinh laptop, tản nhiệt" },
                new Service { ServiceID = 5,ServiceName = "Thay bàn phím laptop", Description = "Thay bàn phím laptop, máy tính" },
                new Service { ServiceID = 6,ServiceName = "Cài đặt hệ điều hành", Description = "Cài đặt hệ điều hành cho máy tính" },
                new Service { ServiceID = 7,ServiceName = "Linh kiện", Description = "Cung cấp linh kiện cho máy tính" }
            };
            modelBuilder.Entity<Role>().HasData(roles);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Customer>().HasData(customers);
            modelBuilder.Entity<Device>().HasData(devices);
            modelBuilder.Entity<Service>().HasData(services);
        }

    }
}
