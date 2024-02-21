using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản__lý_thư_viện.AppModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quản__lý_thư_viện.GUI
{
    public partial class formPhieuTra : Form
    {
        ChiTietPhieuTra ctphieuTra;
        public formPhieuTra(ChiTietPhieuTra ctphieuTra)
        {
            InitializeComponent();
            this.ctphieuTra = ctphieuTra;
            loadData();
            textBox2.Visible = false;
        }

        void loadData()
        {
            if (ctphieuTra != null)
            {


                using (AppDBContext dbContext = new AppDBContext())
                {
                    var phieuTra = dbContext.phieuTras.Where(e => e.MaPhieuTra == ctphieuTra.MaPhieuTra).FirstOrDefault();
                    textBox1.Text = phieuTra.MaPhieuTra.ToString();
                    textBox2.Text = phieuTra.MaDocGia.ToString();
                    dateTimePicker1.Value = phieuTra.NgayTra;
                    var books = dbContext.sachs.Select(e => new sach
                    {
                        MaSach = e.MaSach,
                        MaLoai = e.MaLoai,
                        TenSach = e.TenSach,
                        tacgia = e.tacgia,
                        SoLuong = e.SoLuong,
                        ngayNhap = e.ngayNhap,
                        namXuatBan = e.namXuatBan
                    }).ToList();
                    var docigas = dbContext.docGias.Select(e => new DocGia
                    {
                        MaDocGia = e.MaDocGia,
                        TenDocGia = e.TenDocGia,
                        NgaySinh = e.NgaySinh,
                        DiaChi = e.DiaChi,
                        SDT = e.SDT
                    }).ToList();
                    comboBox1.DataSource = books;
                    comboBox1.DisplayMember = "TenSach";
                    comboBox2.DataSource = docigas;
                    comboBox2.DisplayMember = "TenDocGia";

                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Sửa"))
            {
                button1.Text = "Lưu";

            }
            else if (button1.Text.Equals("Lưu"))
            {
                using (AppDBContext dBContext = new AppDBContext())
                {
                    var phieutra = dBContext.phieuTras.Where((e) => e.MaPhieuTra == ctphieuTra.MaPhieuTra).FirstOrDefault();
                    if (phieutra != null)
                    {
                        var docgia = comboBox2.SelectedItem as DocGia;

                        phieutra.MaDocGia = docgia.MaDocGia;

                        dBContext.SaveChanges();
                        var ctpt = dBContext.chiTietPhieuTras.Where((e) => e.MaCTPT == ctphieuTra.MaCTPT).FirstOrDefault();
                        var sach = comboBox1.SelectedItem as sach;
                        ctpt.MaSach = sach.MaSach;
                        var rs = MessageBox.Show("Sửa thành công", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        button1.Text = "Sửa";
                        dBContext.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
