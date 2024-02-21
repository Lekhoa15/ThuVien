using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản__lý_thư_viện.AppModel;

namespace Quản__lý_thư_viện.GUI
{
    public partial class formChitTiet : Form
    {
        sach book;
        public formChitTiet(sach book)
        {
            InitializeComponent();
            this.book = book;
            txtMasach.Enabled = false;
            txtMasach.Text = book.MaSach.ToString();
            txtMaloai.Enabled = false;
            txtMaloai.Text = book.MaLoai;
            txtTensach.Enabled = false;
            txtTensach.Text = book.TenSach;

            txtnamxuatban.Enabled = false;
            txtnamxuatban.Text = book.namXuatBan.ToString();
            txtTacgia.Enabled = false;
            txtTacgia.Text = book.tacgia;
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Value = book.ngayNhap;
            txtSoluong.Enabled = false;
            txtSoluong.Text = book.SoLuong.ToString();
            btnhuy.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnsua.Text.Equals("Sửa"))
            {
                btnsua.Text = "Lưu";
                txtMasach.Enabled = true;
                txtMaloai.Enabled = true;
                txtTensach.Enabled = true;
                txtnamxuatban.Enabled = true;
                txtTacgia.Enabled = true;
                dateTimePicker1.Enabled = true;
                txtSoluong.Enabled = true;
                btnhuy.Visible = true;

            }

            else if (btnsua.Text.Equals("Lưu"))
            {
                using (var db = new AppDBContext())
                {
                    sach Sach = db.sachs.Where(e => e.MaSach == int.Parse(txtMasach.Text)).FirstOrDefault();

                    if (Sach != null)
                    {
                        Sach.MaSach = int.Parse(txtMasach.Text);
                        Sach.TenSach = txtTensach.Text;
                        Sach.MaLoai = txtMaloai.Text;
                        Sach.SoLuong = int.Parse(txtSoluong.Text);
                        Sach.tacgia = txtTacgia.Text;
                        Sach.namXuatBan = int.Parse(txtnamxuatban.Text);
                        Sach.ngayNhap = dateTimePicker1.Value;
                        db.SaveChanges();
                        var rs = MessageBox.Show("Sửa thành công", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        /*if (rs == DialogResult.OK)
                        {
                            formQLTV form = new formQLTV();
                            this.Close();
                            btnsua.Text = "Sửa";
                            btnhuy.Visible = false;
                        }*/
                        DialogResult = DialogResult.OK;

                    }
                    else
                    {
                        var rs = MessageBox.Show("Sửa thất bại", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (rs == DialogResult.OK)
                        {
                            formQLTV form = new formQLTV();
                            this.Close();
                            btnsua.Text = "Sửa";
                            btnhuy.Visible = false;
                        }

                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formQLTV qLTV = new formQLTV();
            txtMasach.Text = book.MaSach.ToString();
            txtMaloai.Text = book.MaLoai;
            txtTensach.Text = book.TenSach;
            txtTacgia.Text = book.tacgia;
            txtSoluong.Text = book.SoLuong.ToString();
            txtnamxuatban.Text = book.namXuatBan.ToString();
            dateTimePicker1.Value = book.ngayNhap;
            btnhuy.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
