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

        public void SetAtt(MainPage mp)
        {
            this.mp = mp;
            con = mp.GetCon();
        }

        private void View_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 0;
            button6.BackColor = Color.YellowGreen;
            UpdateView();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void UpdateView()
        {
            con.Open();
            com = new SqlCommand(("select * from Employees order by EmployeeID"), con);
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

        private void button9_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            button9.BackColor = Color.YellowGreen;
            panel3.Show();
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
    }
}
