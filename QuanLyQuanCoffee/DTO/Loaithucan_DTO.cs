using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loaithucan_DTO
    {
        public int id { get; set; }
       public string Ten { get; set; }
        public int Trangthai { get; set; }
        public Loaithucan_DTO()
        {
            id = 1;
            Ten = "";
            Trangthai=1;
        }

        public Loaithucan_DTO(int _id, string _Ten,int _Trangthai)
        {
            id = _id;
            Ten = _Ten;
            Trangthai = _Trangthai;
        }
    }
}