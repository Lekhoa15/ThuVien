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
    [Migration("20231207085114_createdatabase1")]
    partial class createdatabase1
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

                    b.Property<int?>("sachMaSach")
                        .HasColumnType("INTEGER");

                    b.Property<string>("tenLoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaLoai");

                    b.HasIndex("sachMaSach");

                    b.ToTable("loaisachs");

                    b.HasData(
                        new
                        {
                            MaLoai = "Cong nghe thong tin",
                            tenLoai = "Công nghệ thông tin"
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

                    b.ToTable("sachs");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.loaisach", b =>
                {
                    b.HasOne("Quản__lý_thư_viện.AppModel.sach", null)
                        .WithMany("loaisachs")
                        .HasForeignKey("sachMaSach");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.sach", b =>
                {
                    b.Navigation("loaisachs");
                });
#pragma warning restore 612, 618
        }
    }
}
