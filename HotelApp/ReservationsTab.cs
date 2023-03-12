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
    public partial class ReservationsTab : UserControl
    {
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private int activeView;
        private MainPage mp;

        public ReservationsTab()
        {
            InitializeComponent();
        }

        //receives reference to the mainpage, gets connection from said mainpage and sets buttons layout
        public void SetAtt(MainPage mp)
        {
            this.mp = mp;
            con = mp.GetCon();
            SetButtons();
        }

        //removes some buttons depending on role persmissions
        private void SetButtons()
        {
            switch (mp.GetRole())
            {
                case "Cleaning":
                    newButton.Hide();
                    removeButton.Hide();
                    label2.Hide();
                    label3.Hide();
                    label4.Hide();
                    label5.Hide();
                    textBox2.Hide();
                    textBox3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();
                    break;
                case "Desk":
                    removeButton.Hide();
                    break;
            }
        }

        //adds reservation to table with entered attributes
        private void CreateRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("insert into reservations Values(@GuestID, @RoomNumber, @CheckInDate, @Length, null, null, null, @Notes)", con);
                com.Parameters.AddWithValue("@GuestID", int.Parse(textBox2.Text));
                com.Parameters.AddWithValue("@RoomNumber", int.Parse(textBox3.Text));
                com.Parameters.AddWithValue("@CheckInDate", textBox4.Text);
                com.Parameters.AddWithValue("@Length", int.Parse(textBox5.Text));
                com.Parameters.AddWithValue("@Notes", textBox6.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //updates room selected by room number with entered attributes
        private void UpdateRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET RoomNumber=@RoomNumber, CheckInDate=@CheckInDate, Length=@Length, notes=@notes WHERE ReservationID=@ReservationID", con);
                com.Parameters.AddWithValue("@ReservationID", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@RoomNumber", int.Parse(textBox3.Text));
                com.Parameters.AddWithValue("@CheckInDate", textBox4.Text);
                com.Parameters.AddWithValue("@Length", int.Parse(textBox5.Text));
                com.Parameters.AddWithValue("@Notes", textBox6.Text);
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //removes room selected by room number
        private void DeleteRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("delete from Reservations where ReservationID=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
                com.ExecuteNonQuery();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //updates in-app table view
        private void UpdateView()
        {
            con.Open();
            com = new SqlCommand(("select * from Reservations order by CheckInDate"), con);
            da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        //clears textboxes
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        //removes precedent selection state
        private void ResetView()
        {
            panel2.Hide();
            panel3.Hide();
            viewButton.BackColor = Color.Gainsboro;
            updateButton.BackColor = Color.Gainsboro;
            newButton.BackColor = Color.Gainsboro;
            removeButton.BackColor = Color.Gainsboro;
        }

        //opens view table when View button is clicked
        private void viewButton_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 0;
            viewButton.BackColor = Color.YellowGreen;
            UpdateView();
        }

        //opens update entry form when Update button is clicked
        private void updateButton_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 2;
            updateButton.BackColor = Color.YellowGreen;
            panel3.Show();
            UpdateView();
        }

        //opens new entry form when New button is clicked
        private void newButton_Click(object sender, EventArgs e)
        {
            ResetView();
            ClearFields();
            activeView = 1;
            newButton.BackColor = Color.YellowGreen;
            panel2.Show();
            UpdateView();
        }

        //opens remove entry form when Update button is clicked
        private void removeButton_Click(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            removeButton.BackColor = Color.YellowGreen;
            panel3.Show();
            UpdateView();
        }

        //confirms selected action with infos entered when Confirm button is clicked
        private void confirmButton_Click(object sender, EventArgs e)
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

        //gets infos related to entered room number when get button is clicked
        private void getButton_Click(object sender, EventArgs e)
        {
            panel2.Show();
            con.Open();
            com = new SqlCommand("Select * from Reservations where ReservationID=@ReservationID", con);
            com.Parameters.AddWithValue("@ReservationID", textBox1.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = (dr.GetValue(0).ToString());
                textBox2.Text = (dr.GetValue(1).ToString());
                textBox3.Text = (dr.GetValue(2).ToString());
                textBox4.Text = (dr.GetValue(3).ToString());
                textBox5.Text = (dr.GetValue(4).ToString());
                textBox6.Text = (dr.GetValue(8).ToString());
            }
            con.Close();
        }
    }
}
