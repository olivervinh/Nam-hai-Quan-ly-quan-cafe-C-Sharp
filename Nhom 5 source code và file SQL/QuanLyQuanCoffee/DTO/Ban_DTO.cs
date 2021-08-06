using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ban_DTO
    {
        public int id { get; set; }
        public string Ten { get; set; }
        public string status { get; set; }
        public int Trangthai { get; set; }

        public Ban_DTO()
        {
            id = 1;
            Ten = "";
            status = "";
            Trangthai = 1;





        }

        public Ban_DTO(int _id, string _Ten, string _status, int _Trangthai)
        {
            id = _id;
            Ten = _Ten;
            status = _status;
            Trangthai = _Trangthai;


        }

    }
}
    
