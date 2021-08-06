using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class Hoadon_BUS
    {
        public List<Hoadon_DTO> LayDSHoaDon()
        {

           Hoadon_DAO hd_DAO = new Hoadon_DAO();
            return hd_DAO.LayDSHoaDon();
        }

    }
}

