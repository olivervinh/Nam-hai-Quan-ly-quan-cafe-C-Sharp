using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Taikhoan_BUS
    {
        public List<Taikhoan_DTO> LayDSTaikhoan()
        {

            Taikhoan_DAO tk_DAO = new Taikhoan_DAO();
            return tk_DAO.LayDSTaikhoan();
        }
        
    }
}
