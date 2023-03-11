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
        public MainPage(SqlConnection con, String role, int id)
        {
            this.con = con;
            this.role = role;
            this.employeeID = id;
            InitializeComponent();
            SetEmpName();
            SetMenu();
        }

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private String role;
        private int employeeID;
        private Panel activePanel;
        private SqlDataAdapter da;
        private int activeView;

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

        //opens the employee management panel
        private void button5_Click(object sender, EventArgs e)
        {
            activePanel = panel1;
            activePanel.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 0;
            button6.BackColor = Color.YellowGreen;
            UpdateView();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 1;
            button7.BackColor = Color.YellowGreen;
            panel2.Show();
            UpdateView();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 2;
            button8.BackColor = Color.YellowGreen;
            panel3.Show();
            UpdateView();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            button9.BackColor = Color.YellowGreen;
            panel3.Show();
            UpdateView();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (activeView)
            {
                case 1:
                    CreateEmployee();
                    break;
                case 2:
                    UpdateEmployee();
                    break;
                case 3:
                    DeleteEmployee();
                    panel2.Hide();
                    break;
            }
            UpdateView();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Show();
            con.Open();
            com = new SqlCommand("Select * from Employees where EmployeeID=@id", con);
            com.Parameters.AddWithValue("@id", textBox1.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = (dr.GetValue(0).ToString());
                textBox5.Text = (dr.GetValue(1).ToString());
                textBox2.Text = (dr.GetValue(2).ToString());
                textBox3.Text = (dr.GetValue(3).ToString());
                textBox4.Text = (dr.GetValue(4).ToString());
            }
            con.Close();
        }

        private void CreateEmployee()
        {
            con.Open();
            try
            {
                com = new SqlCommand("insert into Employees Values(@password,@firstname,@lastname,@role)", con);
                com.Parameters.AddWithValue("@firstname", textBox2.Text);
                com.Parameters.AddWithValue("@lastname", textBox3.Text);
                com.Parameters.AddWithValue("@role", textBox4.Text);
                com.Parameters.AddWithValue("@password", textBox5.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void UpdateEmployee()
        {
            con.Open();
            try
            {
                com = new SqlCommand("update Employees set password=@password, firstname=@firstname, lastname=@lastname, role=@role where EmployeeID=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@firstname", textBox2.Text);
                com.Parameters.AddWithValue("@lastname", textBox3.Text);
                com.Parameters.AddWithValue("@role", textBox4.Text);
                com.Parameters.AddWithValue("@password", textBox5.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void DeleteEmployee()
        {
            con.Open();
            try
            {
                com = new SqlCommand("delete from Employees where EmployeeID=@id", con);
                com.Parameters.AddWithValue("@id", textBox1.Text);
                com.ExecuteNonQuery();
                ClearFields();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void UpdateView()
        {
            con.Open();
            com = new SqlCommand(("select * from Employees"), con);
            da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        
        private void ResetView()
        {
            panel2.Hide();
            panel3.Hide();
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
        }
    }
}
