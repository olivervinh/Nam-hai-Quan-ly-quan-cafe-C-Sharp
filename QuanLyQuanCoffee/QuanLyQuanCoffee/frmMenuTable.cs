using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee
{
    public partial class frmMenuTable : Form
    {
        public frmMenuTable()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnQuanli_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            frmNhanvien f = new frmNhanvien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
