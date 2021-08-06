using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hoadon_DTO
    {
        public int id { get; set; }
     
        public DateTime NgayLap { get; set; }
      
    
        public int TongTien { get; set; }
        public int Trangthai { get; set; }
        public Hoadon_DTO()
        {
            id = 1;
          
            NgayLap = DateTime.Today;

            TongTien = 1;
            Trangthai = 1;




        }

        public Hoadon_DTO(int _id, DateTime _NgayLap, int _TongTien, int _Trangthai)
        {
            id = _id;
            NgayLap = _NgayLap;
            TongTien = _TongTien;
            Trangthai = _Trangthai;
            Trangthai = _Trangthai;

        }
    }
}