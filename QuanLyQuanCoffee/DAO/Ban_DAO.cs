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
    public class Ban_DAO
    {

        public List<Ban_DTO> LayDSBan()
        {
            List<Ban_DTO> listB = new List<Ban_DTO>();
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                SqlCommand command = new SqlCommand(@"SELECT * FROM BanAn where Trangthai=1", con); // where trang thai = 1 thì nó hiển thị 

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Ban_DTO b = new Ban_DTO();
                    if (dataReader.IsDBNull(0) != null)
                    {
                        b.id = (int)dataReader["id"];
                    }
                    if (dataReader.IsDBNull(1) != null)
                    {
                        b.Ten = dataReader["Ten"].ToString();
                    }
                    if (dataReader.IsDBNull(2) != null)
                    {
                        b.status = dataReader["status"].ToString();
                    }
                    if (dataReader.IsDBNull(3) != null)
                    {
                        b.Trangthai = (int)dataReader["Trangthai"];
                    }

                    listB.Add(b);
                }
                dataReader.Close();
                con.Close();
            }
            return listB;

        }
        public bool themBan(int id, string Ten, string status, int Trangthai)
        {
            
            int numberRows = 0; // số dòng dữ liệu dc thêm vào csdl
            Ban_DTO b = new Ban_DTO(id, Ten, status, Trangthai); // tạo 1 cái bàn_dto mới
            SqlConnection con = dataProvider.TaoKetNoi(); // Tạo đối tượng kết nối (trong lớp dataProvider có mở kết nối rồi nên không gọi lạinữa)
            if (con != null) // nếu đối tượng kết nối khác  null 
            {
                string cauTruyVan = "INSERT INTO BanAn (Ten,status,Trangthai) VALUES (@Ten,@status,@Trangthai)"; // tạo câu truy vấn
                SqlCommand com = new SqlCommand(cauTruyVan, con); // Gán câu truy vấn vào command  

                com.Parameters.AddWithValue(@"Ten", b.Ten); // @"Ten " gọi lại thamsố ở trên câu truy vấn
                com.Parameters.AddWithValue(@"status", b.status); // tương tự ở  trên
                com.Parameters.AddWithValue(@"Trangthai", b.Trangthai); 
                numberRows = com.ExecuteNonQuery();//Chạy lện truy vấn 
                con.Close(); // xử lí xong thì đóng kết nối
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
        public bool suaBan(int id, string Ten, string status, int Trangthai)
        {




            int numberRows = 0;
            Ban_DTO b = new Ban_DTO(id, Ten, status, Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {

                string cauTruyVan = " update  dbo.BanAn set Ten=@ten, status =@stat, Trangthai=@trangthai WHERE id=@ma"; // @ là tham số của para
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue(@"ma", b.id);
                com.Parameters.AddWithValue(@"ten", b.Ten);
                com.Parameters.AddWithValue(@"stat", b.status);
                com.Parameters.AddWithValue(@"trangthai", b.Trangthai);

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

       

        public bool xoaBan(int id, string Ten, string status, int Trangthai)
        {
            int numberRows = 0;
            Ban_DTO b = new Ban_DTO(id, Ten, status, Trangthai);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {

                string cauTruyVan = " update  dbo.BanAn set Trangthai=0 WHERE id=@ma";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue(@"ma", b.id);
                com.Parameters.AddWithValue(@"Ten", b.Ten);
                com.Parameters.AddWithValue(@"status", b.status);
                com.Parameters.AddWithValue(@"Trangthai", b.Trangthai);

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
