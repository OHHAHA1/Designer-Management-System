using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Model
{
    class Database
    {
        


        private static SqlConnection connectDB()
        {
             string connString = " Data Source = (local); Initial Catalog = catographics; Integrated Security = True";
             SqlConnection conn = new SqlConnection(connString);
             conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return conn;
            }
            else
            {
                Console.WriteLine("Connection state is not open");
                return null;
            }
                    
    }


        public static string getName(string username)
        {
            string query = "SELECT f_name,l_name FROM USERS WHERE username= '"+username+"'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader.GetString(0)+" "+reader.GetString(1);
                    return name;
                }
                
            }
            //retervie data from database
            return "N/A";
        }
        
        public  static bool checkLogin(string username, string password)
        {
            //retervie data from database
            
            string query = "SELECT password FROM USERS WHERE username= '" + username + "'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string db_pass = reader.GetString(0);
                    //Check password
                    if (password == db_pass)
                    {
                        Console.Write("Login");
                        return true;
                    }
                }

            }
            return false;
        }

       public static string getLoginType(string username)
        {
            //get type of work according to username
            string query = "SELECT work_type FROM USERS WHERE username= '" + username + "'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string type = reader.GetString(0);
                    return type;
                }

            }
            //retervie data from database
            return "N/A";
           
        }



    }
}
