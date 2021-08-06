using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;
namespace QuanLyQuanCoffee
{
    
    public partial class frmDangNhap : Form
    {
     
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

          
            string strKetNoi = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection con = new SqlConnection(strKetNoi);
            string truyVan = "select Tendangnhap,Matkhau,Chucvu from NhanVien where Tendangnhap=N'" + txtTaiKhoan.Text + "'and MatKhau=N'" + txtMatKhau.Text + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(truyVan, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);



            if (dt.Rows.Count > 0)// kiểm tra số dòng trong sữ liệu lớn hơn 0 mới tiếp tục chương trình
            {
                for (int i = 0; i < dt.Rows.Count; i++) // cho vòng lặp chạy để tìm tới dòng cần thiết
                {
                    //if (dt.Rows[i]["Chucvu"].ToString() == "Nhan vien") // nếu dòng thứ i trong cột "Chuc vu"ép kiểu string == "Nhan vien" thì thông báo và chuyển sang form HoaDonvaCTHD
                    //{

                    //    MessageBox.Show("Bạn đã đăng nhập thành công với tài khoản Nhân viên", "Thông báo");
                    //    frmCha f = new frmCha();
                    //    this.Hide();
                    //    try
                    //    {
                    //        //(this.Owner as frmCha).quảnLíToolStripMenuItem.Enabled = false;
                    //    }
                    //    catch(Exception ex)
                    //    {
                    //        //(this.Owner as frmCha).quảnLíToolStripMenuItem.Enabled = false;
                    //    }
                      
                    //    f.ShowDialog();
                    //    this.Show();
                    //    //frmCha f = new frmCha();
                    //    //f.Owner = this;
                    //    //f.Show();
                    //}
                    //if (dt.Rows[i]["Chucvu"].ToString() == "Quan li")
                    
                        frmCha.Quyendieukhien = dt.Rows[i]["Chucvu"].ToString();
                        MessageBox.Show("Bạn đã đăng nhập thành công ", "Thông báo");
                        frmCha f = new frmCha();
                        this.Hide();
                        f.ShowDialog();
                     
                      
                    

                    //else
                    //{
                    //    MessageBox.Show("Bạn đã đăng nhập thất bại", "Thông báo");
                    //}
                }
            }
        }
    




        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
       
            //cmbType.Items.Add("Quan li");
            //cmbType.Items.Add("Nhan vien");
            //cmbType.Text = "Quan li";
        }
    }
}
