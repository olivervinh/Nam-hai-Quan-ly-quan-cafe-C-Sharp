using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class Hoadon_DAO
    {
        public List<Hoadon_DTO> LayDSHoaDon()
        {
            List<Hoadon_DTO> listHD = new List<Hoadon_DTO>();
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                SqlCommand command = new SqlCommand(@"SELECT * FROM HoaDon WHERE Trangthai = 1", con);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Hoadon_DTO hd = new Hoadon_DTO();
                    if (dataReader.IsDBNull(0) != null)
                    {
                        hd.id = (int)dataReader["id"];
                    }
                  

                    if (dataReader.IsDBNull(3) != null)
                    {
                        hd.NgayLap = (DateTime)dataReader["NgayLap"];

                    }
                    if (dataReader.IsDBNull(4) != null)
                    {
                        hd.TongTien = (int)dataReader["Tongtien"];
                    }
                    if (dataReader.IsDBNull(5) != null)
                    {
                        hd.Trangthai = (int)dataReader["Trangthai"];
                    }
                    listHD.Add(hd);
                }
                
                dataReader.Close();
                con.Close();
            }
            return listHD;

        }
    }
}
//        //public string getTenDangNhap(string tenDangNhap, string matKhau)
//        //{
//        //    string tenDN = "";
//        //    SqlConnection con = dataProvider.TaoKetNoi();
//        //    string cauTruyVan = "select *  from NHANVIEN where TENDANGNHAP ='" + tenDangNhap + "' and MATKHAU='" + matKhau + "' ";
//        //    SqlDataAdapter data = new SqlDataAdapter(cauTruyVan, con);
//        //    DataTable dt = new DataTable();
//        //    data.Fill(dt);
//        //    if (dt != null)
//        //    {
//        //        foreach (DataRow dr in dt.Rows)
//        //        {
//        //            tenDN = dr["TENDANGNHAP"].ToString();
//        //        }
//        //    }
//        //    con.Close();
//        //    return tenDN;
//        //}
//    }

//}
