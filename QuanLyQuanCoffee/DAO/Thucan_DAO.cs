using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class Thucan_DAO
    {
        public List<Thucan_DTO> LayDSThucan()
        {
            List<Thucan_DTO> listTA = new List<Thucan_DTO>();
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                SqlCommand command = new SqlCommand(@"SELECT * FROM ThucAn where Trangthai=1", con);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Thucan_DTO ta = new Thucan_DTO();
                    if (dataReader.IsDBNull(0) != null)
                    {
                        ta.id = (int)dataReader["id"];
                    }
                    if (dataReader.IsDBNull(1) != null)
                    {
                        ta.Ten = dataReader["Ten"].ToString();
                    }
                    if (dataReader.IsDBNull(2) != null)
                    {
                        ta.idLoaiThucAn = (int)dataReader["idLoaiThucAn"];
                    }
                    if (dataReader.IsDBNull(3) != null)
                    {
                        ta.price = dataReader["price"].ToString();
                    }
                    if (dataReader.IsDBNull(4) != null)
                    {
                        ta.Trangthai = (int)dataReader["Trangthai"];
                    }
                    listTA.Add(ta);
                }
                dataReader.Close();
                con.Close();
            }
            return listTA;

        }
        public bool themThucan(int id,string Ten,int idLoaiThucAn, string price,int Trangthai )
        {
            //Số dòng dữ liệu 
            int numberRows = 0;
            Thucan_DTO ta = new Thucan_DTO(id, Ten, idLoaiThucAn, price,Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                string cauTruyVan = "INSERT INTO dbo.ThucAn(Ten,idLoaiThucAn,price,Trangthai) VALUES ( @Ten, @idLoaiThucAn, @price, @Trangthai)";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue(@"Ten", ta.Ten);
                com.Parameters.AddWithValue(@"idLoaiThucAn", ta.id);
                com.Parameters.AddWithValue(@"price", ta.price);
                com.Parameters.AddWithValue(@"Trangthai", ta.Trangthai);
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
        public bool suaThucan(int id, string Ten, int idLoaiThucAn, string price, int Trangthai)
        {
            //Số dòng dữ liệu 
            int numberRows = 0;
            Thucan_DTO ta = new Thucan_DTO(id, Ten, idLoaiThucAn, price, Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                string cauTruyVan = "UPDATE dbo.ThucAn SET Ten = @ten,idLoaiThucAn=@idloaithucan,price = @gia,Trangthai=@trangthai WHERE id=@ma";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue(@"ma", ta.id);
                com.Parameters.AddWithValue(@"ten", ta.Ten);
                com.Parameters.AddWithValue(@"idloaithucan", ta.idLoaiThucAn);
                com.Parameters.AddWithValue(@"gia", ta.price);
                com.Parameters.AddWithValue(@"trangthai", ta.Trangthai);

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
        public bool xoaThucan(int id, string Ten, int idLoaiThucAn, string price, int Trangthai)
        {



            //int numberRows = 0;
            //NhanVien_DTO nv = new NhanVien_DTO(id, Tendangnhap, Hoten, Gioitinh, Dienthoai, Chucvu, Trangthai);
            //SqlConnection con = dataProvider.TaoKetNoi();
            //if (con != null)
            //{

            //    string cauTruyVan = " UPDATE dbo.NhanVien SET Trangthai=0 where id=@ma";
            //    SqlCommand com = new SqlCommand(cauTruyVan, con);
            //    com.Parameters.AddWithValue(@"ma", nv.id);
            //    com.Parameters.AddWithValue(@"Tendangnhap", nv.Tendangnhap);
            //    com.Parameters.AddWithValue(@"Hoten", nv.Hoten);
            //    com.Parameters.AddWithValue(@"Gioitinh", nv.Gioitinh);
            //    com.Parameters.AddWithValue(@"Dienthoai", nv.Dienthoai);
            //    com.Parameters.AddWithValue(@"Chucvu", nv.Chucvu);
            //    numberRows = com.ExecuteNonQuery();
            //    con.Close();
            //}

            //if (numberRows > 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            int numberRows = 0;
            Thucan_DTO ta = new Thucan_DTO(id,Ten,idLoaiThucAn,price,Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                string cauTruyVan = "  UPDATE dbo.ThucAn SET Trangthai = 0 WHERE id=@ma";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue(@"ma", ta.id);
                com.Parameters.AddWithValue(@"Ten", ta.Ten);
                com.Parameters.AddWithValue(@"idLoaiThucAn", ta.id);
                com.Parameters.AddWithValue(@"price", ta.price);
                com.Parameters.AddWithValue(@"Trangthai", ta.Trangthai);

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

    }

}