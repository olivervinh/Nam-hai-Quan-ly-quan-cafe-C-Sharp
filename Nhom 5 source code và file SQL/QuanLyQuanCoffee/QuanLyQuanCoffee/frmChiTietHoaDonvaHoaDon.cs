using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
using DAO;

namespace QuanLyQuanCoffee
{
    public partial class frmChiTietHoaDonvaHoaDon : Form
    {
        public frmChiTietHoaDonvaHoaDon()
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            comHDCTHDCachtim.Items.Add("Thức ăn");
            comHDCTHDCachtim.Items.Add("Bàn");
            comHDCTHDCachtim.Items.Add("Mã hóa đơn");
            comHDCTHDCachtim.Items.Add("Mã chi tiết hóa đơn");
            comHDCTHDCachtim.Text = "Thức ăn";


            LoadHDdautien();
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy h:mm:ss tt";
            frmHoaDonLoad();
            LoadHDdautien();
            frmChiTietHoaDonLoad();
            LoadCombox();
            
            LoadThucAn();
            btnSuaHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnCTHDthem.Enabled = false;
            btnCTHDsua.Enabled = false;
            btnXoaCTHD.Enabled = false;
            btnCapNhatTien.Enabled = false;
            btnThemHD.Enabled = false;
            btnThemHDFirst.Enabled = true;
        }
        public void LoadHDdautien()
        {
            

        }
        public void LoadThucAn()
        {
           
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            string truyVan1 = " SELECT Ten,price FROM dbo.ThucAn WHERE Trangthai=1";
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter(truyVan1, conn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvThucAn.DataSource = dt1;

        }
       
        public void frmChiTietHoaDonLoad()
        {
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            string truyVan2 = "select ChiTietHoaDon.id N'Mã CTHD',ChiTietHoaDon.idBill N'Mã HD',ChiTietHoaDon.count N'Số lượng',ChiTietHoaDon.Food N'Tên thức ăn',ChiTietHoaDon.Thanhtien N'Tiền' from ChiTietHoaDon where Trangthai = 1";
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter(truyVan2, conn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvCTHD.DataSource = dt1;
            conn1.Close();
        }
        public void frmHoaDonLoad()
        {
           
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            string truyVan2 = "select HoaDon.id N'Mã Hóa Đơn',HoaDon.NgayLap N'Ngày lập',HoaDon.Ban N'Tên bàn' ,SUM(ChiTietHoaDon.Thanhtien) N'Tổng tiền'from HoaDon,ChiTietHoaDon where HoaDon.Trangthai=1 group by HoaDon.id,HoaDon.NgayLap,HoaDon.Ban ";
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter(truyVan2, conn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvHD.DataSource = dt1;
            conn1.Close();
        }
        public void LoadCombox()
        {
            Ban_BUS ban = new Ban_BUS();
            List<Ban_DTO> listBan = ban.LayDSBan();
            comHDBan.DataSource = listBan;
            comHDBan.DisplayMember = "Ten";

        }

        

        private void btnCTHDthem_Click(object sender, EventArgs e)
        {
            btnCTHDsua.Enabled = true;
            btnCTHDsua.Enabled = true;
          
            if(txtCTHDTAtenThucan.Text==""||txtHDid.Text==""||txtCTHDgia.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn vào thức ăn bên Bảng thức ăn Hoặc id Hóa đơn trên bảng Hóa Đơn hoặc giá trên bảng Thức Ăn ", "Thông báo");
            }
            else
            {
                if(txtCTHDTAtenThucan.Text != "" && txtHDid.Text != "" && txtCTHDgia.Text != "")
                {
                    MessageBox.Show("Thêm Chi tiết hóa đơn thành công!!", "Thông báo");
                    double a = Convert.ToDouble(txtCTHDgia.Text);
                    double b = Convert.ToDouble(numCTHDSL.Value);
                    double c = a * b;
                    txtTien.Text = c.ToString();


                    string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(strKetNoi1);
                    conn1.Open();


                    string truyVan = "insert into dbo.ChiTietHoaDon(idBill,count,Thanhtien,Food,Trangthai) values (@id,@soluong,@thanhtien,@thucan,1)";

                    // Thực thi các lệnh để truy vấn dữ liệu, 
                    SqlCommand cmd = new SqlCommand(truyVan, conn1);
                    cmd.Parameters.AddWithValue("id", txtHDid.Text);
                    cmd.Parameters.AddWithValue("thucan", txtCTHDTAtenThucan.Text);
                    cmd.Parameters.AddWithValue("thanhtien", txtTien.Text);
                    cmd.Parameters.AddWithValue("soluong", numCTHDSL.Value);
                    cmd.ExecuteNonQuery();
                    frmChiTietHoaDonLoad();
                }
               
          
            }

        }

        private void btnQLNVsua_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNVthem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void frmHoaDonLoadMoi()
        {
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            conn1.Open();
            string truyVan2 = "select HoaDon.id N'Mã Hóa Đơn',HoaDon.NgayLap N'Ngày lập',HoaDon.Ban N'Tên bàn' ,dbo.HoaDon.Tongtien N'Tổng tiền'from HoaDon ";
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter(truyVan2, conn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvHD.DataSource = dt1;
            conn1.Close();
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {

            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnCTHDthem.Enabled = true;
            btnCTHDsua.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnThemHD.Enabled = true;
            btnCapNhatTien.Enabled = true;
            //h: mm: ss tt
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            conn1.Open();
            string truyVan = "INSERT INTO dbo.HoaDon(Ban, NgayLap,Trangthai) values(N'" + comHDBan.Text + "', GETDATE(),1)";
            SqlCommand cmd1 = new SqlCommand(truyVan, conn1);
            cmd1.ExecuteNonQuery();

            frmHoaDonLoad();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnCTHDthem.Enabled = true;
            btnCTHDsua.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnThemHD.Enabled = true;
            btnCapNhatTien.Enabled = true;
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            conn1.Open();
            string truyVan = "  UPDATE dbo.HoaDon SET Ban=@ban,Tongtien=@tongtien,Trangthai=1 where id=@ma ";
            
            SqlCommand cmd1 = new SqlCommand(truyVan, conn1);//Thuc thi 
            cmd1.Parameters.AddWithValue("ma", txtHDid.Text);
            cmd1.Parameters.AddWithValue("ban", comHDBan.Text);
            cmd1.Parameters.AddWithValue("tongtien", txtHDTongtien.Text);
            cmd1.ExecuteNonQuery();
            frmHoaDonLoad();
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnCTHDthem.Enabled = true;
            btnCTHDsua.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnThemHD.Enabled = true;
            btnCapNhatTien.Enabled = true;
            txtHDid.DataBindings.Clear();
            txtHDid.DataBindings.Add("text",dgvHD.DataSource,"Mã hóa đơn");
            txtHDTongtien.DataBindings.Clear();
            txtHDTongtien.DataBindings.Add("text", dgvHD.DataSource, "Tổng tiền");
            comHDBan.DataBindings.Clear();
            comHDBan.DataBindings.Add("text", dgvHD.DataSource, "Tên bàn");
        }

        private void dgvThucAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnCTHDthem.Enabled = true;
            btnCTHDsua.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnThemHD.Enabled = true;
            btnCapNhatTien.Enabled = true;
            txtCTHDTAtenThucan.DataBindings.Clear();
            txtCTHDTAtenThucan.DataBindings.Add("text", dgvThucAn.DataSource, "Ten");
            txtCTHDgia.DataBindings.Clear();
            txtCTHDgia.DataBindings.Add("text", dgvThucAn.DataSource, "price");

        }

        private void btnCapNhatTien_Click(object sender, EventArgs e)
        {
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            string truyVan2 = "select HoaDon.id N'Mã Hóa Đơn',HoaDon.NgayLap N'Ngày lập',HoaDon.Ban N'Tên bàn' ,SUM(ChiTietHoaDon.Thanhtien) N'Tổng tiền'from HoaDon,ChiTietHoaDon where HoaDon.Trangthai=1  and ChiTietHoaDon.idBill=HoaDon.id group by HoaDon.id,HoaDon.NgayLap,HoaDon.Ban ";
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter(truyVan2, conn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvHD.DataSource = dt1;
            conn1.Close();
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
           
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            conn1.Open();
            string truyVan = "  UPDATE dbo.HoaDon SET Trangthai=0 where id=@ma ";

            SqlCommand cmd1 = new SqlCommand(truyVan, conn1);//Thuc thi 
            cmd1.Parameters.AddWithValue("ma", txtHDid.Text);
            cmd1.Parameters.AddWithValue("ban", comHDBan.Text);
            cmd1.Parameters.AddWithValue("tongtien", txtHDTongtien.Text);
            cmd1.ExecuteNonQuery();
            frmHoaDonLoad();
        }

        private void btnCTHDsua_Click(object sender, EventArgs e)
        {
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            conn1.Open();
            string truyVan = "   UPDATE dbo.ChiTietHoaDon SET count = @SL , Food=@TenThucan, Trangthai=1 where id =@ma" ;
            SqlCommand cmd = new SqlCommand(truyVan, conn1);
            cmd.Parameters.AddWithValue("ma", txtIDcthd.Text);
            cmd.Parameters.AddWithValue("SL", numCTHDSL.Value);
            cmd.Parameters.AddWithValue("Tenthucan", txtCTHDTAtenThucan.Text);
            cmd.ExecuteNonQuery();


            frmChiTietHoaDonLoad();
        }

        private void btnXoaCTHD_Click(object sender, EventArgs e)
        {
            string strKetNoi = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strKetNoi);
            conn.Open();
            string truyVan = "UPDATE dbo.ChiTietHoaDon SET Trangthai=0 where id =@ma";
            SqlCommand cmd = new SqlCommand(truyVan, conn);
            cmd.Parameters.AddWithValue("ma", txtIDcthd.Text);
           
            cmd.ExecuteNonQuery();


            frmChiTietHoaDonLoad();

        }

        private void dgvCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnCTHDthem.Enabled = true;
            btnCTHDsua.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnThemHD.Enabled = true;
            btnCapNhatTien.Enabled = true;
            txtIDcthd.DataBindings.Clear();
            txtIDcthd.DataBindings.Add("text",dgvCTHD.DataSource, "Mã CTHD");
            txtIdCTHDidHD.DataBindings.Clear();
            txtIdCTHDidHD.DataBindings.Add("text",dgvCTHD.DataSource,"Mã HD");
            txtCTHDTAtenThucan.DataBindings.Clear();
            txtCTHDTAtenThucan.DataBindings.Add("text", dgvCTHD.DataSource, "Tên thức ăn");
            numCTHDSL.DataBindings.Clear();
            numCTHDSL.DataBindings.Add("text", dgvCTHD.DataSource, "Số lượng");
            txtTien.DataBindings.Clear();
            txtTien.DataBindings.Add("text",dgvCTHD.DataSource,"Tiền");
        
        }

        private void btnQLNVTimkiem_Click(object sender, EventArgs e)
        {
            string cachtim = comHDCTHDCachtim.SelectedItem.ToString();
            switch (cachtim)
            {


                case "Thức ăn":
                    string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection con = new SqlConnection(strKetNoi1);
                    string truyVan = "select * from dbo.ChiTietHoaDon where Trangthai =1 and Food like'%" + txtQLNVtimkiem.Text.Trim() + "%'";
                    SqlDataAdapter da1;
                    da1 = new SqlDataAdapter(truyVan, con);
                    DataTable dt = new DataTable();
                    da1.Fill(dt);
                    dgvCTHD.DataSource = dt;
                    break;
                case "Bàn":
                    string strKetNoi2 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection con2 = new SqlConnection(strKetNoi2);
                    string truyVan2 = "select * from dbo.HoaDon where Trangthai =1 and Ban like'%" + txtQLNVtimkiem.Text.Trim() + "%'";
                    SqlDataAdapter da2;
                    da2 = new SqlDataAdapter(truyVan2, con2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dgvCTHD.DataSource = dt2;
                    break;
                case "Mã hóa đơn":
                    try
                    {
                        string strKetNoi3 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                        SqlConnection con3 = new SqlConnection(strKetNoi3);
                        int id = int.Parse(txtQLNVtimkiem.Text.ToString());
                        string truyVan3 = "select * from dbo.HoaDon where Trangthai =1 and id =" + id;
                        SqlDataAdapter da4;
                        da4 = new SqlDataAdapter(truyVan3, con3);
                        DataTable dt4 = new DataTable();
                        da4.Fill(dt4);
                        dgvHD.DataSource = dt4;
                    }
                    catch(Exception ex)
                    {
                       
                    }
                    
                    break;
                case "Mã chi tiết hóa đơn":
                    try
                    {
                        string strKetNoi4 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                        SqlConnection con4 = new SqlConnection(strKetNoi4);
                        int idcthd = int.Parse(txtQLNVtimkiem.Text.ToString());
                        string truyVan5 = "select * from dbo.ChiTietHoaDon where Trangthai =1 and id =" + idcthd;
                        SqlDataAdapter da5;
                        da5 = new SqlDataAdapter(truyVan5, con4);
                        DataTable dt5 = new DataTable();
                        da5.Fill(dt5);
                        dgvCTHD.DataSource = dt5;
                    }
                    catch (Exception ex)
                    {
                       
                    }
                 
                    break;
            }
        }

        private void btnThemHDFirst_Click(object sender, EventArgs e)
        {
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnCTHDthem.Enabled = true;
            btnCTHDsua.Enabled = true;
            btnXoaCTHD.Enabled = true;
            btnThemHD.Enabled = true;
            btnCapNhatTien.Enabled = true;
            //h: mm: ss tt
            string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            SqlConnection conn1 = new SqlConnection(strKetNoi1);
            conn1.Open();
            string truyVan = "INSERT INTO dbo.HoaDon(Ban, NgayLap,Trangthai,Tongtien) values(N'" + comHDBan.Text + "', GETDATE(),1,0)";
            SqlCommand cmd1 = new SqlCommand(truyVan, conn1);
            cmd1.ExecuteNonQuery();


            string truyVan2 = "select HoaDon.id N'Mã Hóa Đơn',HoaDon.NgayLap N'Ngày lập',HoaDon.Ban N'Tên bàn' ,dbo.HoaDon.Tongtien N'Tổng tiền'from HoaDon ";
            SqlDataAdapter da1;
            da1 = new SqlDataAdapter(truyVan2, conn1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dgvHD.DataSource = dt1;
            conn1.Close();
        }

        private void buttonX4_Click(object sender, EventArgs e)
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

