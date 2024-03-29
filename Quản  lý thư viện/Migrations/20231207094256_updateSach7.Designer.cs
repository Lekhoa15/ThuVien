﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quản__lý_thư_viện.AppModel;

#nullable disable

namespace Quản__lý_thư_viện.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20231207094256_updateSach7")]
    partial class updateSach7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

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

                    b.HasKey("MaSach");

                    b.HasIndex("MaLoai");

                    b.ToTable("sachs");

                    b.HasData(
                        new
                        {
                            MaSach = 1,
                            MaLoai = "Cong nghe thong tin",
                            SoLuong = 20,
                            TenSach = "Java cơ bản 1"
                        },
                        new
                        {
                            MaSach = 2,
                            MaLoai = "Triet hoc",
                            SoLuong = 20,
                            TenSach = "Triết học mác lê nin"
                        },
                        new
                        {
                            MaSach = 3,
                            MaLoai = "Cong nghe thong tin",
                            SoLuong = 20,
                            TenSach = "Cấu trúc dữ liệu và giải thuật"
                        });
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

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.loaisach", b =>
                {
                    b.Navigation("sachs");
                });
#pragma warning restore 612, 618
        }
    }
}
