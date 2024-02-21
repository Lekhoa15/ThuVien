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
    public partial class formDangNhap : Form
    {
        public formDangNhap()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AppDBContext db = new AppDBContext())
            {
               var user = db.users.Where(e => e.TenDN == textBox1.Text).FirstOrDefault();
                if (user != null)
                {
                    if (user.password == textBox2.Text)
                    {
                        new formQLTV().Show();
                    }
                    else MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
                else MessageBox.Show("Tài khoản không tồn tại");
            }
        }
    }
}
