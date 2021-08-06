
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Thucan_BUS
    {


        public List<Thucan_DTO> LayDSThucan()
        {

            Thucan_DAO ta_DAO = new Thucan_DAO();
            return ta_DAO.LayDSThucan();
        }
        public bool themThucan(int id, string Ten, int idLoaiThucAn, string price,int Trangthai )
        {
            Thucan_DAO ta = new Thucan_DAO();
            return ta.themThucan(id, Ten, idLoaiThucAn,price,Trangthai);
        }
        public bool suaThucan(int id, string Ten, int idLoaiThucAn, string price, int Trangthai)
        {
            Thucan_DAO ta = new Thucan_DAO();
            return ta.suaThucan(id, Ten, idLoaiThucAn, price, Trangthai);
        }
        public bool xoaThucan(int id, string Ten, int idLoaiThucAn, string price, int Trangthai)
        {
            Thucan_DAO ta = new Thucan_DAO();
            return ta.xoaThucan(id, Ten, idLoaiThucAn, price, Trangthai);
        }
    }
}
