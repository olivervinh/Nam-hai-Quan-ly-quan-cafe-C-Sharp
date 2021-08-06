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
    public partial class frmCha : Form
    {
        public static  string Quyendieukhien;
        public frmCha()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            //frmChiTietHoaDonvaHoaDon f = new frmChiTietHoaDonvaHoaDon();
            //f.MdiParent = this;
            //f.Show();
        }

       

        private void frmCha_Load(object sender, EventArgs e)
        {
            if(Quyendieukhien=="Nhan vien")
            {
                quảnLíToolStripMenuItem.Enabled = false;
            }
            frmWellcome f = new frmWellcome();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap fdn = new frmDangNhap();
            fdn.Owner = this;
            //fdn.Show();

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                frmAdmin f = new frmAdmin();
                f.MdiParent = this;
                f.Show();

            }




        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

          

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

                frmChiTietHoaDonvaHoaDon f = new frmChiTietHoaDonvaHoaDon();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn đăng xuất chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {

            }
            else
            {
                frmDangNhap f = new frmDangNhap();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
        }
    }
}
