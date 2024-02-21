using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout.Element;
using Microsoft.EntityFrameworkCore;
using Quản__lý_thư_viện.AppModel;

namespace Quản__lý_thư_viện.GUI
{
    public partial class formPhieuMuon : Form
    {
        ChiTietPhieuMuon ctphieuMuon;
        public formPhieuMuon(ChiTietPhieuMuon ctphieuMuon)
        {
            InitializeComponent();
            this.ctphieuMuon = ctphieuMuon;
            loaddata();
            textBox1.Enabled = false;
            button3.Visible = false;
            dateTimePicker1.Enabled = false;
        }
        void loaddata()
        {


            using (AppDBContext db = new AppDBContext())
            {
                var phieuMuon = db.phieuMuons.Where(e => e.MaPhieuMuon == ctphieuMuon.MaPhieuMuon).FirstOrDefault();
                textBox1.Text = phieuMuon.MaPhieuMuon.ToString();
                dateTimePicker1.Value = phieuMuon.NgayMuon;
                var docigas = db.docGias.Select(e => new DocGia
                {
                    MaDocGia = e.MaDocGia,
                    TenDocGia = e.TenDocGia,
                    NgaySinh = e.NgaySinh,
                    DiaChi = e.DiaChi,
                    SDT = e.SDT
                }).ToList();
                comboBox2.DataSource = docigas;
                comboBox2.DisplayMember = "TenDocGia";
                textBox3.Text = ctphieuMuon.TrangThai.ToString();
                var docgia = db.docGias.Where(e => e.MaDocGia == phieuMuon.MaDocGia).FirstOrDefault();
                comboBox2.SelectedItem = docgia;
                var sachs = db.sachs.Select(e => new sach
                {
                    MaSach = e.MaSach,
                    MaLoai = e.MaLoai,
                    TenSach = e.TenSach,
                    tacgia = e.tacgia,
                    SoLuong = e.SoLuong,
                    ngayNhap = e.ngayNhap,
                    namXuatBan = e.namXuatBan
                }).ToList();
                comboBox1.DataSource = sachs;
                comboBox1.DisplayMember = "TenSach";
                
                var ds = db.ctpms.Where(e => e.MaPhieuMuon == ctphieuMuon.MaPhieuMuon).Where(e => e.TrangThai == 1).Select(e => new ChiTietPhieuMuon
                {
                    maCTPM = e.maCTPM,
                    MaPhieuMuon = e.MaPhieuMuon,
                    MaSach = e.MaSach,
                    TrangThai = e.TrangThai
                }).ToList();
                var books = new List<sach>();

                for (int i = 0; i < ds.Count; i++)
                {
                    var item = db.sachs.Where(e => e.MaSach == ds[i].MaSach).FirstOrDefault();
                    books.Add(item);
                }


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Sửa"))
            {
                button1.Text = "Lưu";
                button3.Visible = true;
                dateTimePicker1.Enabled = true;
            }
            else if (button1.Text.Equals("Lưu"))
            {
                using (AppDBContext dBContext = new AppDBContext())
                {
                    var phieumuon = dBContext.phieuMuons.Where((e) => e.MaPhieuMuon == ctphieuMuon.MaPhieuMuon).FirstOrDefault();
                    if (phieumuon != null)
                    {
                        var docgia = comboBox2.SelectedItem as DocGia;
                        phieumuon.MaDocGia = docgia.MaDocGia;
                        phieumuon.NgayMuon = dateTimePicker1.Value;

                        dBContext.SaveChanges();
                        var ctpm = dBContext.ctpms.Where((e) => e.maCTPM == ctphieuMuon.maCTPM).FirstOrDefault();
                        ctpm.TrangThai = int.Parse(textBox3.Text);
                        var sach = comboBox1.SelectedItem as sach;
                        ctpm.MaSach = sach.MaSach;
                        var rs = MessageBox.Show("Sửa thành công", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        button1.Text = "Sửa";
                        dBContext.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loaddata();
            button1.Text = "Sửa";

            textBox1.Enabled = false;
            button3.Visible = false;
            dateTimePicker1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem as sach;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
