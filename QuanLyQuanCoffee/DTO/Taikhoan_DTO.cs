using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Taikhoan_DTO
       {
 
            public string Tendangnhap { get; set; }
            public string Matkhau { get; set; }
            public string Loai { get; set; }
            public int Trangthai { get; set; }
            public Taikhoan_DTO()
            {
            //Tendangnhap = "";
            //Matkhau = "";
            //Loai = "" ;
            //Trangthai = 1;
            }
            public Taikhoan_DTO(string _Tendangnhap, string _Matkhau, string _Loai,int _Trangthai)
            {
            Tendangnhap = _Tendangnhap;
            Matkhau = _Matkhau;
            Loai = _Loai;
            Trangthai = _Trangthai;
            }
      }
}
