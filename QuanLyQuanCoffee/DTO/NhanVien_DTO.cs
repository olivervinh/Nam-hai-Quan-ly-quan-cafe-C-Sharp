using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
   public class NhanVien_DTO
    {
        public int id{ get; set; }
        public string Tendangnhap { get; set; }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public string Dienthoai { get; set; }
        public string Chucvu { get; set; }
        public int Trangthai { get; set; }
        public string Matkhau { get; set; }
        public NhanVien_DTO()
        {
            id = 0;
            Tendangnhap = "";
            Hoten = "";
            Gioitinh = "";
            Dienthoai = "";
            Chucvu = "";
            Trangthai = 1;
            Matkhau = "";
        }

        public NhanVien_DTO(int _id, string _Tendangnhap, string _Hoten, string _Gioitinh, string _Dienthoai, string _Chucvu,int _Trangthai,string _Matkhau)
        {
            id = _id;
            Tendangnhap = _Tendangnhap;
            Hoten = _Hoten;
            Gioitinh = _Gioitinh;
            Dienthoai = _Dienthoai;
            Chucvu = _Chucvu;
            Trangthai = _Trangthai;
            Matkhau = _Matkhau;
        }
    }
}