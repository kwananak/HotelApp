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
using System.Configuration;

namespace HotelApp
{
    public partial class MainPage : Form
    {
        //receives the connection, the access level and the employeeID from the login page
        public MainPage(Login log,String role, int id)
        {
            this.log = log;
            con = log.GetCon();
            this.role = role;
            this.employeeID = id;
            InitializeComponent();
            SetEmpName();
            SetMenu();
            PassValuesToTabs();
        }

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private String role;
        private int employeeID;
        private Login log;

        private void PassValuesToTabs()
        {            
            guestsTab1.SetAtt(this);
            employeesTab1.SetAtt(this);
            roomsTab1.SetAtt(this);
        }

        //retrieves the logged employee's name for personnal greeting
        private void SetEmpName()
        {
            con.Open();
            com = new SqlCommand("Select FirstName from Employees where EmployeeID=@id", con);
            com.Parameters.AddWithValue("@id", employeeID);
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                String empName = (dr.GetValue(0).ToString()).TrimEnd();
                label1.Text = "Hello " + empName + "!";
            }
            con.Close();
        }

        public SqlConnection GetCon()
        {
            return con;
        }
        public String GetRole()
        {
            return role;
        }

        //shows allowed buttons for user's role
        private void SetMenu()
        {
            switch (role)
            {
                case "admin":
                    button4.Show();
                    button5.Show();
                    break;
                case "Boss":
                    button4.Show();
                    button5.Show();
                    break;
                case "Desk":
                    button4.Show();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideTabs();
            guestsTab1.Show();
        }

        //opens the employee management panel
        private void button5_Click(object sender, EventArgs e)
        {
            HideTabs();
            employeesTab1.Show();
        }


        private void HideTabs()
        {
            guestsTab1.Hide();
            employeesTab1.Hide();
            roomsTab1.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            log.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HideTabs();
            roomsTab1.Show();
        }
    }
}
