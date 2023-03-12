using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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
                    newButton.Hide();
                    removeButton.Hide();
                    break;
                case "Desk":
                    newButton.Hide();
                    removeButton.Hide();
                    break;
            }
        }

        //adds room to table with entered attributes
        private void CreateRoom()
        {
            con.Open();
            try
            {
                com = new SqlCommand("INSERT INTO Rooms VALUES(@roomnumber,null , null, @notes)", con);
                com.Parameters.AddWithValue("@roomnumber", int.Parse(roomNumberBox.Text));
                com.Parameters.AddWithValue("@notes", notesBox.Text);
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
                com = new SqlCommand("UPDATE Rooms SET notes=@notes WHERE RoomNumber=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(roomNumberBox.Text));
                com.Parameters.AddWithValue("@notes", notesBox.Text);
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
                com = new SqlCommand("DELETE FROM Rooms WHERE RoomNumber=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(roomNumberBox.Text));
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
            com = new SqlCommand(("SELECT RoomNumber AS 'Room Number', CONCAT(Guests.FirstName, Guests.LastName) AS 'Guest Name', CONCAT(Employees.FirstName, Employees.LastName ) AS 'Cleaned By', Rooms.Notes FROM Rooms LEFT JOIN Guests ON Rooms.GuestID=Guests.GuestID LEFT JOIN Employees ON Rooms.CleanedBy=Employees.EmployeeID ORDER BY RoomNumber"), con);
            da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        //clears textboxes
        private void ClearFields()
        {
            roomNumberBox.Clear();
            guestIDBox.Clear();
            notesBox.Clear();
        }

        //removes precedent selection state
        private void ResetView()
        {
            infosPanel.Hide();
            roomNumberPanel.Hide();
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
            viewButton.BackColor = Color.YellowGreen;
            UpdateView();
        }

        //opens new entry form when New button is clicked
        private void NewButtonClick(object sender, EventArgs e)
        {
            ResetView();
            ClearFields();
            activeView = 1;
            newButton.BackColor = Color.YellowGreen;
            getButton.Hide();
            guestIDLabel.Hide();
            guestIDBox.Hide();
            roomNumberPanel.Show();
            infosPanel.Show();
            UpdateView();
        }

        //opens update entry form when Update button is clicked
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 2;
            getButton.Show();
            guestIDLabel.Show();
            guestIDBox.Show();
            updateButton.BackColor = Color.YellowGreen;
            roomNumberPanel.Show();
            UpdateView();
        }

        //opens remove entry form when Remove button is clicked
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            getButton.Show();
            guestIDLabel.Show();
            guestIDBox.Show();
            removeButton.BackColor = Color.YellowGreen;
            roomNumberPanel.Show();
            UpdateView();
        }

        //confirms selected action with infos entered when Confirm button is clicked
        private void ConfirmButtonClick(object sender, EventArgs e)
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
            com = new SqlCommand("SELECT * FROM Rooms WHERE roomnumber=@roomnumber", con);
            com.Parameters.AddWithValue("@roomnumber", int.Parse(roomNumberBox.Text));
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                roomNumberBox.Text = dr.GetValue(0).ToString();
                guestIDBox.Text = dr.GetValue(1).ToString();
                notesBox.Text = dr.GetValue(3).ToString();
            }
            con.Close();
        }
    }
}
