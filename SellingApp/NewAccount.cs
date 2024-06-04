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
using System.Security.Cryptography;

namespace SellingApp
{
    public partial class NewAccount : Form
    {
        static string conString = "Data Source=PIERRE-KASANANI\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True";
        SqlConnection con = new SqlConnection(conString);
        public NewAccount()
        {
            InitializeComponent();
        }
        private void NewAccount_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            string sqlQuery = "SELECT * FROM Userlist";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            diplayUsers.DataSource = ds.Tables["Userlist"];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                //open connection
                con.Open();

                //format sqlquery
                string sqlquery = "INSERT INTO Userlist VALUES(@v_username,@v_password)";

                //SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Userlist VALUES(@v_username,@v_password)",con);
                //SqlDataAdapter sda = new SqlDataAdapter();
                //sda.InsertCommand= new SqlCommand(sqlquery,con);
                //command
                SqlCommand cmd = new SqlCommand(sqlquery, con);
               // sda.InsertCommand.ExecuteNonQuery();
                //passing parameters
                cmd.Parameters.AddWithValue("@v_username", userNametxt.Text);
                cmd.Parameters.AddWithValue("@v_password", passwordTxt.Text);
                //sda.InsertCommand.Parameters.AddWithValue("@v_username", userNametxt.Text);
                //sda.InsertCommand.Parameters.AddWithValue("@v_password", passwordTxt.Text);
                // execute query & count rows affected
                
                int rowsAffectted = cmd.ExecuteNonQuery();

                if (rowsAffectted >= 1 && confpswdTxt.Text== passwordTxt.Text)
                {
                    MessageBox.Show("Registerd");
                    
                    DisplayData();
                    
                }
                else
                {
                    MessageBox.Show("Registration failed!");
                }
                //close connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private string encryptPwd(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }


        }

        

        private void diplayUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
