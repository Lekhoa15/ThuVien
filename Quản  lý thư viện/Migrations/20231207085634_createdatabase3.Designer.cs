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
    [Migration("20231207085634_createdatabase3")]
    partial class createdatabase3
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

                    b.Property<int>("SachMaSach")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoLuong")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("loaisachMaLoai")
                        .HasColumnType("TEXT");

                    b.HasKey("MaSach");

                    b.HasIndex("SachMaSach");

                    b.HasIndex("loaisachMaLoai");

                    b.ToTable("sachs");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.sach", b =>
                {
                    b.HasOne("Quản__lý_thư_viện.AppModel.sach", "Sach")
                        .WithMany()
                        .HasForeignKey("SachMaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Quản__lý_thư_viện.AppModel.loaisach", null)
                        .WithMany("sachs")
                        .HasForeignKey("loaisachMaLoai");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("Quản__lý_thư_viện.AppModel.loaisach", b =>
                {
                    b.Navigation("sachs");
                });
#pragma warning restore 612, 618
        }
    }
}
