using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Protocols.WSTrust;
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
                    button7.Hide();
                    button9.Hide();
                    break;
                case "Desk":
                    button7.Hide();
                    button9.Hide();
                    break;
            }
        }

        //adds room to table with entered attributes
        private void CreateRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("insert into Rooms Values(@RoomNumber,null , null, @Notes)", con);
                com.Parameters.AddWithValue("@RoomNumber", int.Parse(textBox1.Text));
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

        //updates room selected by room number
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

        //removes room selected by room number
        private void DeleteRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("delete from Rooms where RoomNumber=@id", con);
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
            com = new SqlCommand(("SELECT RoomNumber AS 'Room Number', CONCAT(Guests.FirstName, Guests.LastName) AS 'Guest Name', CONCAT(Employees.FirstName, Employees.LastName )AS 'Cleaned By', Rooms.Notes FROM Rooms LEFT JOIN Guests ON Rooms.GuestID=Guests.GuestID LEFT JOIN Employees ON Rooms.CleanedBy=Employees.EmployeeID ORDER BY RoomNumber"), con);
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
            button6.BackColor = Color.Gainsboro;
            button7.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
        }

        //opens view table when View button is clicked
        private void ViewClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 0;
            button6.BackColor = Color.YellowGreen;
            UpdateView();
        }

        //opens new entry form when New button is clicked
        private void NewClick(object sender, EventArgs e)
        {
            ResetView();
            ClearFields();
            activeView = 1;
            button7.BackColor = Color.YellowGreen;
            button11.Hide();
            label3.Hide();
            textBox2.Hide();
            panel3.Show();
            panel2.Show();
            UpdateView();
        }

        //opens update entry form when Update button is clicked
        private void UpdateClick(object sender, EventArgs e)
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

        //opens remove entry form when Update button is clicked
        private void RemoveClick(object sender, EventArgs e)
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

        //confirms selected action with infos entered when Confirm button is clicked
        private void ConfirmClick(object sender, EventArgs e)
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
        private void GetClick(object sender, EventArgs e)
        {
            panel2.Show();
            con.Open();
            com = new SqlCommand("Select * from Rooms where roomnumber=@roomnumber", con);
            com.Parameters.AddWithValue("@roomnumber", int.Parse(textBox1.Text));
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
