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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelApp
{
    public partial class RoomsTab : UserControl
    {
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private int activeView;
        private MainPage mp;

        public RoomsTab()
        {
            InitializeComponent();
        }

        public void SetAtt(MainPage mp)
        {
            this.mp = mp;
            con = mp.GetCon();
        }

        private void CreateRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("insert into Rooms Values(@RoomNumber,null , null, @Notes)", con);
                com.Parameters.AddWithValue("@RoomNumber", textBox1.Text);
                com.Parameters.AddWithValue("@Notes", textBox3.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void UpdateRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("update Rooms set notes=@notes where RoomNumber=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@notes", textBox3.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void DeleteRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("delete from Rooms where RoomID=@id", con);
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
            com = new SqlCommand(("select * from Rooms order by RoomNumber"), con);
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

        private void button6_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 0;
            button6.BackColor = Color.YellowGreen;
            UpdateView();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ResetView();
            activeView = 1;
            button7.BackColor = Color.YellowGreen;
            button11.Hide();
            label3.Hide();
            textBox2.Hide();
            panel3.Show();
            panel2.Show();
            UpdateView();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ResetView();
            activeView = 2;
            button11.Show();
            label3.Show();
            textBox2.Show();
            button8.BackColor = Color.YellowGreen;
            panel3.Show();
            UpdateView();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            button11.Show();
            label3.Show();
            textBox2.Show();
            button9.BackColor = Color.YellowGreen;
            panel3.Show();
            UpdateView();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            switch (activeView)
            {
                case 1:
                    CreateRoom();
                    break;
                case 2:
                    UpdateRoom();
                    break;
                case 3:
                    DeleteRoom();
                    panel2.Hide();
                    break;
            }
            UpdateView();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            panel2.Show();
            con.Open();
            com = new SqlCommand("Select * from Rooms where RoomNumber=@id", con);
            com.Parameters.AddWithValue("@id", textBox1.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = (dr.GetValue(0).ToString());
                textBox2.Text = (dr.GetValue(1).ToString());
                textBox3.Text = (dr.GetValue(3).ToString());
            }
            con.Close();
        }
    }
}
