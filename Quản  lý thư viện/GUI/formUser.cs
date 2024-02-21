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
    public partial class formUser : Form
    {
        public formUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AppDBContext dbContext = new AppDBContext())
            {
                var item = new User
                {
                    TenDN = textBox2.Text,
                    Name = textBox1.Text,
                    password = textBox3.Text,
                };
                dbContext.users.Add(item);
                dbContext.SaveChanges();
                MessageBox.Show("Đăng ký thành công");
            }
        }
    }
}
