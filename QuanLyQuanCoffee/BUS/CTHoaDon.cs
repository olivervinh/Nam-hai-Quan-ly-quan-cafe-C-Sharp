using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CTHoaDon
    {
        public List<CTHoaDon_DTO> LayDSCTHD()
        {

            CTHoadon_DAO cthd = new CTHoadon_DAO();
            return cthd.LayDSCTHD();
        }

    }
}
