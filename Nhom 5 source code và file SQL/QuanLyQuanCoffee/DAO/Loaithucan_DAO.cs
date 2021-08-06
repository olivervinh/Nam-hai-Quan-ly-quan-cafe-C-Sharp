using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
     public class Loaithucan_DAO
    {
        public List<Loaithucan_DTO> LayDSLoaithucan()
        {
            List<Loaithucan_DTO> listLTA = new List<Loaithucan_DTO>();
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                SqlCommand command = new SqlCommand(@"SELECT * FROM Loaithucan Where Trangthai =1", con);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Loaithucan_DTO lta = new Loaithucan_DTO();
                    if (dataReader.IsDBNull(0) != null)
                    {
                        lta.id = (int)dataReader["id"];
                    }
                    if (dataReader.IsDBNull(1) != null)
                    {
                        lta.Ten = dataReader["Ten"].ToString();
                    }
                    if (dataReader.IsDBNull(2) != null)
                    {
                        lta.Trangthai = (int)dataReader["Trangthai"];
                    }


                    listLTA.Add(lta);
                }
                dataReader.Close();
                con.Close();
            }
            return listLTA;

        }
       public bool themLoaithucan(int id, string Ten,int Trangthai)
        {

            int numberRows = 0;
            Loaithucan_DTO lta = new Loaithucan_DTO(id, Ten,Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                string cauTruyVan = "INSERT INTO LoaiThucAn(Ten,Trangthai) VALUES ( @Ten,@Trangthai)";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                
                com.Parameters.AddWithValue(@"Ten", lta.Ten);
                com.Parameters.AddWithValue(@"Trangthai", lta.Trangthai);
                numberRows = com.ExecuteNonQuery();
                con.Close();
            }




            if (numberRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool suaLoaithucan(int id, string Ten, int Trangthai)
        {
            //    int numberRows = 0;
            //    NhanVien_DTO nv = new NhanVien_DTO( 0,Tendangnhap, Hoten, Gioitinh, Dienthoai, Chucvu);
            //    SqlConnection con = dataProvider.TaoKetNoi();
            //    string cauTruyVan = "UPDATE dbo.NhanVien SET Tendangnhap=@Tendangnhap, Hoten = @Hoten, Gioitinh=@Gioitinh, Dienthoai=@Dienthoai, Chucvu = @chucvu ";


            //    com.Parameters.AddWithValue("Tendangnhap", nv.Tendangnhap);
            //    com.Parameters.AddWithValue("Hoten", nv.Hoten);
            //    com.Parameters.AddWithValue("Gioitinh", nv.Hoten);
            //    com.Parameters.AddWithValue("Dienthoai", nv.Dienthoai);
            //    com.Parameters.AddWithValue("Chucvu", nv.Chucvu);



            //    if (numberRows > 0)
            //        return true;
            //    else
            //        return false;
            //    con.Close();




            int numberRows = 0;
            Loaithucan_DTO lta = new Loaithucan_DTO(id, Ten,Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {

                string cauTruyVan = " update  dbo.Loaithucan set Ten=@ten WHERE id=@ma";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue(@"ma", lta.id);
                com.Parameters.AddWithValue(@"Ten", lta.Ten);
             
                numberRows = com.ExecuteNonQuery();
                con.Close();
            }

            if (numberRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Xóa

        public bool xoaLoaithucan(int id, string Ten, int Trangthai)
        {

            //SqlConnection con= dataProvider.TaoKetNoi();
            //string cauTruyVan = "DELETE FROM dbo.NhanVien WHERE id=@id";
            //SqlCommand com = new SqlCommand(cauTruyVan, con);
            //com.Parameters.AddWithValue("id", id);
            //int numberRows = com.ExecuteNonQuery();
            //con.Close();
            //if (numberRows > 0)
            //    return true;
            //else
            //    return false;
            //con.Close();


            int numberRows = 0;
            Loaithucan_DTO lta = new Loaithucan_DTO(id, Ten, Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {

                string cauTruyVan = " UPDATE dbo.Loaithucan SET Trangthai=0 where id=@ma";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue(@"ma", lta.id);
                com.Parameters.AddWithValue(@"Ten", lta.Ten);
                
                numberRows = com.ExecuteNonQuery();
                con.Close();
            }

            if (numberRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }

}
