using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class frmChatInterface : Form
    {
        SqlConnection conn; //new SqlConnection("Data Source=KUMA;Initial Catalog=chat;Integrated Security=True");
        SqlDataReader reader = null;
     String chat_id;
        SqlCommand command;
        String user =null;

        public frmChatInterface(String user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmChatInterface_Load(object sender, EventArgs e)
        {
                conn = Database.connectDB();
            // Need to change the query
            // Get all the users except PRIMARY USER (Logged user)
            command = new SqlCommand("SELECT DISTINCT username FROM USERS WHERE username != '" + user +"'", conn);

            reader = command.ExecuteReader();

            while(reader.Read())
            {
                lstChatList.Items.Add(reader.GetString(0));
            }

            conn.Close();

        }

        private void lstChatList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtChatBox.Clear();

            String rspnt = lstChatList.SelectedItem.ToString();
            
            try
            {
                conn.Open();
                command = new SqlCommand("SELECT DISTINCT chat_id FROM messages WHERE chat_id LIKE '%" + user + ":" + rspnt + "%' OR chat_id LIKE '%" + rspnt + ":" + user + "%'", conn);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    chat_id = reader.GetString(0);
                }
                else
                {
                    chat_id = null;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }

            if (chat_id != null)
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand("SELECT from_user, message FROM messages WHERE chat_id = '" + chat_id + "'", conn);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        txtChatBox.AppendText(reader.GetString(0) + ": " + reader.GetString(1) + "\r\n");
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String msg = txtMsg.Text;
            DateTime timestamp = DateTime.Now;

            if(chat_id != null)
            {
                try
                {
                    conn.Open();
                    command = new SqlCommand("INSERT INTO Messages VALUES ('" + chat_id + "', '" + timestamp.ToString() + "', '" + user + "', '" + msg + "')", conn);
                    reader = command.ExecuteReader();
                    txtMsg.Clear();
                } catch (Exception ex)
                {

                    MessageBox.Show(ex.StackTrace);
                } finally
                {
                    conn.Close();
                }
            } else
            {
                String rspnt = lstChatList.SelectedItem.ToString();

                chat_id = user.ToLower() + ":" + rspnt.ToLower();

                try
                {
                    conn.Open();
                    command = new SqlCommand("INSERT INTO Messages VALUES ('" + chat_id + "', '" + timestamp.ToString() + "', '" + user + "', '" + msg + "')", conn);
                    reader = command.ExecuteReader();
                    txtMsg.Clear();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } finally
                {
                    conn.Close();
                }
            }

            txtChatBox.Clear();

            try
            {
                conn.Open();
                command = new SqlCommand("SELECT from_user, message FROM messages WHERE chat_id = '" + chat_id + "'", conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtChatBox.AppendText(reader.GetString(0) + ": " + reader.GetString(1) + "\r\n");
                }
            } catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }

            conn.Close();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
