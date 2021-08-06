using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoaDon_DTO
       {
        public int id { get; set; }
        public int idBill { get; set; }
        public int idFood { get; set; }
        public int Count{ get; set; }
        public float Thanhtien { get; set; }
        public int Trangthai { get; set; }
        public CTHoaDon_DTO()
        {
            id = 1;
            idBill = 1;
            idFood = 1;
            Count = 1;
            Thanhtien = 0;





        }

        public CTHoaDon_DTO(int _id, int _idBill, int _idFood, int _Count, float _Thanhtien,int _Trangthai)
        {
            id = _id;
            id = _idBill;
            idFood = _idFood;
            Count = _Count;
            Thanhtien = _Thanhtien;
            Trangthai = _Trangthai;

        }
    }
}