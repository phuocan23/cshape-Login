using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshape_Login
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnđangnhap_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpass.Text == "123")
            {
                Frmmain frmMain = new Frmmain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
