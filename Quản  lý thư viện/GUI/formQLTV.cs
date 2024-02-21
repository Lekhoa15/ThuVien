using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Quản__lý_thư_viện.AppModel;
using Quản__lý_thư_viện.Migrations;

namespace Quản__lý_thư_viện.GUI
{
    public partial class formQLTV : Form
    {
        public formQLTV()
        {
            InitializeComponent();

            loaddata();
            panel2.Visible = false;
            panel3.Visible = false;
        }

        void loaddata()
        {
            using (AppDBContext db = new AppDBContext())
            {
                var sachs = db.sachs.Select(e => new sach
                {
                    MaSach = e.MaSach,
                    TenSach = e.TenSach,
                    MaLoai = e.MaLoai,
                    SoLuong = e.SoLuong,
                    tacgia = e.tacgia,
                    namXuatBan = e.namXuatBan,
                    ngayNhap = e.ngayNhap,

                }).ToList();
                sachBindingSource1.DataSource = sachs;
            }
        }

        void loaddataDocGia()
        {
            using (AppDBContext db = new AppDBContext())
            {
                var docgias = db.docGias.Select(e => new DocGia
                {
                    MaDocGia = e.MaDocGia,
                    TenDocGia = e.TenDocGia,
                    DiaChi = e.DiaChi,
                    NgaySinh = e.NgaySinh,
                    SDT = e.SDT
                }).ToList();
                docGiaDTOBindingSource.DataSource = docgias;
            }
        }

