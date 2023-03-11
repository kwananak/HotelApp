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

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6V3SE2;Initial Catalog=HotelApp;Integrated Security=True");
        private SqlCommand com;
        private SqlDataReader da;
        private String role = null;
        private int invCredCount = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {  
                com = new SqlCommand("Select Role from Employees where EmployeeID=@id and Password=@password", con);
                com.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@password", textBox2.Text);
                da = com.ExecuteReader();
                if (da.Read())
                {
                    role = (da.GetValue(0).ToString());
                    MainPage mp = new MainPage(con, role);
                    mp.Show();
                    this.Hide();
                } else
                {
                    invalidCreds();
                }
            } catch (Exception ex)
            {
                invalidCreds();
            }
            con.Close();
        }

        private void invalidCreds()
        {
            invCredCount++;
            label4.Text = "Invalid Credentials x" + invCredCount;
            label4.Show();
        }
    }
}
