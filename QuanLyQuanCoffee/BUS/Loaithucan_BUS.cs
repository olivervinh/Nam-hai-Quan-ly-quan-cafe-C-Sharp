using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class Loaithucan_BUS
    {
        public List<Loaithucan_DTO> LayDSLoaithucan()
        {

            Loaithucan_DAO lta = new Loaithucan_DAO();
            return lta.LayDSLoaithucan();
        }
        public bool themLoaithucan(int id, string Ten, int Trangthai)
        {
            Loaithucan_DAO nv = new Loaithucan_DAO();
            return nv.themLoaithucan(id, Ten,Trangthai);
        }
        public bool suaLoaithucan(int id, string Ten, int Trangthai)
        {
            Loaithucan_DAO nv = new Loaithucan_DAO();
            return nv.suaLoaithucan(id, Ten, Trangthai);
        }
        public bool xoaLoaithucan(int id, string Ten, int Trangthai)
        {
            Loaithucan_DAO nv = new Loaithucan_DAO();
            return nv.xoaLoaithucan(id, Ten, Trangthai);
        }
    }
}
