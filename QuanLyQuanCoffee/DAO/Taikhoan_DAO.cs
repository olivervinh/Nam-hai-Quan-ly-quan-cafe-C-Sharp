using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;

namespace DAO
{
    public class Taikhoan_DAO
    {
        public List<Taikhoan_DTO> LayDSTaikhoan()
        {
            List<Taikhoan_DTO> listTK = new List<Taikhoan_DTO>();
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                SqlCommand command = new SqlCommand(@"SELECT * FROM Taikhoan", con);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Taikhoan_DTO tk = new Taikhoan_DTO();
                    if (dataReader.IsDBNull(0) != null)
                    {
                        tk.Tendangnhap = dataReader["Tendangnhap"].ToString();
                    }
                    if (dataReader.IsDBNull(1) != null)
                    {
                        tk.Matkhau = dataReader["Matkhau"].ToString();
                    }
                    if (dataReader.IsDBNull(2) != null)
                    {
                        tk.Loai = dataReader["Loai"].ToString();
                    }
                    

                    listTK.Add(tk);
                }
                dataReader.Close();
                con.Close();
            }
            return listTK;

        }
    }

}