        public DataGridView sachDataTable { get; set; }
        void search()
        {
            using (AppDBContext db = new AppDBContext())
            {
                var sachs = db.sachs.Where(e => e.TenSach.ToLower().Contains(txtSearch.Text.ToLower())).Select(e => new sach
                {
                    MaSach = e.MaSach,
                    TenSach = e.TenSach,
                    MaLoai = e.MaLoai,
                    SoLuong = e.SoLuong,
                    tacgia = e.tacgia,
                    namXuatBan = e.namXuatBan,
                    ngayNhap = e.ngayNhap,
                }).ToList();
                sachBindingSource1.DataSource = sachs;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        public sach selectedRow
        {
            get
            {
                return sachBindingSource1.Current as sach;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                if (selectedRow != null)
                {
                    var sach = db.sachs.Where(e => e.MaSach == selectedRow.MaSach).FirstOrDefault();
                    if (sach != null)
                    {
                        db.sachs.Remove(sach);
                        db.SaveChanges();
                        loaddata();
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else MessageBox.Show("Chọn 1 sách để xóa");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            btnChiTiet.Show();
            btnXoa.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }



        private void btnthem_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                var Sach = new sach
                {
                    MaSach = int.Parse(txtMasach.Text),
                    TenSach = txtTensach.Text,
                    MaLoai = txtMaloai.Text,
                    SoLuong = int.Parse(txtSoluong.Text),
                    tacgia = txtTacgia.Text,
                    namXuatBan = int.Parse(txtnamxuatban.Text),
                    ngayNhap = dateTimePicker1.Value,

                };
                db.sachs.Add(Sach);

                db.SaveChanges();
                loaddata();
                txtMaloai.Text = "";
                txtTensach.Text = "";
                txtSoluong.Text = "";
                txtnamxuatban.Text = "";
                txtTacgia.Text = "";
                txtMasach.Text = "";
                MessageBox.Show("Thêm thành công");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaloai.Text = "";
            txtTensach.Text = "";
            txtSoluong.Text = "";
            txtnamxuatban.Text = "";
            txtTacgia.Text = "";
            txtMasach.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                var docgias = db.docGias.Where(e => e.TenDocGia.ToLower().Contains(txtSearchdg.Text.ToLower())).Select(e => new DocGia
                {
                    TenDocGia = e.TenDocGia,
                    MaDocGia = e.MaDocGia,
                    DiaChi = e.DiaChi,
                    NgaySinh = e.NgaySinh,
                    SDT = e.SDT
                }).ToList();
                docGiaDTOBindingSource.DataSource = docgias;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true; panel1.Visible = false;
            panel3.Visible = false;
            loaddataDocGia();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            loaddataDocGia();
        }
        public DocGia selectDocGia
        {
            get
            {
                return docGiaDTOBindingSource.Current as DocGia;
            }
        }
        private void btnXoadg_Click(object sender, EventArgs e)
        {
            if (selectDocGia != null)
            {
                using (AppDBContext db = new AppDBContext())
                {

                    var docgia = db.docGias.Where(e => e.MaDocGia == selectDocGia.MaDocGia).FirstOrDefault();
                    if (docgia != null)
                    {
                        db.docGias.Remove(docgia);
                        db.SaveChanges();
                        loaddataDocGia();
                        MessageBox.Show("Xóa thành công");
                    }


                    else MessageBox.Show("Chọn 1 sách để xóa");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đôc giả");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formCTDocGia formCT = new formCTDocGia(selectDocGia);

            if (formCT.ShowDialog() == DialogResult.OK)
            {
                loaddataDocGia();
            }
        }

        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                formChitTiet formCT = new formChitTiet(selectedRow);

                if (formCT.ShowDialog() == DialogResult.OK)
                {
                    loaddata();
                }
                /* formCT.setMasach(selectedRow.MaSach);
                 formCT.setMaLoai(selectedRow.MaLoai);
                 formCT.setTenSach(selectedRow.TenSach);
                 formCT.setSoluong(selectedRow.SoLuong);
                 formCT.setTacgia(selectedRow.tacgia);
                 formCT.setNamXuatBan(selectedRow.namXuatBan);
                 formCT.setNgayNhap(selectedRow.ngayNhap);*/


            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            var docgia = comboBox1.SelectedItem as DocGia;
            if (docgia != null)
            {
                textBox2.Text = docgia.MaDocGia.ToString();

            }
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                var Sach = new sach
                {
                    MaSach = int.Parse(txtMasach.Text),
                    TenSach = txtTensach.Text,
                    MaLoai = txtMaloai.Text,
                    SoLuong = int.Parse(txtSoluong.Text),
                    tacgia = txtTacgia.Text,
                    namXuatBan = int.Parse(txtnamxuatban.Text),
                    ngayNhap = dateTimePicker1.Value,

                };
                db.sachs.Add(Sach);

                db.SaveChanges();
                loaddata();
                txtMaloai.Text = "";
                txtTensach.Text = "";
                txtSoluong.Text = "";
                txtnamxuatban.Text = "";
                txtTacgia.Text = "";
                txtMasach.Text = "";
                MessageBox.Show("Thêm thành công");

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnhuydocgia.Visible = true;
            using (AppDBContext db = new AppDBContext())
            {
                var docGia = new DocGia
                {
                    TenDocGia = txttendocgia.Text,
                    DiaChi = txtdiachi.Text,
                    NgaySinh = dateTimePicker2.Value,
                    SDT = txtsdt.Text,


                };
                db.docGias.Add(docGia);

                db.SaveChanges();
                loaddataDocGia();
                txttendocgia.Text = "";
                txtdiachi.Text = "";
                txtsdt.Text = "";
                MessageBox.Show("Thêm thành công");

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txttendocgia.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            loadDataPhieu();
        }

        void loadDocGiaCb()
        {
            textBox2.Enabled = false;
            using (AppDBContext db = new AppDBContext())
            {
                var docgias = db.docGias.Select(e => new DocGia
                {
                    MaDocGia = e.MaDocGia,
                    TenDocGia = e.TenDocGia,
                    DiaChi = e.DiaChi,
                    SDT = e.SDT,
                    NgaySinh = e.NgaySinh
                }).ToList();

                //Bước 2: Đưa dữ liệu lên cbbox
                comboBox1.DataSource = docgias;
                comboBox1.DisplayMember = "TenDocGia";
                comboBox4.DataSource = docgias;
                comboBox4.DisplayMember = "TenDocGia";

                var docgia = comboBox1.SelectedItem as DocGia;
                textBox2.Text = docgia.MaDocGia.ToString();

                //Đưa dữ liệu lên grid
                //bLogDTOBindingSource.DataSource = blogs;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            loadDataPhieu();
            loadDocGiaCb();
            loadPhieuTra();
            using (AppDBContext db = new AppDBContext())
            {
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
                comboBox2.DataSource = sachs;
                comboBox2.DisplayMember = "TenSach";
            }
        }


        void loadDataPhieu()
        {
            using (AppDBContext db = new AppDBContext())
            {
                var phieumuons = db.ctpms.Select(e => new ChiTietPhieuMuon
                {
                    maCTPM = e.maCTPM,
                    MaPhieuMuon = e.MaPhieuMuon,
                    TrangThai = e.TrangThai,
                    MaSach = e.MaSach
                }).ToList();
                chiTietPhieuMuonBindingSource.DataSource = phieumuons;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                using (AppDBContext db = new AppDBContext())
                {
                    if (textBox1.Text != "")
                    {

                        var ds = db.phieuMuons.Where(e => e.MaDocGia == int.Parse(textBox1.Text)).Select(e => new PhieuMuon
                        {
                            MaPhieuMuon = e.MaPhieuMuon,
                            MaDocGia = e.MaDocGia,
                            NgayMuon = e.NgayMuon
                        }).ToList();
                        var dsct = new List<ChiTietPhieuMuon>();
                        for (int i = 0; i < ds.Count; i++)
                        {
                            var item = db.ctpms.Where(e => e.MaPhieuMuon == ds[i].MaPhieuMuon).Select(e => new ChiTietPhieuMuon
                            {
                                maCTPM = e.maCTPM,
                                MaPhieuMuon = e.MaPhieuMuon,
                                MaSach = e.MaSach,
                                TrangThai = e.TrangThai
                            }).ToList();
                            for (int j = 0; j < item.Count; j++)
                            {
                                dsct.Add(item[j]);

                            }
                        }
                        chiTietPhieuMuonBindingSource.DataSource = dsct;

                    }
                    else MessageBox.Show("Vui lòng nhập mã muốn tìm");

                }
            }
            else if (radioButton2.Checked)
            {
                if (textBox1.Text != "")
                {
                    using (AppDBContext db = new AppDBContext())
                    {


                        var ds = db.ctpms.Where(e => e.MaPhieuMuon == int.Parse(textBox1.Text)).Select(e => new ChiTietPhieuMuon
                        {
                            MaPhieuMuon = e.MaPhieuMuon,
                            maCTPM = e.maCTPM,
                            MaSach = e.maCTPM,
                            TrangThai = e.TrangThai,
                        }).ToList();
                        chiTietPhieuMuonBindingSource.DataSource = ds;
                    }
                }
                else MessageBox.Show("Vui lòng nhập mã muốn tìm");



            }
            else
            {


                loadDataPhieu();
            }
        }
        public ChiTietPhieuMuon selectPhieuMuon
        {
            get
            {
                return chiTietPhieuMuonBindingSource.Current as ChiTietPhieuMuon;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            formPhieuMuon formpm = new formPhieuMuon(selectPhieuMuon);
            if (formpm.ShowDialog() == DialogResult.OK)
            {
                loadDataPhieu();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                if (selectPhieuMuon != null)
                {
                    var phieumuon = db.phieuMuons.Where(e => e.MaPhieuMuon == selectPhieuMuon.MaPhieuMuon).FirstOrDefault();
                    if (phieumuon != null)
                    {
                        db.phieuMuons.Remove(phieumuon);
                        db.SaveChanges();
                        loadDataPhieu();
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else MessageBox.Show("Chọn 1 phiếu mượn để xóa");
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)

        {
            using (AppDBContext db = new AppDBContext())
            {

                if (textBox2.Text != null)
                {
                    if (richTextBox1.Text != null)
                    {
                        PhieuMuon phieuMuon = new PhieuMuon
                        {
                            MaDocGia = int.Parse(textBox2.Text),
                            NgayMuon = DateTime.Now,


                        };
                        db.phieuMuons.Add(phieuMuon);

                        MessageBox.Show("Lập phiếu mượn thành công");
                        db.SaveChanges();
                        var lastitem = db.phieuMuons.OrderBy(e => e.MaPhieuMuon).LastOrDefault();
                        String[] ds = richTextBox1.Text.Split("\n");
                        for (int i = 0; i < ds.Length - 1; i++)
                        {
                            var item = db.sachs.Where(e => e.TenSach.Equals(ds[i])).FirstOrDefault();
                            item.dem = item.dem + 1;
                            if (item != null)
                            {
                                ChiTietPhieuMuon ctpm = new ChiTietPhieuMuon
                                {
                                    MaSach = item.MaSach,
                                    MaPhieuMuon = lastitem.MaPhieuMuon,
                                    TrangThai = 1
                                };
                                db.ctpms.Add(ctpm);
                                db.SaveChanges();
                            }
                        }
                        loadDataPhieu();
                    }
                    else MessageBox.Show("Vui lòng chọn ít nhất 1 sách");
                }
                else MessageBox.Show("Vui lòng chọn độc giả");
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox2.SelectedItem as sach;

            if (item != null)
            {

                richTextBox1.AppendText(item.TenSach + Environment.NewLine);
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<string> list = richTextBox1.Lines.ToList();
            list.RemoveAt(list.Count - 2);
            richTextBox1.Lines = list.ToArray();
        }

        void loadDataPhieuTra()
        {
            using (AppDBContext db = new AppDBContext())
            {
                var phieutras = db.phieuTras.Select(e => new PhieuTra
                {
                    MaDocGia = e.MaDocGia,
                    MaPhieuTra = e.MaPhieuTra,
                    NgayTra = e.NgayTra
                }).ToList();
                phieuTraDTOBindingSource.DataSource = phieutras;
            }
        }


        private void button23_Click(object sender, EventArgs e)
        {
            formPhieuTra formPhieu = new formPhieuTra(chiTietPhieuTraBindingSource.Current as ChiTietPhieuTra);
            if (formPhieu.ShowDialog() == DialogResult.OK)
            {
                loadPhieuTra();
            }
        }

        void loadPhieuTra()
        {
            using (AppDBContext db = new AppDBContext())
            {
                var ds = db.chiTietPhieuTras.Select(e => new ChiTietPhieuTra
                {
                    MaPhieuTra = e.MaPhieuTra,
                    MaSach = e.MaSach,
                    MaCTPT = e.MaCTPT,
                    MaPhieuMuon = e.MaPhieuMuon,
                }).ToList();
                chiTietPhieuTraBindingSource.DataSource = ds;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            var docgia = comboBox4.SelectedItem as DocGia;
            richTextBox2.Text = "";

            if (docgia != null)
            {

                using (AppDBContext db = new AppDBContext())
                {
                    var ds = db.phieuMuons.Where(e => e.MaDocGia == docgia.MaDocGia).Select(e => new PhieuMuon
                    {
                        MaPhieuMuon = e.MaPhieuMuon,
                        MaDocGia = e.MaDocGia,
                        NgayMuon = e.NgayMuon
                    }).ToList();
                    List<ChiTietPhieuMuon> list = new List<ChiTietPhieuMuon>();


                    var dsCTPM = db.ctpms.Where(e => e.TrangThai == 1).Select(e => new ChiTietPhieuMuon
                    {
                        MaPhieuMuon = e.MaPhieuMuon,
                        maCTPM = e.maCTPM,
                        MaSach = e.MaSach
                    }).ToList();
                    if (dsCTPM != null)
                    {
                        for (int i = 0; i < ds.Count; i++)
                        {
                            for (int j = 0; j < dsCTPM.Count; j++)
                            {
                                if (dsCTPM[j].MaPhieuMuon == ds[i].MaPhieuMuon)
                                {
                                    list.Add(dsCTPM[j]);
                                }
                            }
                        }

                    }

                    List<sach> listbook = new List<sach>();


                    var books = db.sachs.Select(e => new sach
                    {
                        MaSach = e.MaSach,
                        TenSach = e.TenSach,
                        MaLoai = e.MaLoai,
                        SoLuong = e.SoLuong,
                        tacgia = e.tacgia,
                        namXuatBan = e.namXuatBan,
                        ngayNhap = e.ngayNhap,

                    }).ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < books.Count; j++)
                        {
                            if (list[i].MaSach == books[j].MaSach)
                            {
                                listbook.Add(books[j]);
                            }
                        }
                    }

                    comboBox3.DataSource = listbook;
                    comboBox3.DisplayMember = "TenSach";
                }


            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox3.SelectedItem as sach;

            if (item != null)
            {
                richTextBox2.AppendText(item.TenSach + Environment.NewLine);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            List<string> list = richTextBox2.Lines.ToList();
            list.RemoveAt(list.Count - 2);
            richTextBox2.Lines = list.ToArray();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var docgia = comboBox4.SelectedItem as DocGia;
            String[] ds = richTextBox2.Text.Split("\n");
            if (ds != null)
            {
                using (AppDBContext db = new AppDBContext())
                {
                    if (docgia != null)
                    {

                        var item = new PhieuTra
                        {
                            MaDocGia = docgia.MaDocGia,
                            NgayTra = DateTime.Now,
                        };
                        db.phieuTras.Add(item);
                        MessageBox.Show("Lập phiếu trả thành công");
                        db.SaveChanges();
                        for (int i = 0; i < ds.Length; i++)
                        {
                            var books = db.sachs.Where(e => e.TenSach.Equals(ds[i])).FirstOrDefault();
                            if (books != null)
                            {
                                var chitietpm = db.ctpms.Where(e => e.MaSach == books.MaSach).Where(e => e.TrangThai == 1).Select(e => new ChiTietPhieuMuon
                                {
                                    maCTPM = e.maCTPM,
                                    MaPhieuMuon = e.MaPhieuMuon,
                                    MaSach = e.maCTPM,
                                    TrangThai = e.TrangThai
                                });
                                PhieuMuon phieuMuonTra = new PhieuMuon();
                                foreach (var phieumuon in chitietpm)
                                {
                                    var item2 = db.phieuMuons.Where(e => e.MaPhieuMuon == phieumuon.MaPhieuMuon).Where(e => e.MaDocGia == docgia.MaDocGia).FirstOrDefault();
                                    if (item2 != null)
                                    {
                                        phieuMuonTra = item2;
                                    }
                                }
                                var lastitem = db.phieuTras.OrderBy(e => e.MaPhieuTra).LastOrDefault();

                                if (phieuMuonTra != null)
                                {
                                    var ChiTiet = new ChiTietPhieuTra
                                    {
                                        MaPhieuTra = lastitem.MaPhieuTra,
                                        MaSach = books.MaSach,
                                        MaPhieuMuon = phieuMuonTra.MaPhieuMuon,
                                    };
                                    db.chiTietPhieuTras.Add(ChiTiet);
                                    var olditem = db.ctpms.Where(e => e.MaSach == books.MaSach).Where(e => e.TrangThai == 1).Where(e => e.MaPhieuMuon == phieuMuonTra.MaPhieuMuon).FirstOrDefault();
                                    if (olditem != null)
                                    {
                                        olditem.TrangThai = 0;
                                    }
                                    db.SaveChanges();
                                }



                            }
                        }






                    }
                    else MessageBox.Show("Vui lòng chọn độc giả");

                }
            }
            else MessageBox.Show("Vui lòng chọn sách trả");

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var ds = richTextBox1.Text.Split("\n");
                DocGia docgia = comboBox1.SelectedItem as DocGia;
                e.Graphics.DrawString("Phiếu mượn" + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(250, 15));
                e.Graphics.DrawString(Environment.NewLine + "Họ tên: " + docgia.TenDocGia + Environment.NewLine + "Địa chỉ: " + docgia.DiaChi + Environment.NewLine + "Ngày mượn: " + DateTime.Now + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(95, 15));
                e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Danh sách mượn: " + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(95, 15));

                e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + richTextBox1.Text + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(95, 15));


            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 600, 258);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void formQLTV_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {

                using (AppDBContext db = new AppDBContext())
                {
                    if (textBox3.Text != "")
                    {

                        var ds = db.chiTietPhieuTras.Where(e => e.MaPhieuMuon == int.Parse(textBox3.Text)).Select(e => new ChiTietPhieuTra
                        {
                            MaPhieuTra = e.MaPhieuTra,
                            MaPhieuMuon = e.MaPhieuMuon,
                            MaSach = e.MaSach,
                            MaCTPT = e.MaCTPT

                        }).ToList();
                        chiTietPhieuTraBindingSource.DataSource = ds;

                    }
                    else MessageBox.Show("Vui lòng nhập mã muốn tìm");

                }
            }
            else if (radioButton5.Checked)
            {
                if (textBox3.Text != "")
                {
                    using (AppDBContext db = new AppDBContext())
                    {


                        var ds = db.chiTietPhieuTras.Where(e => e.MaPhieuTra == int.Parse(textBox3.Text)).Select(e => new ChiTietPhieuTra
                        {
                            MaPhieuTra = e.MaPhieuTra,
                            MaPhieuMuon = e.MaPhieuMuon,
                            MaSach = e.MaSach,
                            MaCTPT = e.MaCTPT

                        }).ToList();
                        chiTietPhieuTraBindingSource.DataSource = ds;
                    }
                }
                else MessageBox.Show("Vui lòng nhập mã muốn tìm");



            }
            else
            {


                loadPhieuTra();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            loadPhieuTra();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            formUser form = new formUser();
            form.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
                if (chiTietPhieuTraBindingSource.Current != null)
                {
                    var item = chiTietPhieuTraBindingSource.Current as ChiTietPhieuTra;
                    var phieutra = db.chiTietPhieuTras.Where(e => e.MaCTPT == item.MaCTPT).FirstOrDefault();
                    if (phieutra != null)
                    {
                        db.chiTietPhieuTras.Remove(phieutra);
                        db.SaveChanges();
                        loadPhieuTra();
                        MessageBox.Show("Xóa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
                else MessageBox.Show("Chọn 1 phiếu trả để xóa");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            formThongKe form = new formThongKe();
            form.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                var ds = richTextBox2.Text.Split("\n");
                DocGia docgia = comboBox4.SelectedItem as DocGia;
                e.Graphics.DrawString("Phiếu trả" + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(250, 15));
                e.Graphics.DrawString(Environment.NewLine + "Họ tên: " + docgia.TenDocGia + Environment.NewLine + "Địa chỉ: " + docgia.DiaChi + Environment.NewLine + "Ngày trả: " + DateTime.Now + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(95, 15));
                e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + "Danh sách trả: " + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(95, 15));

                e.Graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + richTextBox2.Text + Environment.NewLine, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Blue, new Point(95, 15));


            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            printDocument2.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprm", 600, 258);
            if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
            {
                printDocument2.Print();
            }
        }
    }
}
