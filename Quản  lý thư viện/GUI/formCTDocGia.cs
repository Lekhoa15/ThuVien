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
    public partial class formCTDocGia : Form
    {
        DocGia DocGia { get; set; }
        public formCTDocGia(DocGia DocGia)
        {
            this.DocGia = DocGia;
            InitializeComponent();
            loaddata();
        }

        void loaddata()
        {
            btnhuy.Visible = false;
            txtmadocgia.Text = DocGia.MaDocGia.ToString();
            txtmadocgia.Enabled = false;
            txttendocgia.Text = DocGia.TenDocGia;
            txttendocgia.Enabled = false;
            txtdiachi.Text = DocGia.DiaChi;
            txtdiachi.Enabled = false;
            txtsdt.Text = DocGia.SDT;
            txtsdt.Enabled = false;
            dateTimePicker1.Value = DocGia.NgaySinh;
            dateTimePicker1.Enabled = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnsua.Text == "Sửa")
            {
                btnsua.Text = "Lưu";
                btnhuy.Visible = true;
                txttendocgia.Enabled = true;
                txtdiachi.Enabled = true;
                txtsdt.Enabled = true;
                dateTimePicker1.Enabled = true;



            }
            else if (btnsua.Text == "Lưu")
            {
                using (AppDBContext db = new AppDBContext())
                {
                    var docgia = db.docGias.Where((e) => e.MaDocGia == DocGia.MaDocGia).FirstOrDefault();
                    if (docgia != null)
                    {
                        docgia.TenDocGia = txttendocgia.Text;
                        docgia.DiaChi = txtdiachi.Text;
                        docgia.SDT = txtsdt.Text;
                        docgia.NgaySinh = dateTimePicker1.Value;
                        db.SaveChanges();
                        DialogResult = DialogResult.OK;
                    }
                }

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnhuy.Visible = false;
            txttendocgia.Text = DocGia.TenDocGia;
            txtdiachi.Text = DocGia.DiaChi;
            txtsdt.Text = DocGia.SDT;
            dateTimePicker1.Value = DocGia.NgaySinh;
            txttendocgia.Enabled = false;
            txtdiachi.Enabled = false;
            txtsdt.Enabled = false;
            dateTimePicker1.Enabled = false;

        }
    }
}
