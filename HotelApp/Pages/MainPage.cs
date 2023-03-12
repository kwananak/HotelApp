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
using System.Runtime.InteropServices;

namespace HotelApp
{
    public partial class MainPage : Form
    {
        //receives the connection, the access level and the employeeID from the login page
        public MainPage(LoginPage log,String role, int id)
        {
            this.log = log;
            con = log.GetCon();
            this.role = role;
            this.employeeID = id;
            InitializeComponent();
            SetEmpName();
            SetMenu();
            PassSelfToTabs();
        }

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private String role;
        private int employeeID;
        private LoginPage log;

        //sends this object to tabs to access get methods
        private void PassSelfToTabs()
        {            
            guestsTab.SetAtt(this);
            employeesTab.SetAtt(this);
            roomsTab.SetAtt(this);
            reservationsTab.SetAtt(this);
            tasksTab.SetAtt(this);
        }

        //returns databse connection for tabs sql calls
        public SqlConnection GetCon()
        {
            return con;
        }

        //returns connected users role for permission checks
        public String GetRole()
        {
            return role;
        }

        public int GetEmployeeID()
        {
            return employeeID;
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

        //opens the task management panel
        private void button1_Click(object sender, EventArgs e)
        {
            HideTabs();
            tasksTab.Show();
        }

        //opens the guest management panel
        private void button2_Click(object sender, EventArgs e)
        {
            HideTabs();
            guestsTab.Show();
        }

        //opens the room management panel
        private void button3_Click(object sender, EventArgs e)
        {
            HideTabs();
            roomsTab.Show();
        }

        //opens the reservation management panel
        private void button4_Click(object sender, EventArgs e)
        {
            HideTabs();
            reservationsTab.Show();
        }

        //opens the employee management panel
        private void button5_Click(object sender, EventArgs e)
        {
            HideTabs();
            employeesTab.Show();
        }

        //closes mainpage and returns to login
        private void button6_Click(object sender, EventArgs e)
        {
            log.Show();
            this.Close();
        }

        //hides all tabs
        private void HideTabs()
        {
            guestsTab.Hide();
            employeesTab.Hide();
            roomsTab.Hide();
            reservationsTab.Hide();
        }
    }
}
