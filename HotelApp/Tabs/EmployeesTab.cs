using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class EmployeesTab : UserControl
    {
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private int activeView;
        private MainPage mp;

        public EmployeesTab()
        {
            InitializeComponent();
        }

        //receives reference to the mainpage, gets connection from said mainpage and sets buttons layout
        public void SetAtt(MainPage mp)
        {
            this.mp = mp;
            con = mp.GetCon();
        }

        //adds employee to table with entered attributes
        private void CreateEmployee()
        {
            con.Open();
            try
            {
                com = new SqlCommand("INSERT INTO Employees VALUES(@password,@firstname,@lastname,@role)", con);
                com.Parameters.AddWithValue("@firstname", firstNameBox.Text);
                com.Parameters.AddWithValue("@lastname", lastNameBox.Text);
                com.Parameters.AddWithValue("@role", roleBox.Text);
                com.Parameters.AddWithValue("@password", passwordBox.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //updates in-app table view with relevant data
        private void UpdateView()
        {
            con.Open();
            com = new SqlCommand(("SELECT * FROM Employees ORDER BY EmployeeID"), con);
            da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        //updates employee selected by employee ID
        private void UpdateEmployee()
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Employees SET Password=@password, FirstName=@firstname, LastName=@lastname, Role=@role WHERE EmployeeID=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(employeeIDBox.Text));
                com.Parameters.AddWithValue("@firstname", firstNameBox.Text);
                com.Parameters.AddWithValue("@lastname", lastNameBox.Text);
                com.Parameters.AddWithValue("@role", roleBox.Text);
                com.Parameters.AddWithValue("@password", passwordBox.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //removes employee selected by employee ID
        private void DeleteEmployee()
        {
            con.Open();
            try
            {
                com = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@id", con);
                com.Parameters.AddWithValue("@id", employeeIDBox.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //clears textboxes
        private void ClearFields()
        {
            employeeIDBox.Clear();
            firstNameBox.Clear();
            lastNameBox.Clear();
            roleBox.Clear();
            passwordBox.Clear();
        }


        //removes precedent selection state
        private void ResetView()
        {
            infosPanel.Hide();
            employeeIDPanel.Hide();
            viewButton.BackColor = Color.Gainsboro;
            newButton.BackColor = Color.Gainsboro;
            updateButton.BackColor = Color.Gainsboro;
            removeButton.BackColor = Color.Gainsboro;
        }

        //opens view table when View button is clicked
        private void ViewButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 0;
            viewButton.BackColor = Color.Goldenrod;
            UpdateView();
        }

        //opens update entry form when Update button is clicked
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 2;
            updateButton.BackColor = Color.Goldenrod;
            employeeIDPanel.Show();
            UpdateView();
        }

        //opens new entry form when New button is clicked
        private void NewButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 1;
            newButton.BackColor = Color.Goldenrod;
            infosPanel.Show();
            UpdateView();
        }

        //opens remove entry form when Remove button is clicked
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            removeButton.BackColor = Color.Goldenrod;
            employeeIDPanel.Show();
            UpdateView();
        }

        //confirms selected action with infos entered when Confirm button is clicked
        private void ConfirmButtonClick(object sender, EventArgs e)
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
                    infosPanel.Hide();
                    break;
            }
            UpdateView();
        }

        //gets infos related to entered room number when get button is clicked
        private void GetButtonClick(object sender, EventArgs e)
        {
            infosPanel.Show();
            con.Open();
            com = new SqlCommand("SELECT * FROM Employees WHERE EmployeeID=@id", con);
            com.Parameters.AddWithValue("@id", employeeIDBox.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                employeeIDBox.Text = dr.GetValue(0).ToString();
                passwordBox.Text = dr.GetValue(1).ToString();
                firstNameBox.Text = dr.GetValue(2).ToString();
                lastNameBox.Text = dr.GetValue(3).ToString();
                roleBox.Text = dr.GetValue(4).ToString();
            }
            con.Close();
        }
    }
}
