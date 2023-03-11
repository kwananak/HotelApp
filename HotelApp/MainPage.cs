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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelApp
{
    public partial class MainPage : Form
    {
        //receives the connection, the access level and the employeeID from the login page
        public MainPage(SqlConnection con, String role, int id)
        {
            this.con = con;
            this.role = role;
            this.employeeID = id;
            InitializeComponent();
            setEmpName();
        }

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader da;
        private String role;
        private int employeeID;
        private String empName;

        //retrieves the logged employee's name for personnal greetings
        private void setEmpName()
        {
            con.Open();
            com = new SqlCommand("Select FirstName from Employees where EmployeeID=@id", con);
            com.Parameters.AddWithValue("@id", employeeID);
            da = com.ExecuteReader();
            if (da.Read())
            {
                empName = (da.GetValue(0).ToString());
                label1.Text = "Hello " + empName + "!";
            }
            con.Close();
        }
    }
}
