using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelApp
{
    public partial class LoginPage : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I6V3SE2;Initial Catalog=HotelApp;Integrated Security=True");
        private SqlCommand com;
        private SqlDataReader dr;
        private string role;
        private int invCredCount = 0;

        public LoginPage()
        {
            InitializeComponent();
        }
 
        //getter for connection
        public SqlConnection GetCon()
        {
            return con;
        }

        //checks the credentials against the employee list to confirm access and opens the main page
        private void SubmitButtonClick(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                int id = int.Parse(employeeIDBox.Text);
                com = new SqlCommand("SELECT Role FROM Employees WHERE EmployeeID=@id AND Password=@password", con);
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@password", passwordBox.Text);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    role = dr.GetValue(0).ToString().TrimEnd();
                    con.Close();
                    MainPage mp = new MainPage(this, role, id);
                    mp.Show();
                    employeeIDBox.Clear();
                    passwordBox.Clear();
                    this.Hide();
                } else
                {
                    InvalidCreds();
                }
            } catch (Exception)
            {
                InvalidCreds();
            }
        }

        //shows the invalid credentials prompt with the updated count to show the form as been submitted
        private void InvalidCreds()
        {
            invCredCount++;
            invCredLabel.Text = "Invalid Credentials x" + invCredCount;
            invCredLabel.Show();
            con.Close();
        }
    }
}
