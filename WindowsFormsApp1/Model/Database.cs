using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.Model
{
    class Database
    {
        


        public static SqlConnection connectDB()
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
        public static Decimal total = 0;

        internal static object populateOrders(string cust_id)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Order ID", typeof(int));
            table.Columns.Add("Product Type", typeof(string));
            table.Columns.Add("Price", typeof(Decimal));

            string query = "SELECT order_id,product_type,price FROM ORDERS WHERE cust_id = '"+cust_id +"'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  table.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2));
                    total += reader.GetDecimal(2);
                }

            }
            //retervie data from database
            return table;
        }

        internal static string getDescription(string order_id)
        {
            string query = "SELECT description FROM ORDERS WHERE order_id= '" + order_id + "'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string des = reader.GetString(0);
                    return des;
                }

            }
            //retervie data from database
            return "N/A";
        }

        internal static string getCustomerName(string customerID)
        {
            string query = "SELECT f_name,l_name FROM CUSTOMERS WHERE cust_id= '" + customerID + "'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string customerName = reader.GetString(0) +" " + reader.GetString(1);
                    return customerName;
                }

            }
            //retervie data from database
            return "N/A";
        }

        internal static string getCustomerID(string order_id)
        {
            string query = "SELECT cust_id FROM ORDERS WHERE order_id= '" + order_id + "'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string cust_id = reader.GetInt32(0).ToString();
                    return cust_id;
                }

            }
            //retervie data from database
            return "N/A";
        }

        public static DataTable populateJobRequest(String username)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Order ID", typeof(int));
            table.Columns.Add("Product Type", typeof(string));
            table.Columns.Add("Description", typeof(string));

            string query = "SELECT ORDERS.order_id,ORDERS.product_type,ORDERS.description FROM ASSIGNED_ORDERS, ORDERS WHERE designer = '" + username + "' AND ASSIGNED_ORDERS.order_id = ORDERS.order_id;";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                   table.Rows.Add(reader.GetInt32(0),reader.GetString(1), reader.GetString(2));
                }

            }
            //retervie data from database
            return table;

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

        public static string getProductType(string orderID)
        {
            string query = "SELECT product_type FROM ORDERS WHERE order_id= '" + orderID + "'";
            SqlConnection conn = connectDB();
            if (conn != null)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string product_type = reader.GetString(0);
                    return product_type;
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

        private static DataTable populateJobRequest()
        {
            System.Data.DataTable table = new DataTable();
            table.Columns.Add("Order ID", typeof(string));
            table.Columns.Add("Description", typeof(string));




            table.Rows.Add("ODR-001", "This is fucking descripting");
            table.Rows.Add("ODR-002", "This is another fucking descripting");
            table.Rows.Add("ODR-003", "This is one more fucking descripting");

            return table;

        }

       



    }
}
