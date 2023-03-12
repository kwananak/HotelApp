using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelApp
{
    public partial class MainPage : Form
    {
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private String role;
        private int employeeID;
        private LoginPage log;

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
        public string GetRole()
        {
            return role;
        }

        //returns employee ID for the connected user
        public int GetEmployeeID()
        {
            return employeeID;
        } 

        //retrieves logged employee's name for personnal greeting
        private void SetEmpName()
        {
            con.Open();
            com = new SqlCommand("Select FirstName from Employees where EmployeeID=@id", con);
            com.Parameters.AddWithValue("@id", employeeID);
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                string empName = dr.GetValue(0).ToString();
                greetingsLabel.Text = "Hello " + empName + "!";
            }
            con.Close();
        }

        //shows allowed buttons for user's role
        private void SetMenu()
        {
            switch (role)
            {
                case "Admin":
                    reservationsButton.Show();
                    employeesButton.Show();
                    break;
                case "Boss":
                    reservationsButton.Show();
                    employeesButton.Show();
                    break;
                case "Desk":
                    reservationsButton.Show();
                    break;
            }
        }

        //opens task management panel
        private void TasksButtonClick(object sender, EventArgs e)
        {
            HideTabs();
            tasksTab.Show();
        }

        //opens guest management panel
        private void GuestsButtonClick(object sender, EventArgs e)
        {
            HideTabs();
            guestsTab.Show();
        }

        //opens room management panel
        private void RoomsButtonClick(object sender, EventArgs e)
        {
            HideTabs();
            roomsTab.Show();
        }

        //opens reservation management panel
        private void ReservationButtonClick(object sender, EventArgs e)
        {
            HideTabs();
            reservationsTab.Show();
        }

        //opens employee management panel
        private void EmployeeButtonClick(object sender, EventArgs e)
        {
            HideTabs();
            employeesTab.Show();
        }

        //closes mainpage and returns to login
        private void LogoutButtonClick(object sender, EventArgs e)
        {
            log.Show();
            this.Close();
        }

        //hides all tabs
        private void HideTabs()
        {
            tasksTab.Hide();
            guestsTab.Hide();
            roomsTab.Hide();
            reservationsTab.Hide();
            employeesTab.Hide();
        }
    }
}
