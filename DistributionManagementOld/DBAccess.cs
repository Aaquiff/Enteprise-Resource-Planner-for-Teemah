using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQLDatabaseAccess;

namespace DistributionManagement
{
    public static class DBAccess
    {
        private static MySqlConnection conn;


        private static void Initialize()
        {
            string connectionString;
            conn = Connection.getConnection();
        }

        public static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                Initialize();
            }
            return conn;
        }
        public static bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to the server");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid password");
                        break;

                    default:
                        break;
                }
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
   /*     public DataTable getJobCats()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CatID", typeof(int));
            dt.Columns.Add("CatName", typeof(String));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand Cmd = conn.CreateCommand();
            Cmd.Connection = conn;
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "select * from dbo.JobCategory_2016";
            SqlDataReader dr = Cmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["jobCatId"], dr["jobCatName"]);
            }
            conn.Close();
            return dt;
        }

        public DataTable getSubCats(int jobCatID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SubCatID", typeof(int));
            dt.Columns.Add("SubCatName", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

         /*  SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText =  "insert into table values('"+VehiType+"','"+VehiId"','"+VehiNo"','"+VehiSize"')";
            newCmd.CommandText = "INSERT into table1 (VehiType, VehiId, VehiNo, VehiSiz) VALUES (@VehiType, @VehiId, @VehiNo, @VehiSiz)";
            newCmd.Parameters.AddWithValue("@VehiType", VehiType );
            newCmd.Parameters.AddWithValue("@VehiId", VehiId);
            newCmd.Parameters.AddWithValue("@VehiNo", VehiNo);
            newCmd.Parameters.AddWithValue("@VehiSiz", VehiSiz);
            newCmd.ExecuteNonQuery();
           conn.Close();

           // SqlDataReader dr = newCmd.ExecuteReader();
         //   while (dr.Read())
           {
                dt.Rows.Add(dr["jobSubCatId"], dr["subCategoryName"]);
            }
            conn.Close();
            return dt;
        }
    }*/
        
