using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cshape_Login
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void btntinh_TextChanged(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtnhapso.Text);
            for(int i = 1; i <= so; i++)
            {
                if(so%i==0)
                {
                    lsb.Items.Add(i.ToString());
                }
            }
        }
    }
}
