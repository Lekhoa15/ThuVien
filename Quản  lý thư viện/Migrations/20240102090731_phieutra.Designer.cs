﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quản__lý_thư_viện.AppModel;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20240102090731_phieutra")]
    partial class phieutra
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.ChiTietPhieuMuon", b =>
                {
                    b.Property<int>("maCTPM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaPhieuMuon")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaSach")
                        .HasColumnType("INTEGER");

                    b.HasKey("maCTPM");

                    b.ToTable("ctpms");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.ChiTietPhieuTra", b =>
                {
                    b.Property<int>("MaCTPT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaSach")
                        .HasColumnType("INTEGER");

                    b.HasKey("MaCTPT");

                    b.ToTable("ChiTietPhieuTra");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.DocGia", b =>
                {
                    b.Property<int>("MaDocGia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenDocGia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaDocGia");

                    b.ToTable("docGias");

                    b.HasData(
                        new
                        {
                            MaDocGia = 1,
                            DiaChi = "Thừa Thiên Huế",
                            NgaySinh = new DateTime(2002, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SDT = "0898160444",
                            TenDocGia = "Lê Văn Hoàng"
                        });
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.PhieuMuon", b =>
                {
                    b.Property<int>("MaPhieuMuon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaDocGia")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("NgayMuon")
                        .HasColumnType("TEXT");

                    b.HasKey("MaPhieuMuon");

                    b.HasIndex("MaDocGia");

                    b.ToTable("phieuMuons");

                    b.HasData(
                        new
                        {
                            MaPhieuMuon = 1,
                            MaDocGia = 3,
                            NgayMuon = new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5586)
                        });
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.PhieuTra", b =>
                {
                    b.Property<int>("MaPhieuTra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaDocGia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaPhieuMuon")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("NgayTra")
                        .HasColumnType("TEXT");

                    b.HasKey("MaPhieuTra");

                    b.ToTable("PhieuTra");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.loaisach", b =>
                {
                    b.Property<string>("MaLoai")
                        .HasColumnType("TEXT");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaLoai");

                    b.ToTable("loaisachs");

                    b.HasData(
                        new
                        {
                            MaLoai = "Cong nghe thong tin",
                            tenLoai = "Công nghệ thông tin"
                        },
                        new
                        {
                            MaLoai = "Triet hoc",
                            tenLoai = "Triết học"
                        },
                        new
                        {
                            MaLoai = "Cuoc song",
                            tenLoai = "Cuộc sống"
                        });
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.sach", b =>
                {
                    b.Property<int>("MaSach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaLoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("namXuatBan")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ngayNhap")
                        .HasColumnType("TEXT");

                    b.Property<string>("tacgia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSach");

                    b.HasIndex("MaLoai");

                    b.ToTable("sachs");

                    b.HasData(
                        new
                        {
                            MaSach = 1,
                            MaLoai = "Cong nghe thong tin",
                            SoLuong = 20,
                            TenSach = "Java cơ bản 1",
                            namXuatBan = 2023,
                            ngayNhap = new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5469),
                            tacgia = "Van Hoang"
                        },
                        new
                        {
                            MaSach = 2,
                            MaLoai = "Triet hoc",
                            SoLuong = 20,
                            TenSach = "Triết học mác lê nin",
                            namXuatBan = 2023,
                            ngayNhap = new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5481),
                            tacgia = "Van Hoang"
                        },
                        new
                        {
                            MaSach = 3,
                            MaLoai = "Cong nghe thong tin",
                            SoLuong = 20,
                            TenSach = "Cấu trúc dữ liệu và giải thuật",
                            namXuatBan = 2023,
                            ngayNhap = new DateTime(2024, 1, 2, 16, 7, 31, 566, DateTimeKind.Local).AddTicks(5482),
                            tacgia = "Van Hoang"
                        });
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.PhieuMuon", b =>
                {
                    b.HasOne("Quản__lý_thư_viện.AppModel.DocGia", "DocGia")
                        .WithMany("phieuMuons")
                        .HasForeignKey("MaDocGia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocGia");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.sach", b =>
                {
                    b.HasOne("Quản__lý_thư_viện.AppModel.loaisach", "LoaiSach")
                        .WithMany("sachs")
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiSach");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.DocGia", b =>
                {
                    b.Navigation("phieuMuons");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.loaisach", b =>
                {
                    b.Navigation("sachs");
                });
#pragma warning restore 612, 618
        }
    }
}
