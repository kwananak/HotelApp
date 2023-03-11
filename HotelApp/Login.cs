using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HotelApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //initializes the connection to the SQL server. The connection is passed down to the main page when it opens 
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6V3SE2;Initial Catalog=HotelApp;Integrated Security=True");
        private SqlCommand com;
        private SqlDataReader da;
        private String role = null;
        private int invCredCount = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //checks the credentials against the employee list to confirm access and opens the main page in the appropriate format
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                int id = int.Parse(textBox1.Text);
                com = new SqlCommand("Select Role from Employees where EmployeeID=@id and Password=@password", con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@password", textBox2.Text);
                da = com.ExecuteReader();
                if (da.Read())
                {
                    role = (da.GetValue(0).ToString());
                    con.Close();
                    MainPage mp = new MainPage(con, role, id);
                    mp.Show();
                    this.Hide();
                } else
                {
                    invalidCreds();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                invalidCreds();
            }
            

        }

        //shows the invalid credentials prompt with the updated count to show the form as been submitted
        private void invalidCreds()
        {
            invCredCount++;
            label4.Text = "Invalid Credentials x" + invCredCount;
            label4.Show();
            con.Close();
        }
    }
}
