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
    public partial class GuestsTab : UserControl
    {

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private int activeView;
        private MainPage mp;

        public GuestsTab()
        {
            InitializeComponent();
        }

        public void SetAtt(MainPage mp)
        {
            this.mp = mp;
            con = mp.GetCon();
            SetButtons();
        }

        private void SetButtons()
        {
            switch (mp.GetRole())
            {
                case "Cleaning":
                    button7.Hide();
                    button9.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    textBox2.Hide();
                    textBox3.Hide();
                    textBox4.Hide();
                    break;
                case "Desk":
                    button9.Hide();
                    break;
            }
        } 

        private void button6_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 0;
            button6.BackColor = Color.YellowGreen;
            UpdateView();
        }

        private void UpdateView()
        {
            con.Open();
            com = new SqlCommand(("select * from Guests order by GuestID"), con);
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

        private void button7_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 1;
            button7.BackColor = Color.YellowGreen;
            panel2.Show();
            UpdateView();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (activeView)
            {
                case 1:
                    CreateGuest();
                    break;
                case 2:
                    UpdateGuest();
                    break;
                case 3:
                    DeleteGuest();
                    panel2.Hide();
                    break;
            }
            UpdateView();
        }


        private void CreateGuest()
        {
            con.Open();
            try
            {
                com = new SqlCommand("insert into Guests Values(@firstname,@lastname,@countrycode,@notes)", con);
                com.Parameters.AddWithValue("@firstname", textBox2.Text);
                com.Parameters.AddWithValue("@lastname", textBox3.Text);
                com.Parameters.AddWithValue("@countrycode", textBox4.Text);
                com.Parameters.AddWithValue("@notes", textBox5.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void UpdateGuest()
        {
            con.Open();
            try
            {
                com = new SqlCommand("update Guests set firstname=@firstname, lastname=@lastname, countrycode=@countrycode, notes=@notes where GuestID=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@firstname", textBox2.Text);
                com.Parameters.AddWithValue("@lastname", textBox3.Text);
                com.Parameters.AddWithValue("@countrycode", textBox4.Text);
                com.Parameters.AddWithValue("@notes", textBox5.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void DeleteGuest()
        {
            con.Open();
            try
            {
                com = new SqlCommand("delete from Guests where GuestID=@id", con);
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

        private void button11_Click(object sender, EventArgs e)
        {
            panel2.Show();
            con.Open();
            com = new SqlCommand("Select * from guests where GuestID=@id", con);
            com.Parameters.AddWithValue("@id", textBox1.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = (dr.GetValue(0).ToString());
                textBox2.Text = (dr.GetValue(1).ToString());
                textBox3.Text = (dr.GetValue(2).ToString());
                textBox4.Text = (dr.GetValue(3).ToString());
                textBox5.Text = (dr.GetValue(4).ToString());
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
