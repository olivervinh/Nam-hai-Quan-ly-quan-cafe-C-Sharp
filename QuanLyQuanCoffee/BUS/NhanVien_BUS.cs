using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public List<NhanVien_DTO> LayDSNhanVien()
        {

           NhanVien_DAO  nv = new NhanVien_DAO();
            return nv.LayDSNhanVien();
        }
        public bool themNhanVien(int id, string Tendangnhap, string Hoten, string Gioitinh, string DienThoai, string Chucvu,int Trangthai,string Matkhau)
        {
            NhanVien_DAO nv = new NhanVien_DAO();
            return nv.themNhanVien(id, Tendangnhap, Hoten, Gioitinh, DienThoai, Chucvu,Trangthai,Matkhau);
        }
        public bool suaNhanVien(int id, string Tendangnhap, string Hoten, string Gioitinh, string DienThoai, string Chucvu, int Trangthai,string Matkhau)
        {
            NhanVien_DAO nv = new NhanVien_DAO();
            return nv.suaNhanVien(id, Tendangnhap, Hoten, Gioitinh, DienThoai, Chucvu, Trangthai,Matkhau);
        }
        public bool xoaNhanVien(int id, string Tendangnhap, string Hoten, string Gioitinh, string Dienthoai, string Chucvu, int Trangthai,string Matkhau)
        {
            NhanVien_DAO nv = new NhanVien_DAO();
            return nv.xoaNhanvien(id, Tendangnhap, Hoten, Gioitinh, Dienthoai, Chucvu,Trangthai,Matkhau);
        }
    
    }
}
          