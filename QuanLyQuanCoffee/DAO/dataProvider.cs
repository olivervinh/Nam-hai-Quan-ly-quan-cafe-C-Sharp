using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class dataProvider
    {
       
        public static string chuoiKetNoi = "Data Source=QUYVINH\\SQLEXPRESS;Initial Catalog=quanliquancoffee50;Integrated Security=True";
        public static SqlConnection TaoKetNoi()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(chuoiKetNoi);
                con.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return con;
        }
    }
}
