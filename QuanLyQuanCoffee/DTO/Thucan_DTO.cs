using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Thucan_DTO
    {
        public int id { get; set; }
        public string Ten { get; set; }
        public int idLoaiThucAn { get; set; }
        public string price { get; set; }
        public int Trangthai { get; set; } 

        public Thucan_DTO()
        {
            id = 1;
            Ten = "";
            idLoaiThucAn = 1;
            price = "";
            Trangthai = 1;



        }

        public Thucan_DTO(int _id, string _Ten, int _idLoaiThucAn, string _price, int _Trangthai)
        {
            id = _id;
            Ten = _Ten;
            idLoaiThucAn = _idLoaiThucAn;
            price = _price;
            Trangthai = _Trangthai;
        }
    }
}