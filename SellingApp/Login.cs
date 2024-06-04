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

namespace SellingApp
{
    public partial class Login : Form
    {
        static string conString = "Data Source=PIERRE-KASANANI\\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True";
        // connection
        SqlConnection con = new SqlConnection(conString);
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT count(*) FROM USERLIST WHERE username = @v_username and userpswd = @v_password";

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                // command
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                // paramaters passing
                cmd.Parameters.AddWithValue("@v_username", txtusername.Text);

                cmd.Parameters.AddWithValue("@v_password", txtpswd.Text);
                // executing query
                int result = Convert.ToInt32(cmd.ExecuteScalar());

                if (result == 1)
                {
                    //MessageBox.Show("Logged in");
                    Products form = new Products();
                    form.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            NewAccount form = new NewAccount();
            form.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
