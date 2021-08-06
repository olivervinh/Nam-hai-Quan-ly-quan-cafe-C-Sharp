using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Microsoft.SqlServer.Server;

namespace DAO
{
    public class NhanVien_DAO
    {
       
        public List<NhanVien_DTO> LayDSNhanVien()
        {
            List<NhanVien_DTO> listNV = new List<NhanVien_DTO>();
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
                SqlCommand command = new SqlCommand(@"SELECT * FROM NhanVien where Trangthai = 1", con);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    if (dataReader.IsDBNull(0) != null)
                    {
                        nv.id = (int)dataReader["id"];
                    }
                    if (dataReader.IsDBNull(1) != null)
                    {
                        nv.Tendangnhap = dataReader["Tendangnhap"].ToString();
                    }
                    if (dataReader.IsDBNull(2) != null)
                    {
                        nv.Hoten = dataReader["Hoten"].ToString();
                    }
                    if (dataReader.IsDBNull(3) != null)
                    {
                        nv.Gioitinh = dataReader["Gioitinh"].ToString();
                    }
                    if (dataReader.IsDBNull(4) != null)
                    {
                        nv.Dienthoai = dataReader["Dienthoai"].ToString();
                    }
                    if (dataReader.IsDBNull(5) != null)
                    {
                        nv.Chucvu = dataReader["Chucvu"].ToString();
                    }
                    if (dataReader.IsDBNull(6) != null)
                    {
                        nv.Trangthai = (int)dataReader["Trangthai"];
                    }
                    if(dataReader.IsDBNull(7)!=null)
                    {
                        nv.Matkhau = dataReader["Matkhau"].ToString();
                    }
                    listNV.Add(nv);
                    
                }
                dataReader.Close();
                con.Close();
            }
            return listNV;

        }
        public bool themNhanVien(int id, string Tendangnhap, string Hoten, string Gioitinh, string Dienthoai, string Chucvu,int Trangthai,string Matkhau)
        {
            //Số dòng dữ liệu 
            int numberRows = 0;
            NhanVien_DTO nv = new NhanVien_DTO (id, Tendangnhap, Hoten, Gioitinh, Dienthoai, Chucvu,Trangthai,Matkhau);
            SqlConnection con = dataProvider.TaoKetNoi();
            if(con!=null)
            {
                string  cauTruyVan = "INSERT INTO NhanVien (Tendangnhap,Hoten,Gioitinh,Dienthoai,Chucvu,Trangthai,Matkhau) VALUES (@Tendangnhap,@Hoten,@Gioitinh,@Dienthoai,@Chucvu,@Trangthai,@maukhau)";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
               
                com.Parameters.AddWithValue("Tendangnhap", nv.Tendangnhap);
                com.Parameters.AddWithValue("Hoten", nv.Hoten);
                com.Parameters.AddWithValue("Gioitinh", nv.Gioitinh);
                com.Parameters.AddWithValue("Dienthoai", nv.Dienthoai);
                com.Parameters.AddWithValue("Chucvu", nv.Chucvu);
                com.Parameters.AddWithValue("Trangthai", nv.Trangthai);
                com.Parameters.AddWithValue("maukhau", nv.Matkhau);
                numberRows = com.ExecuteNonQuery();
                con.Close();
            }           

            if(numberRows>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool suaNhanVien(int id, string Tendangnhap, string Hoten, string Gioitinh, string Dienthoai, string Chucvu,int Trangthai,string Matkhau)
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
            NhanVien_DTO nv = new NhanVien_DTO(id, Tendangnhap, Hoten, Gioitinh, Dienthoai, Chucvu,Trangthai,Matkhau);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {
               
                string cauTruyVan = " update  dbo.NhanVien set Tendangnhap=@tendangnhap, Hoten =@hoten, Gioitinh=@gioitinh, Dienthoai=@dienthoai, Chucvu =@chucvu,Matkhau =@matkhau WHERE id=@ma";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                com.Parameters.AddWithValue("ma", nv.id);
                com.Parameters.AddWithValue("tendangnhap", nv.Tendangnhap);
                com.Parameters.AddWithValue("hoten", nv.Hoten);
                com.Parameters.AddWithValue("dioitinh", nv.Gioitinh);
                com.Parameters.AddWithValue("dienthoai", nv.Dienthoai);
                com.Parameters.AddWithValue("Chucvu", nv.Chucvu);
                com.Parameters.AddWithValue("matkhau", nv.Matkhau);
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

       
        public bool xoaNhanvien(int id, string Tendangnhap, string Hoten, string Gioitinh, string Dienthoai, string Chucvu,int Trangthai,string Matkhau)
        {



            int numberRows = 0;
            NhanVien_DTO nv = new NhanVien_DTO(id, Tendangnhap, Hoten, Gioitinh, Dienthoai, Chucvu,Trangthai,Matkhau);
            SqlConnection con = dataProvider.TaoKetNoi();
            if (con != null)
            {

                string cauTruyVan = " UPDATE dbo.NhanVien SET Trangthai=0 where id=@ma";
                SqlCommand com = new SqlCommand(cauTruyVan, con);
                //com.Parameters.AddWithValue(@"ma", nv.id);
                //com.Parameters.AddWithValue(@"Tendangnhap", nv.Tendangnhap);
                //com.Parameters.AddWithValue(@"Hoten", nv.Hoten);
                //com.Parameters.AddWithValue(@"Gioitinh", nv.Gioitinh);
                //com.Parameters.AddWithValue(@"Dienthoai", nv.Dienthoai);
                //com.Parameters.AddWithValue(@"Chucvu", nv.Chucvu);
                //com.Parameters.AddWithValue("",nv.Matkhau)
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
