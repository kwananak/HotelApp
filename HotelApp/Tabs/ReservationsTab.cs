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
                    guestIDLabel.Hide();
                    roomNumberLabel.Hide();
                    checkInDateLabel.Hide();
                    checkOutDateLabel.Hide();
                    guestIDBox.Hide();
                    roomNumberBox.Hide();
                    checkInDateBox.Hide();
                    checkOutDateBox.Hide();
                    break;
                case "Desk":
                    removeButton.Hide();
                    break;
            }
        }

        //adds reservation to table with entered attributes
        private void CreateReservation()
        {
            con.Open();
            try
            {
                com = new SqlCommand("INSERT INTO reservations VALUES(@guestid, @roomnumber, @checkindate, @checkoutdate, null, null, null, @notes)", con);
                com.Parameters.AddWithValue("@guestid", int.Parse(guestIDBox.Text));
                com.Parameters.AddWithValue("@roomnumber", int.Parse(roomNumberBox.Text));
                com.Parameters.AddWithValue("@checkindate", checkInDateBox.Text);
                com.Parameters.AddWithValue("@checkoutdate", checkOutDateBox.Text);
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

        //updates in-app table view
        private void UpdateView()
        {
            con.Open();
            com = new SqlCommand(("SELECT reservationID AS 'Reservation ID', CONCAT(Guests.FirstName, ' ', Guests.LastName) AS 'Guest Name', RoomNumber AS 'Room Number', CheckInDate AS 'Check In Date', CheckOutDate AS 'Check Out Date', CheckedInBy, CheckedOutBy, CleanedBy, Reservations.Notes FROM Reservations JOIN Guests ON Reservations.GuestID=Guests.GuestID ORDER BY CheckInDate"), con);
            da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            DataColumn checkedInCol = new DataColumn("Checked In By", typeof(string));
            table.Columns.Add(checkedInCol);
            DataColumn checkedOutCol = new DataColumn("Checked Out By", typeof(string));
            table.Columns.Add(checkedOutCol);
            DataColumn cleanedCol = new DataColumn("Cleaned By", typeof(string));
            table.Columns.Add(cleanedCol);
            foreach (DataRow row in table.Rows)
            {
                com = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) FROM Employees WHERE EmployeeID=@employeeid", con);
                com.Parameters.AddWithValue("@employeeid", row["CheckedInBy"].ToString());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    row[checkedInCol] = dr.GetValue(0).ToString();
                }
                com = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) FROM Employees WHERE EmployeeID=@employeeid", con);
                com.Parameters.AddWithValue("@employeeid", row["CheckedOutBy"].ToString());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    row[checkedOutCol] = dr.GetValue(0).ToString();
                }
                com = new SqlCommand("SELECT CONCAT(FirstName, ' ', LastName) FROM Employees WHERE EmployeeID=@employeeid", con);
                com.Parameters.AddWithValue("@employeeid", row["CleanedBy"].ToString());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    row[cleanedCol] = dr.GetValue(0).ToString();
                }
            }
            table.Columns.Remove("CheckedInBy");
            table.Columns.Remove("CheckedOutBy");
            table.Columns.Remove("CleanedBy");
            table.Columns[5].SetOrdinal(8);
            dataGridView1.DataSource = table;
            con.Close();
        }

        //updates room selected by room number with entered attributes
        private void UpdateReservation()
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET RoomNumber=@roomnumber, CheckInDate=@checkindate, CheckOutDate=@checkoutdate, Notes=@notes WHERE ReservationID=@reservationid", con);
                com.Parameters.AddWithValue("@reservationid", int.Parse(reservationIDBox.Text));
                com.Parameters.AddWithValue("@roomnumber", int.Parse(roomNumberBox.Text));
                com.Parameters.AddWithValue("@checkindate", checkInDateBox.Text);
                com.Parameters.AddWithValue("@checkoutdate", checkOutDateBox.Text);
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
        private void DeleteReservation()
        {
            con.Open();
            try
            {
                com = new SqlCommand("DELETE FROM Reservations WHERE ReservationID=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(reservationIDBox.Text));
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
            reservationIDBox.Clear();
            guestIDBox.Clear();
            roomNumberBox.Clear();
            checkInDateBox.Clear();
            checkOutDateBox.Clear();
            notesBox.Clear();
        }

        //removes precedent selection state
        private void ResetView()
        {
            infosPanel.Hide();
            reservationIDPanel.Hide();
            viewButton.BackColor = Color.Gainsboro;
            updateButton.BackColor = Color.Gainsboro;
            newButton.BackColor = Color.Gainsboro;
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
            reservationIDPanel.Show();
            UpdateView();
        }

        //opens new entry form when New button is clicked
        private void NewButtonClick(object sender, EventArgs e)
        {
            ResetView();
            ClearFields();
            activeView = 1;
            newButton.BackColor = Color.Goldenrod;
            infosPanel.Show();
            UpdateView();
        }

        //opens remove entry form when Update button is clicked
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            removeButton.BackColor = Color.Goldenrod;
            reservationIDPanel.Show();
            UpdateView();
        }

        //confirms selected action with infos entered when Confirm button is clicked
        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            switch (activeView)
            {
                case 1:
                    CreateReservation();
                    break;
                case 2:
                    UpdateReservation();
                    break;
                case 3:
                    DeleteReservation();
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
            com = new SqlCommand("SELECT * FROM Reservations WHERE ReservationID=@reservationid", con);
            com.Parameters.AddWithValue("@reservationid", reservationIDBox.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                reservationIDBox.Text = dr.GetValue(0).ToString();
                guestIDBox.Text = dr.GetValue(1).ToString();
                roomNumberBox.Text = dr.GetValue(2).ToString();
                checkInDateBox.Text = dr.GetValue(3).ToString();
                checkOutDateBox.Text = dr.GetValue(4).ToString();
                notesBox.Text = dr.GetValue(8).ToString();
            }
            con.Close();
        }
    }
}
