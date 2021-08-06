using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class CTHoadon_DAO
    {
        public List<CTHoaDon_DTO> LayDSCTHD()
        {
            List<CTHoaDon_DTO> listCTHD = new List<CTHoaDon_DTO>();
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                SqlCommand command = new SqlCommand(@"SELECT * FROM CTHoaDon", con);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    CTHoaDon_DTO cthd = new CTHoaDon_DTO();
                    if (dataReader.IsDBNull(0) != null)
                    {
                        cthd.id = (int)dataReader["id"];
                    }
                    if (dataReader.IsDBNull(1) != null)
                    {
                        cthd.idBill = (int)dataReader["idBill"];
                    }
                    if (dataReader.IsDBNull(2) != null)
                    {
                        cthd.idFood = (int)dataReader["idFood"];
                    }
                    if (dataReader.IsDBNull(3) != null)
                    {
                        cthd.Thanhtien = (float)dataReader["Thanhtien"];
                    }
                    if (dataReader.IsDBNull(4) != null)
                    {
                        cthd.Trangthai = (int)dataReader["Trangthai"];
                    }
                    listCTHD.Add(cthd);
                }
                dataReader.Close();
                con.Close();
            }
            return listCTHD;

        }
        //public string getTenDangNhap(string tenDangNhap, string matKhau)
        //{
        //    string tenDN = "";
        //    SqlConnection con = dataProvider.TaoKetNoi();
        //    string cauTruyVan = "select *  from NHANVIEN where TENDANGNHAP ='" + tenDangNhap + "' and MATKHAU='" + matKhau + "' ";
        //    SqlDataAdapter data = new SqlDataAdapter(cauTruyVan, con);
        //    DataTable dt = new DataTable();
        //    data.Fill(dt);
        //    if (dt != null)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            tenDN = dr["TENDANGNHAP"].ToString();
        //        }
        //    }
        //    con.Close();
        //    return tenDN;
        //}
    }

}
