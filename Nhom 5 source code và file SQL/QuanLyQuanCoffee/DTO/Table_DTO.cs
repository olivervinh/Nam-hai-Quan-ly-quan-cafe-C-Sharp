//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//namespace DTO
//{
//    public class Table_DTO
//    {
      
//            public Table_DTO(int id, string name, string status)
//            {
//                this.ID = id;
//                this.Name = name;
//                this.Status = status;
//            }
//           public Table_DTO(DataRow row)
//          {
//            this.ID = (int)row["id"];
//            this.Name = row["Ten"].ToString();
//            this.Status = row["status"].ToString();
//          }
//          private string status;
//            public string Status
//            {
//                get { return status; }
//                set { status = value; }
//            }
//            private string name;
//            public string Name
//            {
//                get { return name; }
//                set { name = value; }
//            }



//            private int iD;
//            public int ID
//            {
//                get { return iD; }
//                set { iD = value; }
//            }

//        }
//    }
