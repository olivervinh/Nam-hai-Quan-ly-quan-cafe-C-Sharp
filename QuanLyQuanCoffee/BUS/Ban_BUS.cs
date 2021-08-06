using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
     public class Ban_BUS
    {
        public List<Ban_DTO> LayDSBan()
        {

            Ban_DAO b = new Ban_DAO();
            return b.LayDSBan();
        }
        public bool themBan(int id, string Ten, string status, int Trangthai)
        {
            Ban_DAO b = new Ban_DAO();
            return b.themBan(id, Ten, status, Trangthai);
        }
        public bool suaBan(int id, string Ten, string status, int Trangthai)
        {
            Ban_DAO b = new Ban_DAO();
            return b.suaBan(id, Ten, status, Trangthai);
        }
        public bool xoaBan(int id, string Ten, string status, int Trangthai)
        {
            Ban_DAO b = new Ban_DAO();
            return b.xoaBan(id, Ten, status, Trangthai);
        }
    }
}
