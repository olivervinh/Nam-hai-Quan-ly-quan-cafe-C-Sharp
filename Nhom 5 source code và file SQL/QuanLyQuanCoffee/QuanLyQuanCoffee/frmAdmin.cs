
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
using System.Reflection;
using REPORT;
namespace QuanLyQuanCoffee
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
          


            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
            comQLNVgioitinh.Items.Add("Nam");
            comQLNVgioitinh.Items.Add("Nu");
            comQLNVgioitinh.Text = "Nam"; // mặc định là nam

            comQLNVchucvu.Items.Add("Nhan vien");
            comQLNVchucvu.Items.Add("Quan li");

            txtQLNVid.Text = "ID Tự tăng";
            txtTAid.Text = "ID Tự tăng";
            txtDMTAid.Text = "ID Tự tăng";
            txtBanid.Text = "ID Tự tăng";
            comTAidloaithucan.Items.Add("1");
            comTAidloaithucan.Items.Add("2");
            comTAidloaithucan.Items.Add("3");
            comTAidloaithucan.Items.Add("4");
            comTAidloaithucan.Text = "1";
           
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

            comQLNVCachtim.Items.Add("Họ Tên");
            comQLNVCachtim.Items.Add("Giới tính");
            comQLNVCachtim.Items.Add("Chức vụ");
            comQLNVCachtim.Items.Add("Điện thoại");
            comQLNVCachtim.Items.Add("Mã nhân viên");
            comQLNVCachtim.Text = "Họ Tên"; // Mặc định chọn là họ tên


          

            comTACachtim.Items.Add("Tên thức ăn");
            comTACachtim.Items.Add("Mã thức ăn");
            comTACachtim.Text = "Tên thức ăn";


            
            comLTACachtim.Items.Add("Tên loại thức ăn");
            comLTACachtim.Items.Add("Mã loại thức ăn");
            comLTACachtim.Text = "Tên loại thức ăn";

            
            comBCachtim.Items.Add("Mã bàn");
            comBCachtim.Items.Add("Tên bàn");
            comBCachtim.Text = "Tên bàn";

            // TODO: This line of code loads data into the 'quanliquancoffee50DataSet.HoaDon' table. You can move, or remove it, as needed.
            this.HoaDonTableAdapter.Fill(this.quanliquancoffee50DataSet.HoaDon); 
            #region Cập nhật dữ liệu từ SQL lên dgv
            NhanVien();
            DanhMuc();
            Thucan();
            Ban();
            #endregion
            //dgvQLNhanVien.Rows[0].Selected = true; // 
            //dgvDanhMuc.Rows[0].Selected = true;
            //dgvThucan.Rows[0].Selected = true;
            //dgvBan.Rows[0].Selected = true;

            this.reportViewer1.RefreshReport();
        }
        #region Cập nhật lên dataGridview
        public void NhanVien()
        {
            NhanVien_BUS nv = new NhanVien_BUS();
            List<NhanVien_DTO> listNV = nv.LayDSNhanVien();

            dgvQLNhanVien.DataSource = nv.LayDSNhanVien();
            dgvQLNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQLNhanVien.ReadOnly = true;
            dgvQLNhanVien.Columns["id"].HeaderText = "Mã nhân viên";
            dgvQLNhanVien.Columns["Tendangnhap"].HeaderText = "Tên đăng nhập";
            dgvQLNhanVien.Columns["Matkhau"].HeaderText = "Mật khẩu";
            dgvQLNhanVien.Columns["Hoten"].HeaderText = "Họ tên";
            dgvQLNhanVien.Columns["Gioitinh"].HeaderText = "Giới tính";
            dgvQLNhanVien.Columns["Dienthoai"].HeaderText = "Điện thoại";
            dgvQLNhanVien.Columns["Chucvu"].HeaderText = "Chức vụ";
            dgvQLNhanVien.Columns["Trangthai"].HeaderText = "Trạng thái";
        }
        public void DanhMuc()
        {
            Loaithucan_BUS lta = new Loaithucan_BUS();
            List<Loaithucan_DTO> listLTA = lta.LayDSLoaithucan();

            dgvDanhMuc.DataSource = lta.LayDSLoaithucan();
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.Columns["id"].HeaderText = "Mã danh mục";
            dgvDanhMuc.Columns["Ten"].HeaderText = "Tên danh mục";
            dgvDanhMuc.Columns["Trangthai"].HeaderText = "Trạng thái";
        }

        public void Thucan()
        {
            Thucan_BUS ta = new Thucan_BUS();
            List<Thucan_DTO> listTA = ta.LayDSThucan();

            dgvThucan.DataSource = ta.LayDSThucan();
            dgvThucan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThucan.ReadOnly = true;
            dgvThucan.Columns["id"].HeaderText = "Mã thức ăn";
            dgvThucan.Columns["idLoaithucan"].HeaderText = "Mã loại thức ăn";
            dgvThucan.Columns["Ten"].HeaderText = "Tên thức ăn";
            dgvThucan.Columns["price"].HeaderText = "Giá (VNĐ)";
            dgvThucan.Columns["Trangthai"].HeaderText = "Trangthai";

        }
        public void Ban()
        {
            Ban_BUS b = new Ban_BUS();
            List<Ban_DTO> listB = b.LayDSBan();

            dgvBan.DataSource = b.LayDSBan();
            dgvBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBan.ReadOnly = true;
            dgvBan.Columns["id"].HeaderText = "Mã bàn";
            dgvBan.Columns["Ten"].HeaderText = "Tên bàn";
            dgvBan.Columns["Trangthai"].HeaderText = "Trạng thái";
        }
        #endregion

        #region Hiển thị dữ liệu lên các control
        public void ControlNhanVien(NhanVien_DTO nv)
        {
            if (nv != null)
            {
                txtQLNVid.Text = nv.id.ToString();
                txtQLNVtendangnhap.Text = nv.Tendangnhap;
                txtQLNVhoten.Text = nv.Hoten;
                comQLNVgioitinh.Text = nv.Gioitinh;
                txtQLNVdienthoai.Text = nv.Dienthoai;
                comQLNVchucvu.Text = nv.Chucvu;
                txtQLNVTrangthai.Text = nv.Trangthai.ToString();
            }

        }
        public void ControlDanhMuc(Loaithucan_DTO l)
        {
            if (l != null)
            {
                txtDMTAid.Text = l.id.ToString();
                txtDMTAtenloai.Text = l.Ten;
            }
        }
        public void ControlThucAn(Thucan_DTO t)
        {
            if (t != null)
            {
                txtTAid.Text = t.id.ToString();
                txtTAten.Text = t.Ten;
                comTAidloaithucan.Text = t.idLoaiThucAn.ToString();
                txtTAgia.Text = t.price.ToString();
            }
        }
        public void ControlBan(Ban_DTO b)
        {
            if (b != null)
            {
                txtBanid.Text = b.id.ToString();
                txtBanTen.Text = b.Ten;
                comBanTrangthai.Text = b.Trangthai.ToString();

            }
        }
        #endregion
        #region tum lum
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxX10_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX26_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        private void btnQLNVlammoi_Click(object sender, EventArgs e)
        {
            //txtQLNVid.Text = "";
            //txtQLNVtendangnhap.Text = "";
            //txtQLNVhoten.Text = "";
            //radNam.Checked = false;
            //txtQLNVdienthoai.Text = "";
            //btnQLNVthem.Enabled = true;

        }






        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDMTAid.DataBindings.Clear();
            txtDMTAid.DataBindings.Add("Text", dgvDanhMuc.DataSource, "id");
            txtDMTAtenloai.DataBindings.Clear();
            txtDMTAtenloai.DataBindings.Add("Text", dgvDanhMuc.DataSource, "Ten");
            txtLoaiThucAnTrangthai.DataBindings.Clear();
            txtLoaiThucAnTrangthai.DataBindings.Add("Text", dgvDanhMuc.DataSource, "Trangthai");
          

        }

        private void dgvQLNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = int.Parse(txtQLNVid.Text.ToString());


            //if (dgvQLNhanVien.SelectedRows.Count >=1)

            //{
            //    /* dgvQLNhanVien.FirstDisplayedScrollingRowIndex*/
            //    //id = dgvQLNhanVien.SelectedRows[0].Index;
            //    txtQLNVid.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["id"].FormattedValue.ToString();
            //    txtQLNVtendangnhap.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Tendangnhap"].FormattedValue.ToString();
            //    txtQLNVhoten.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Hoten"].FormattedValue.ToString();
            //    txtQLNVdienthoai.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Gioitinh"].FormattedValue.ToString();
            //    comQLNVgioitinh.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Dienthoai"].FormattedValue.ToString();
            //    comQLNVchucvu.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Chucvu"].FormattedValue.ToString();
            //    txtQLNVTrangthai.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Trangthai"].FormattedValue.ToString();

            //    //-----

            //    txtQLNVid.Text = dgvQLNhanVien.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            //    txtQLNVtendangnhap.Text = dgvQLNhanVien.Rows[e.RowIndex].Cells["Tendangnhap"].FormattedValue.ToString();
            //    txtQLNVhoten.Text = dgvQLNhanVien.Rows[e.RowIndex].Cells["Hoten"].FormattedValue.ToString();
            //    txtQLNVdienthoai.Text = dgvQLNhanVien.Rows[e.RowIndex].Cells["Gioitinh"].FormattedValue.ToString();
            //    comQLNVgioitinh.Text = dgvQLNhanVien.Rows[e.RowIndex].Cells["Dienthoai"].FormattedValue.ToString();
            //    comQLNVchucvu.Text = dgvQLNhanVien.Rows[e.RowIndex].Cells["Chucvu"].FormattedValue.ToString();
            //    txtQLNVTrangthai.Text = dgvQLNhanVien.Rows[e.RowIndex].Cells["Trangthai"].FormattedValue.ToString();
            //    //
            txtQLNVid.DataBindings.Clear();
            txtQLNVid.DataBindings.Add("Text", dgvQLNhanVien.DataSource,"id");
            txtQLNVtendangnhap.DataBindings.Clear();
            txtQLNVtendangnhap.DataBindings.Add("Text", dgvQLNhanVien.DataSource, "Tendangnhap");
            txtQLNVhoten.DataBindings.Clear();
            txtQLNVhoten.DataBindings.Add("Text", dgvQLNhanVien.DataSource, "Hoten");
            comQLNVgioitinh.DataBindings.Clear();
            comQLNVgioitinh.DataBindings.Add("Text", dgvQLNhanVien.DataSource, "Gioitinh");
            txtQLNVdienthoai.DataBindings.Clear();
            txtQLNVdienthoai.DataBindings.Add("Text", dgvQLNhanVien.DataSource, "Dienthoai");
            comQLNVchucvu.DataBindings.Clear();
            comQLNVchucvu.DataBindings.Add("Text", dgvQLNhanVien.DataSource, "Chucvu");
            txtQLNVTrangthai.DataBindings.Clear();
            txtQLNVTrangthai.DataBindings.Add("Text", dgvQLNhanVien.DataSource, "Trangthai");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvQLNhanVien.DataSource, "Matkhau");
       //string gioiTinh = (radNam.Checked == true) ? "Nam" : "Nu";
                
                //txtQLNVhoten.Text = dgvDanhMuc.SelectedRows[0].DataBoundItem.ToString();


                //    NhanVien_DTO nv = (NhanVien_DTO)dgvQLNhanVien.SelectedRows[0].DataBoundItem;

                //    txtQLNVid.Text = nv.id.ToString();
                //    txtQLNVtendangnhap.Text = nv.Tendangnhap.ToString();
                //    txtQLNVhoten.Text = nv.Hoten.ToString();
                //    txtQLNVdienthoai.Text = nv.Dienthoai.ToString();
                //    comQLNVchucvu.Text = nv.Chucvu;
                //    txtQLNVTrangthai.Text = nv.
                //}

            }

        private void DgvQLNhanVien_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgvThucan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvThucan.SelectedRows.Count > 0)
            //{
            //    Thucan_DTO ta = (Thucan_DTO)dgvThucan.SelectedRows[0].DataBoundItem;
            //    ControlThucAn(ta);
            //}
            txtTAid.DataBindings.Clear();
            txtTAid.DataBindings.Add("Text", dgvThucan.DataSource, "id");
            txtTAten.DataBindings.Clear();
            txtTAten.DataBindings.Add("Text", dgvThucan.DataSource, "Ten");
            comTAidloaithucan.DataBindings.Clear();
            comTAidloaithucan.DataBindings.Add("Text", dgvThucan.DataSource, "idLoaiThucAn");
            txtTAgia.DataBindings.Clear();
            txtTAgia.DataBindings.Add("Text", dgvThucan.DataSource, "price");
            txtTATrangthai.DataBindings.Clear();
            txtTATrangthai.DataBindings.Add("Text", dgvThucan.DataSource, "Trangthai");

        }


        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBanid.DataBindings.Clear();
            txtBanid.DataBindings.Add("Text", dgvBan.DataSource, "id");
            txtBanTen.DataBindings.Clear();
            txtBanTen.DataBindings.Add("Text", dgvBan.DataSource, "id");
            comBanTrangthai.DataBindings.Clear();
            comBanTrangthai.DataBindings.Add("Text", dgvBan.DataSource, "status");
            
            txtBtrangthai.DataBindings.Clear();
            txtBtrangthai.DataBindings.Add("Text", dgvDanhMuc.DataSource, "Trangthai");
        }
        #region Tab
        private void tabBan_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTAThem_Click(object sender, EventArgs e)
        {
            Thucan_BUS ta_bus = new Thucan_BUS();
            Thucan_DTO ta_dto = new Thucan_DTO();
            int Loaithucan = int.Parse(comTAidloaithucan.Text.ToString());

            int Trangthai = int.Parse(txtTATrangthai.Text.ToString());
            //int id = int.Parse(txtTAid.Text.ToString());

            if (ta_bus.themThucan(/*id*/0, txtTAten.Text, Loaithucan, txtTAgia.Text, Trangthai)) // Trạng thái = 1 : hiển thị  
            {
                MessageBox.Show("Đã thêm thành công");

                Thucan();
                ControlThucAn(ta_dto);
            }
        }
        #endregion

        private void btnQLNVthem_Click(object sender, EventArgs e)// Thêm nhân viên
        {

            NhanVien_BUS nv_bus = new NhanVien_BUS();
            NhanVien_DTO nv_dto = new NhanVien_DTO();
            //string gioiTinh = (radNam.Checked == true) ? "Nam" : "Nu";
            int Trangthai = int.Parse(txtQLNVTrangthai.Text.ToString());
          /*  int id = int.Parse(txtQLNVid.Text.ToString());*/ //     TRuong hop nguoi dung ko click vao 1 dong nao do trong DataGrigView , phai cho đại vào 1 giá trị số 
            if (nv_bus.themNhanVien(/*id*/0, txtQLNVtendangnhap.Text, txtQLNVhoten.Text, comQLNVgioitinh.Text, txtQLNVdienthoai.Text, comQLNVchucvu.Text, Trangthai,txtMatKhau.Text))
            {
                MessageBox.Show("Đã thêm thành công");

                NhanVien();
                ControlNhanVien(nv_dto);
            }
        }

        private void btnDMTAthem_Click(object sender, EventArgs e) //Thêm loại thức ăn(danh mục thức ăn)
        {

            Loaithucan_BUS lta_bus = new Loaithucan_BUS();
            Loaithucan_DTO lta_dto = new Loaithucan_DTO();
            int Trangthai = int.Parse(txtLoaiThucAnTrangthai.Text.ToString());
            //int id = int.Parse(txtDMTAid.Text.ToString());
            if (lta_bus.themLoaithucan(/*id*/0, txtDMTAtenloai.Text, Trangthai))
            {
                MessageBox.Show("Đã thêm thành công");

                DanhMuc();
                ControlDanhMuc(lta_dto);
            }
        }



        private void btnDMTAlammoi_Click(object sender, EventArgs e)
        {
            txtDMTAid.Text = "ID tự tăng";
            txtDMTAtenloai.Text = "";
            btnDMTAthem.Enabled = true;
        }

        private void btnTAthemmoi_Click(object sender, EventArgs e)
        {

            txtTAid.Text = "ID tự tăng";
            txtTAten.Text = "";
            txtTAgia.Text = "";
            btnTAThem.Enabled = true;
        }

        private void btnQLNVsua_Click(object sender, EventArgs e)
        {

            //string gioiTinh = (radNam.Checked == true) ? "Nam" : "Nu";
            NhanVien_BUS nv_bus = new NhanVien_BUS();
            NhanVien_DTO nv_dto = new NhanVien_DTO();
            int id = int.Parse(txtQLNVid.Text.ToString());
            int Trangthai = int.Parse(txtQLNVTrangthai.Text.ToString());
            if (nv_bus.suaNhanVien(id, txtQLNVtendangnhap.Text, txtQLNVhoten.Text, comQLNVgioitinh.Text, txtQLNVdienthoai.Text, comQLNVchucvu.Text, Trangthai,txtMatKhau.Text))
            {
                MessageBox.Show("Đã sửa thành công");

                NhanVien();
                ControlNhanVien(nv_dto);
            }
            else
            {
                MessageBox.Show("Đã sửa thất bại");
            }

        }

        private void btnQLNVxoa_Click(object sender, EventArgs e)
        {
            //string gioiTinh = (radNam.Checked == true) ? "Nam" : "Nu";
            NhanVien_BUS nv_bus = new NhanVien_BUS();
            NhanVien_DTO nv_dto = new NhanVien_DTO();
            int id = int.Parse(txtQLNVid.Text.ToString());
            int Trangthai = int.Parse(txtQLNVTrangthai.Text.ToString());
            if (nv_bus.xoaNhanVien(id, txtQLNVtendangnhap.Text, txtQLNVhoten.Text, comQLNVgioitinh.Text, txtQLNVdienthoai.Text, comQLNVchucvu.Text, Trangthai,txtMatKhau.Text))
            {
                MessageBox.Show("Đã xoá thành công");

                NhanVien();
                ControlNhanVien(nv_dto);
            }
            else
            {
                MessageBox.Show("Đã xoá thất bại");
            }

        }

        private void btnDMTAsua_Click(object sender, EventArgs e)
        {
            Loaithucan_BUS lta_bus = new Loaithucan_BUS();
            Loaithucan_DTO lta_dto = new Loaithucan_DTO();
            int id = int.Parse(txtDMTAid.Text.ToString());
            int Trangthai = int.Parse(txtLoaiThucAnTrangthai.Text.ToString());
            if (lta_bus.suaLoaithucan(id, txtDMTAtenloai.Text, Trangthai))
            {
                MessageBox.Show("Đã sửa thành công");
                DanhMuc();
                ControlDanhMuc(lta_dto);
            }
            else
            {
                MessageBox.Show("Đã sửa thất bại");
            }

        }

        private void btnDMTAxoa_Click(object sender, EventArgs e)
        {
            Loaithucan_BUS lta_bus = new Loaithucan_BUS();
            Loaithucan_DTO lta_dto = new Loaithucan_DTO();
            int id = int.Parse(txtDMTAid.Text.ToString());
            int Trangthai = int.Parse(txtLoaiThucAnTrangthai.Text.ToString());
            if (lta_bus.xoaLoaithucan(id, txtDMTAtenloai.Text, Trangthai))
            {
                MessageBox.Show("Đã xoá thành công");
                DanhMuc();
                ControlDanhMuc(lta_dto);
            }
            else
            {
                MessageBox.Show("Đã xoá thất bại");
            }

        }

        private void btnTAsua_Click(object sender, EventArgs e)
        {
            Thucan_BUS ta_bus = new Thucan_BUS();
            Thucan_DTO ta_dto = new Thucan_DTO();
            int Loaithucan = int.Parse(comTAidloaithucan.Text.ToString());
            //string gioiTinh = (radNam.Checked == true) ? "Nam" : "Nu";
            //int Trangthai = int.Parse(txtTATrangthai.ToString());
            int id = int.Parse(txtTAid.Text.ToString());
            if (ta_bus.suaThucan(id, txtTAten.Text, Loaithucan, txtTAgia.Text, 1))// TRang thai = 1 hien thi len danh sach
            {
                MessageBox.Show("Đã sửa thành công");

                Thucan();
                ControlThucAn(ta_dto);
            }
            else
            {
                MessageBox.Show("Đã sửa thất bại");
            }

        }

        private void btnTAxoa_Click(object sender, EventArgs e)
        {
            Thucan_BUS ta_bus = new Thucan_BUS();
            Thucan_DTO ta_dto = new Thucan_DTO();
            int Loaithucan = int.Parse(comTAidloaithucan.Text.ToString());
            //string gioiTinh = (radNam.Checked == true) ? "Nam" : "Nu";
            int id = int.Parse(txtTAid.Text.ToString());
            int Trangthai = int.Parse(txtTATrangthai.Text.ToString());
            if (ta_bus.xoaThucan(id, txtTAten.Text, Loaithucan, txtTAgia.Text, Trangthai))
            {
                MessageBox.Show("Đã xoá thành công");

                Thucan();
                ControlThucAn(ta_dto);
            }
            else
            {
                MessageBox.Show("Đã xoá thất bại");
            }

        }

        private void btnBthem_Click(object sender, EventArgs e)
        {
            Ban_BUS b_bus = new Ban_BUS();
            Ban_DTO b_dto = new Ban_DTO();
            int Trangthai = int.Parse(txtBtrangthai.Text.ToString());
            //int id = int.Parse(txtBanid.Text.ToString());
           
            if (b_bus.themBan(/*id*/0, txtBanTen.Text, txtBtrangthai.Text, Trangthai)) // txtBtrangthai: Ban trong hoac ko trong ,  Trangthai:1 hien thi, 0 ko hien thi
            {
                MessageBox.Show("Đã thêm thành công");
                Ban();
                ControlBan(b_dto);
            }
            else
            {
                MessageBox.Show("Đã thêm thất bại");
            }

        }

        private void btnBsua_Click(object sender, EventArgs e)
        {
            Ban_BUS b_bus = new Ban_BUS();
            Ban_DTO b_dto = new Ban_DTO();
            int Trangthai = int.Parse(txtBtrangthai.Text.ToString());
            int id = int.Parse(txtBanid.Text.ToString());
            if (b_bus.suaBan(id, txtBanTen.Text, txtBtrangthai.Text, Trangthai)) // txtBtrangthai: Ban trong hoac ko trong ,  Trangthai:1 hien thi, 0 ko hien thi
            {
                MessageBox.Show("Đã sửa thành công");
                Ban();
                ControlBan(b_dto);
            }
            else
            {
                MessageBox.Show("Đã sửa thất bại");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Ban_BUS b_bus = new Ban_BUS();
            Ban_DTO b_dto = new Ban_DTO();
            int Trangthai = int.Parse(txtBtrangthai.Text.ToString());
            int id = int.Parse(txtBanid.Text.ToString());
            if (b_bus.xoaBan(id, txtBanTen.Text, txtBtrangthai.Text, Trangthai)) // txtBtrangthai: Ban trong hoac ko trong ,  Trangthai:1 hien thi, 0 ko hien thi
            {
                MessageBox.Show("Đã xoá thành công");
                Ban();
                ControlBan(b_dto);
            }
            else
            {
                MessageBox.Show("Đã xoá thất bại");
            }

        }
        /*   da = new SqlDataAdapter("SELECT * FROM dbo.ThucAn ", conn);
           
            DataTable dt = new DataTable();
            da.Fill(dt);
            //lstBoxSanPham.DataSource = dt;*/
        private void btnQLNVTimkiem_Click(object sender, EventArgs e)
        {
            string cachtim = comQLNVCachtim.SelectedItem.ToString();
            switch (cachtim)
            {
                case "Họ Tên":
                    //NhanVien_BUS nv_bus = new NhanVien_BUS();
                    //NhanVien_DTO nv_dto = new NhanVien_DTO();
                    string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection conn1 = new SqlConnection(strKetNoi1);
                    string truyVan1 = " select * from dbo.NhanVien where Trangthai=1 and Hoten like '%" + txtQLNVtimkiem.Text.Trim() + "%'"; // strim là xoa trantg để 2 dấu % vì tìm kiếm được 2 trường hợp kí tự ở sau và trước 

                    SqlDataAdapter da1;
                    da1 = new SqlDataAdapter(truyVan1, conn1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    dgvQLNhanVien.DataSource = dt1;

                    //ControlNhanVien(nv_dto);

                    break;

                case "Giới tính":
                    string strKetNoi2 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection conn2 = new SqlConnection(strKetNoi2);
                    string truyVan2 = " select * from dbo.NhanVien where Trangthai=1 and GioiTinh like '%" + txtQLNVtimkiem.Text.Trim() + "%'";
                    SqlDataAdapter da2;
                    da2 = new SqlDataAdapter(truyVan2, conn2);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    dgvQLNhanVien.DataSource = dt2;
                    break;
                case "Chức vụ":
                    string strKetNoi3 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection conn3 = new SqlConnection(strKetNoi3);
                    string truyVan3 = " select * from dbo.NhanVien where Trangthai=1 and Chucvu like '%" + txtQLNVtimkiem.Text.Trim() + "%'";
                    SqlDataAdapter da3;
                    da3 = new SqlDataAdapter(truyVan3, conn3);
                    DataTable dt3 = new DataTable();
                    da3.Fill(dt3);
                    dgvQLNhanVien.DataSource = dt3;
                    break;
                case "Điện thoại":
                    string strKetNoi4 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection conn4 = new SqlConnection(strKetNoi4);
                    string truyVan4 = " select * from dbo.NhanVien where Trangthai=1 and Dienthoai like '%" + txtQLNVtimkiem.Text.Trim() + "%'";
                    SqlDataAdapter da4;
                    da4 = new SqlDataAdapter(truyVan4, conn4);
                    DataTable dt4 = new DataTable();
                    da4.Fill(dt4);
                    dgvQLNhanVien.DataSource = dt4;
                    break;
                case "Mã nhân viên":
                    try
                    {
                        string strKetNoi5 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                        SqlConnection conn5 = new SqlConnection(strKetNoi5);
                        int id = int.Parse(txtQLNVtimkiem.Text.ToString());
                        string truyVan5 = " select * from dbo.NhanVien where Trangthai=1 and id =" + id;
                        SqlDataAdapter da5;
                        da5 = new SqlDataAdapter(truyVan5, conn5);
                        DataTable dt5 = new DataTable();
                        da5.Fill(dt5);
                        dgvQLNhanVien.DataSource = dt5;
                       
                    }
                    catch(Exception ex)
                    {
                        
                    }
                    break;
                default:
                    MessageBox.Show("Bạn chưa chọn cách tìm kiếm." + cachtim);
                    break;
            }

            //try
            //{
            //int id = int.Parse(txtQLNVtimkiem.Text.ToString());
            //string strKetNoi5 = "Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
            //    SqlConnection conn5 = new SqlConnection(strKetNoi5);
            //    string truyVan5 = "select *  from dbo.NhanVien where Trangthai=1 and  Tendangnhap   like '%" + txtQLNVtimkiem.Text.Trim() + "%' or Hoten like '%" + txtQLNVtimkiem.Text.Trim() + "%' or Gioitinh like '%" + txtQLNVtimkiem.Text.Trim() + "%' or Dienthoai like '%" + txtQLNVtimkiem.Text.Trim() + "%' or Chucvu like '%" + txtQLNVtimkiem.Text.Trim() + "%' or Matkhau like '%" + txtQLNVtimkiem.Text.Trim() + "%' or id="+txtQLNVtimkiem.Text;
            //    SqlDataAdapter da5;
            //    da5 = new SqlDataAdapter(truyVan5, conn5);
            //    DataTable dt5 = new DataTable();
            //    da5.Fill(dt5);

            //    dgvQLNhanVien.DataSource = dt5;
            //if (dt5.Rows.Count == 0)
            //{
            //    throw new System.ArgumentException("Parameter cannot be null", "original");
            //}
            //}
            //catch (Exception ex)
            //{
            //    string strKetNoi5 = "Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
            //    SqlConnection conn5 = new SqlConnection(strKetNoi5);
            //    string truyVan5 = "select *  from dbo.NhanVien where Trangthai=1 and id = " + txtLTATimkiem.Text.Trim();
            //    SqlDataAdapter da5;
            //    da5 = new SqlDataAdapter(truyVan5, conn5);
            //    DataTable dt5 = new DataTable();
            //    da5.Fill(dt5);
            //    dgvQLNhanVien.DataSource = dt5;

            //}



            //NhanVien_BUS nv_bus = new NhanVien_BUS();
            //NhanVien_DTO nv_dto = new NhanVien_DTO();
            //string strKetNoi1 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
            //SqlConnection conn1 = new SqlConnection(strKetNoi1);
            //string truyVan1 = " select * from dbo.NhanVien where Trangthai=1 and Hoten like '%" + txtQLNVtimkiem.Text.Trim() + "%'"; // strim là xoa trantg để 2 dấu % vì tìm kiếm được 2 trường hợp kí tự ở sau và trước 

            //SqlDataAdapter da1;
            //da1 = new SqlDataAdapter(truyVan1, conn1);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);
            //dgvQLNhanVien.DataSource = dt1;

            //ControlNhanVien(nv_dto);


        }

        private void dgvQLNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQLNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvQLNhanVien.SelectedRows.Count > 0)
            //{
                //dgvQLNhanVien.ReadOnly = true;
                ////string gioiTinh = (radNam.Checked == true) ? "Nam" : "Nu";
                //////dgvQLNhanVien.CurrentRow.Selected = true;
                ////txtQLNVhoten.Text = dgvDanhMuc.SelectedRows[0].DataBoundItem.ToString();
                //txtQLNVid.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["id"].FormattedValue.ToString();
                //txtQLNVtendangnhap.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Tendangnhap"].FormattedValue.ToString();
                //txtQLNVhoten.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Hoten"].FormattedValue.ToString();
                //txtQLNVdienthoai.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Dienthoai"].FormattedValue.ToString();
                //comQLNVgioitinh.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Gioitinh"].FormattedValue.ToString();
                //comQLNVchucvu.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Chucvu"].FormattedValue.ToString();
                //txtQLNVTrangthai.Text = dgvQLNhanVien.Rows[e.ColumnIndex].Cells["Trangthai"].FormattedValue.ToString();

        }

        private void btnLTATimkiem_Click(object sender, EventArgs e)
        {
            string cachtimLoaithucan = comLTACachtim.SelectedItem.ToString();
            switch (cachtimLoaithucan)
            {
                case "Tên loại thức ăn":
                    //Loaithucan_DTO lta = new Loaithucan_DTO();
                    string strKetNoi5 = "Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
                    SqlConnection conn5 = new SqlConnection(strKetNoi5);
                    string truyVan5 = "select *  from dbo.LoaiThucAn where Trangthai=1 and Ten like '%" + txtLTATimkiem.Text.Trim() + "%'";
                    SqlDataAdapter da5;
                    da5 = new SqlDataAdapter(truyVan5, conn5);
                    DataTable dt5 = new DataTable();
                    da5.Fill(dt5);
                    dgvDanhMuc.DataSource = dt5;
                    break;


                case "Mã loại thức ăn":
                    try
                    {
                        string strKetNoi6 = "Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
                        SqlConnection conn6 = new SqlConnection(strKetNoi6);

                        int id = int.Parse(txtLTATimkiem.Text.ToString());
                        string truyVan6 = "select *  from dbo.LoaiThucAn where Trangthai=1 and id =" + id;
                        SqlDataAdapter da6;
                        da6 = new SqlDataAdapter(truyVan6, conn6);
                        DataTable dt6 = new DataTable();
                        da6.Fill(dt6);
                        dgvDanhMuc.DataSource = dt6;
                    }
                    catch(Exception ex)
                    {
                       
                    }
                   
                    break;
            }
            //try
            //{

            //    string strKetNoi5 ="Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
            //    SqlConnection conn5 = new SqlConnection(strKetNoi5);
            //    string truyVan5 = "select *  from dbo.LoaiThucAn where Trangthai=1 and Ten like '%" + txtLTATimkiem.Text.Trim() + "%'";
            //    SqlDataAdapter da5;
            //    da5 = new SqlDataAdapter(truyVan5, conn5);
            //    DataTable dt5 = new DataTable();
            //    da5.Fill(dt5);
            //    if (dt5.Rows.Count==0)
            //    {
            //        throw new System.ArgumentException("Parameter cannot be null", "original");
            //    }
            //    dgvDanhMuc.DataSource = dt5;

            //}
            //catch (Exception ex)
            //{
            //    string strKetNoi5 = "Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
            //    SqlConnection conn5 = new SqlConnection(strKetNoi5);
            //    string truyVan5 = "select *  from dbo.LoaiThucAn where Trangthai=1 and id = " + txtLTATimkiem.Text.Trim();
            //    SqlDataAdapter da5;
            //    da5 = new SqlDataAdapter(truyVan5, conn5);
            //    DataTable dt5 = new DataTable();
            //    da5.Fill(dt5);
            //    dgvDanhMuc.DataSource = dt5;

            //}
            //Loaithucan_DTO lta = new Loaithucan_DTO();




        }   
        

        private void txtQLNVtimkiem_TextChanged(object sender, EventArgs e)
        {
           
             
        }

        private void btnTATimkim_Click(object sender, EventArgs e)
        {


            string cachtimLoaithucan = comTACachtim.SelectedItem.ToString();
            switch (cachtimLoaithucan)
            {
                case "Mã thức ăn":
                    try
                    {
                        string strKetNoi6 = "Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
                        SqlConnection conn6 = new SqlConnection(strKetNoi6);

                        int id = int.Parse(txtTATimkiem.Text.ToString());
                        string truyVan6 = "select * from dbo.ThucAn where Trangthai=1 and id =" + id;
                        SqlDataAdapter da6;
                        da6 = new SqlDataAdapter(truyVan6, conn6);
                        DataTable dt6 = new DataTable();
                        da6.Fill(dt6);
                        dgvThucan.DataSource = dt6;
                    }
                    catch(Exception ex)
                    {
                       
                    }
                  
                    break;
                case "Tên thức ăn":
                    string strKetNoi7 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection conn7 = new SqlConnection(strKetNoi7);

                    //int id1 = int.Parse(txtTATimkiem.Text.ToString());
                    string truyVan7 = " select* from dbo.ThucAn where Ten like '%" + txtTATimkiem.Text.Trim() + "%'AND Trangthai = 1";
                    //string truyVan7 = "SELECT * FROM dbo.ThucAn WHERE Trangthai=1 AND Ten like '% " +  + "%'";
                    SqlDataAdapter da7;
                    da7 = new SqlDataAdapter(truyVan7, conn7);
                    DataTable dt7 = new DataTable();
                    da7.Fill(dt7);
                    dgvThucan.DataSource = dt7;
                    break;
            }


        }

        private void btnBTimkiem_Click(object sender, EventArgs e)
        {

            string tim = comBCachtim.SelectedItem.ToString();
            switch (tim)
            {
                case "Mã bàn":
                    try
                    {
                        string strKetNoi6 = "Data Source = QUYVINH\\SQLEXPRESS; Initial Catalog = quanliquancoffee50; Integrated Security = True";
                        SqlConnection conn6 = new SqlConnection(strKetNoi6);

                        int id = int.Parse(txtBTimkiem.Text.ToString());
                        string truyVan6 = "select * from dbo.BanAn where Trangthai=1 and id =" + id;
                        SqlDataAdapter da6;
                        da6 = new SqlDataAdapter(truyVan6, conn6);
                        DataTable dt6 = new DataTable();
                        da6.Fill(dt6);
                        dgvBan.DataSource = dt6;
                    }
                    catch(Exception ex)
                    {
                        
                    }
                   
                    break;
                case "Tên bàn":
                    string strKetNoi7 = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
                    SqlConnection conn7 = new SqlConnection(strKetNoi7);

                    //int id1 = int.Parse(txtTATimkiem.Text.ToString());
                    string truyVan7 = " select* from dbo.BanAn where Ten like '%" + txtBTimkiem.Text.Trim() + "%'AND Trangthai = 1";
                    //string truyVan7 = "SELECT * FROM dbo.ThucAn WHERE Trangthai=1 AND Ten like '% " +  + "%'";
                    SqlDataAdapter da7;
                    da7 = new SqlDataAdapter(truyVan7, conn7);
                    DataTable dt7 = new DataTable();
                    da7.Fill(dt7);
                    dgvBan.DataSource = dt7;
                    break;
            }

        }

        private void btnREPORTnv_Click(object sender, EventArgs e)
        {
            report_NV  f = new report_NV();
            f.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            REPORT_THUCAN f = new REPORT_THUCAN();
            f.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            REPORT_Loaithucan f = new REPORT_Loaithucan();
            f.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            REPORT_BAN f = new REPORT_BAN();
            f.ShowDialog();
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

        private void buttonX5_Click(object sender, EventArgs e)
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

        private void buttonX6_Click(object sender, EventArgs e)
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

        private void buttonX7_Click(object sender, EventArgs e)
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

        private void txtTATimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void ckHienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHienthimatkhau.Checked == true) // nếu cái check nó tích thì hiển thị pass
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            if (ckHienthimatkhau.Checked == false) // nếu cái check ko tích thì ẩn pass
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void dgvQLNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvQLNhanVien.Columns[e.ColumnIndex].Index == 7 && e.Value != null)
            {
                dgvQLNhanVien.Rows[e.RowIndex].Tag = e.Value;  // code này e tham khảo mạng nên chưa hiểu lắm nhưng e hiểu chức năng của nó là giấu mật khẩu đi ko để lộ trên datagridview
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}

