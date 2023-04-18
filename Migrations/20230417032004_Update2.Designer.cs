﻿// <auto-generated />
using System;
using ComputerRepair.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ComputerRepair.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230417032004_Update2")]
    partial class Update2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ComputerRepair.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Address = "Thành phố Hồ Chí Minh",
                            CustomerName = "Trần Hoàng A",
                            Email = "tranhoanga@gmail.com",
                            Phone = "0234823423"
                        },
                        new
                        {
                            CustomerID = 2,
                            Address = "Thành phố Hồ Chí Minh",
                            CustomerName = "Trần Hoàng A",
                            Email = "tranhoangb@gmail.com",
                            Phone = "0234823423"
                        },
                        new
                        {
                            CustomerID = 3,
                            Address = "Thành phố Hồ Chí Minh",
                            CustomerName = "Trần Hoàng C",
                            Email = "tranhoangc@gmail.com",
                            Phone = "0232343423"
                        },
                        new
                        {
                            CustomerID = 4,
                            Address = "Thành phố Hồ Chí Minh",
                            CustomerName = "Trần Hoàng D",
                            Email = "tranhoangd@gmail.com",
                            Phone = "0234822453"
                        },
                        new
                        {
                            CustomerID = 5,
                            Address = "Thành phố Hồ Chí Minh",
                            CustomerName = "Trần Hoàng E",
                            Email = "tranhoange@gmail.com",
                            Phone = "0223452323"
                        },
                        new
                        {
                            CustomerID = 6,
                            Address = "Thành phố Hồ Chí Minh",
                            CustomerName = "Trần Hoàng F",
                            Email = "tranhoangf@gmail.com",
                            Phone = "0234752423"
                        });
                });

            modelBuilder.Entity("ComputerRepair.Models.Device", b =>
                {
                    b.Property<int>("DeviceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeviceID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("DeviceID");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceID = 1,
                            Description = "Bàn phím máy tính cơ học đen trắng",
                            DeviceName = "Bàn phím",
                            Manufacturer = "Logitech",
                            Quantity = 10
                        },
                        new
                        {
                            DeviceID = 2,
                            Description = "Chuột máy tính không dây màu đen",
                            DeviceName = "Chuột",
                            Manufacturer = "Microsoft",
                            Quantity = 15
                        },
                        new
                        {
                            DeviceID = 3,
                            Description = "Màn hình LCD 24 inch màu đen",
                            DeviceName = "Màn hình",
                            Manufacturer = "Samsung",
                            Quantity = 5
                        },
                        new
                        {
                            DeviceID = 4,
                            Description = "Pin laptop chính hãng",
                            DeviceName = "Pin",
                            Manufacturer = "Samsung",
                            Quantity = 5
                        },
                        new
                        {
                            DeviceID = 5,
                            Description = "Không sử dụng linh kiện",
                            DeviceName = "Không",
                            Manufacturer = "Không",
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("ComputerRepair.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("ComputerRepair.Models.Requestx", b =>
                {
                    b.Property<int>("RequestxID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestxID"));

                    b.Property<int>("DeviceID")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.HasKey("RequestxID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("ComputerRepair.Models.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleID = 2,
                            RoleName = "Employee"
                        });
                });

            modelBuilder.Entity("ComputerRepair.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ServiceID = 1,
                            Description = "Thay pin laptop chính hãng",
                            ServiceName = "Thay pin laptop"
                        },
                        new
                        {
                            ServiceID = 2,
                            Description = "Cài đặt phần mềm đa dạng",
                            ServiceName = "Cài đặt phần mềm"
                        },
                        new
                        {
                            ServiceID = 3,
                            Description = "Sửa màn hình laptop, máy tính",
                            ServiceName = "Sửa màn hình"
                        },
                        new
                        {
                            ServiceID = 4,
                            Description = "Vệ sinh laptop, tản nhiệt",
                            ServiceName = "Vệ sinh laptop"
                        },
                        new
                        {
                            ServiceID = 5,
                            Description = "Thay bàn phím laptop, máy tính",
                            ServiceName = "Thay bàn phím laptop"
                        },
                        new
                        {
                            ServiceID = 6,
                            Description = "Cài đặt hệ điều hành cho máy tính",
                            ServiceName = "Cài đặt hệ điều hành"
                        },
                        new
                        {
                            ServiceID = 7,
                            Description = "Cung cấp linh kiện cho máy tính",
                            ServiceName = "Linh kiện"
                        });
                });

            modelBuilder.Entity("ComputerRepair.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Address = "Thành phố Hồ Chí Minh",
                            Email = "admin1@gmail.com",
                            FullName = "Nguyễn Văn A",
                            Password = "admin1",
                            Phone = "0123456789",
                            RoleID = 1,
                            Username = "admin1"
                        },
                        new
                        {
                            UserID = 2,
                            Address = "Thành phố Hồ Chí Minh",
                            Email = "admin2@gmail.com",
                            FullName = "Nguyễn Văn B",
                            Password = "admin2",
                            Phone = "01234523489",
                            RoleID = 1,
                            Username = "admin2"
                        },
                        new
                        {
                            UserID = 3,
                            Address = "Thành phố Hồ Chí Minh",
                            Email = "employee1@gmail.com",
                            FullName = "Lê Văn A",
                            Password = "employee1",
                            Phone = "0234823434",
                            RoleID = 2,
                            Username = "employee1"
                        },
                        new
                        {
                            UserID = 4,
                            Address = "Thành phố Hồ Chí Minh",
                            Email = "employee2@gmail.com",
                            FullName = "Lê Văn B",
                            Password = "employee2",
                            Phone = "0284928394",
                            RoleID = 2,
                            Username = "employee2"
                        });
                });

            modelBuilder.Entity("ComputerRepair.Models.Invoice", b =>
                {
                    b.HasOne("ComputerRepair.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ComputerRepair.Models.Requestx", b =>
                {
                    b.HasOne("ComputerRepair.Models.Device", "Device")
                        .WithMany("Requests")
                        .HasForeignKey("DeviceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerRepair.Models.Invoice", "Invoice")
                        .WithMany("Requests")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerRepair.Models.Service", "Service")
                        .WithMany("Requests")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Invoice");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("ComputerRepair.Models.User", b =>
                {
                    b.HasOne("ComputerRepair.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ComputerRepair.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("ComputerRepair.Models.Device", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("ComputerRepair.Models.Invoice", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("ComputerRepair.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ComputerRepair.Models.Service", b =>
                {
                    b.Navigation("Requests");
                });
#pragma warning restore 612, 618
        }
    }
}