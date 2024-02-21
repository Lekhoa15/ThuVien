using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.EntityFrameworkCore;
using Quản__lý_thư_viện.AppModel;

namespace Quản__lý_thư_viện.GUI
{
    public partial class formThongKe : Form
    {
        public formThongKe()
        {
            InitializeComponent();
            Chart chart = new Chart();

            using (AppDBContext db = new AppDBContext())
            {
                var books = db.sachs.Select(e => new sach
                {
                    MaSach = e.MaSach,
                    MaLoai = e.MaLoai,
                    TenSach = e.TenSach,
                    tacgia = e.tacgia,
                    SoLuong = e.SoLuong,
                    ngayNhap = e.ngayNhap,
                    namXuatBan = e.namXuatBan,
                    dem = e.dem
                }).ToList();


                for (int i = 0; i < books.Count; i++)
                    
                {
                    chart1.Series["Soluongsach"].Points.AddXY(books[i].MaSach, books[i].dem);
                }
            }


        }

        private void formThongKe_Load(object sender, EventArgs e)
        {

            // Thêm dữ liệu vào Series (ví dụ: 2 điểm dữ liệu)

        }
    }
}
