using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Quản__lý_thư_viện.AppModel
{
    public class AppDBContext : DbContext
    {
      public DbSet<sach> sachs { get; set; }
      public DbSet<loaisach> loaisachs { get;set; }


      public DbSet<DocGia> docGias { get; set; }

        public DbSet<PhieuMuon> phieuMuons { get; set; }

        public DbSet<ChiTietPhieuMuon> ctpms { get; set; }
        public DbSet<PhieuTra> phieuTras { get; set; }
        public DbSet<ChiTietPhieuTra> chiTietPhieuTras { get; set; }

        public DbSet<User> users { get; set; }
        public String ConnectionString { get; set; }

        public AppDBContext()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            ConnectionString = Path.Combine(folder, "QLTV.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {ConnectionString}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<loaisach>().HasKey(l => l.MaLoai);
            modelBuilder.Entity<sach>().HasKey(l => l.MaSach);
            modelBuilder.Entity<DocGia>().HasKey(l => l.MaDocGia);
            modelBuilder.Entity<PhieuMuon>().HasKey(l => l.MaPhieuMuon);
            modelBuilder.Entity<ChiTietPhieuMuon>().HasKey(l => l.maCTPM);
            modelBuilder.Entity<PhieuTra>().HasKey(l => l.MaPhieuTra);
            modelBuilder.Entity<ChiTietPhieuTra>().HasKey(l => l.MaCTPT);
            modelBuilder.Entity<User>().HasKey(l => l.Id);
            
            loaisach loaisach1  = new loaisach
            {
               MaLoai = "Cong nghe thong tin",
               tenLoai = "Công nghệ thông tin"
            };

            loaisach loaisach2 = new loaisach
            {
                MaLoai = "Triet hoc",
                tenLoai = "Triết học"
            };

            loaisach loaisach3 = new loaisach
            {
                MaLoai = "Cuoc song",
                tenLoai = "Cuộc sống"
            };

            sach sach1 = new sach
            {
                MaSach = 1,
                TenSach = "Java cơ bản 1",
                SoLuong = 20,
                tacgia = "Van Hoang",
                namXuatBan = 2023,
                ngayNhap = DateTime.Now,
                MaLoai = "Cong nghe thong tin"
            };
            sach sach2 = new sach
            {
                MaSach = 2,
                TenSach = "Triết học mác lê nin",
                SoLuong = 20,
                tacgia = "Van Hoang",
                namXuatBan = 2023,
                ngayNhap = DateTime.Now,
                MaLoai = "Triet hoc"
            };
            sach sach3 = new sach
            {
                MaSach = 3,
                TenSach = "Cấu trúc dữ liệu và giải thuật",
                SoLuong = 20,
                tacgia = "Van Hoang",
                namXuatBan = 2023,
                ngayNhap = DateTime.Now,
                MaLoai = "Cong nghe thong tin"
            };

            DocGia docgia1 = new DocGia
            {
                MaDocGia = 1,
                TenDocGia = "Lê Văn Hoàng",
                NgaySinh = DateTime.ParseExact("29-04-2002", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                SDT = "0898160444",
                DiaChi = "Thừa Thiên Huế"
            };

            DocGia docgia2 = new DocGia
            {
                MaDocGia = 1,
                TenDocGia = "Lê Văn Hoàng",
                NgaySinh = DateTime.ParseExact("29-04-2002", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                SDT = "0898160444",
                DiaChi = "Thừa Thiên Huế"
            };

            PhieuMuon phieumuon1 = new PhieuMuon
            {
                MaDocGia = 3,
                MaPhieuMuon = 1,
                NgayMuon = DateTime.Now,
               
            };

            ChiTietPhieuMuon ctpm1 = new ChiTietPhieuMuon
            {
                MaPhieuMuon = 1,
                MaSach = 1,
            };

            modelBuilder.Entity<loaisach>().HasData(loaisach1, loaisach2, loaisach3);
            modelBuilder.Entity<sach>().HasData(sach1, sach2, sach3);
            modelBuilder.Entity<DocGia>().HasData(docgia2);
           modelBuilder.Entity<PhieuMuon>().HasData(phieumuon1);

        }

    }
}
