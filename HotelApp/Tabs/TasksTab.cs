using Microsoft.IdentityModel.Tokens;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class TasksTab : UserControl
    {
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;
        private SqlDataAdapter da;
        private MainPage mp;
        private string checkedInCheck = null;
        private int guestID;

        public TasksTab()
        {
            InitializeComponent();
        }

        //receives reference to the mainpage, gets connection from said mainpage and sets buttons layout
        public void SetAtt(MainPage mp)
        {
            this.mp = mp;
            con = mp.GetCon();
        }

        //updates in-app table view with data relevant to user's role
        private void UpdateView()
        {
            con.Open();
            DataTable table = new DataTable();
            switch (mp.GetRole())
            {
                case "Admin":
                    FindCheckIns(table);
                    FindCheckOuts(table);
                    FindCleanUps(table);
                    break;
                case "Boss":
                    FindCheckIns(table);
                    FindCheckOuts(table);
                    FindCleanUps(table);
                    break;
                case "Desk":
                    FindCheckIns(table);
                    FindCheckOuts(table);
                    break;
                case "Cleaning":
                    FindCleanUps(table);
                    break;
            }
            dataGridView1.DataSource = table;
            con.Close();
        }

        //adds check ins to table for the entered date
        private void FindCheckIns(DataTable table)
        {
            com = new SqlCommand(("SELECT Reservations.ReservationID, Reservations.RoomNumber, CONCAT(Guests.FirstName, ' ', Guests.LastName) AS 'Guest Name', Reservations.CheckInDate, Reservations.CheckOutDate FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE CheckInDate LIKE @date AND CheckedInBy IS NULL"), con);
            com.Parameters.AddWithValue("@date", dateBox.Text + "%");
            da = new SqlDataAdapter(com);
            da.Fill(table);
        }

        //adds check outs to table for the entered date
        private void FindCheckOuts(DataTable table) 
        { 
            com = new SqlCommand(("SELECT Reservations.ReservationID, Reservations.RoomNumber, CONCAT(Guests.FirstName, ' ', Guests.LastName) AS 'Guest Name', Reservations.CheckInDate, Reservations.CheckOutDate FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE CheckOutDate LIKE @date AND CheckedOutBy IS NULL"), con);
            com.Parameters.AddWithValue("@date", dateBox.Text + "%");
            da = new SqlDataAdapter(com);
            da.Fill(table);
        }

        //adds clean ups to table for the entered date
        private void FindCleanUps(DataTable table)
        {
            com = new SqlCommand(("SELECT Reservations.ReservationID, Reservations.RoomNumber, Reservations.CheckOutDate FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE CheckOutDate=@date AND CleanedBy IS NULL"), con);
            com.Parameters.AddWithValue("@date", dateBox.Text);
            da = new SqlDataAdapter(com);
            da.Fill(table);
        }

        //removes precedent selection state
        private void ResetView()
        {
            infosPanel.Hide();
            reservationIDPanel.Hide();
            viewButton.BackColor = Color.Gainsboro;
            completeButton.BackColor = Color.Gainsboro;
        }

        //clears textboxes
        private void ClearFields()
        {
            reservationIDBox.Clear();
            roomNumberBox.Clear();
            guestNameBox.Clear();
            checkInDateBox.Clear();
            checkOutDateBox.Clear();
            notesBox.Clear();
            EmployeeIDBox.Clear();
            checkInBox.Checked = false;
            checkOutBox.Checked = false;
            cleanUpBox.Checked = false;
        }

        //opens view table when View button is clicked
        private void ViewButtonClick(object sender, EventArgs e)
        {
            ResetView();
            viewButton.BackColor = Color.YellowGreen;
            UpdateView();
        }

        //opens form to complete tasks
        private void CompleteButtonClick(object sender, EventArgs e)
        {
            ResetView();
            completeButton.BackColor = Color.YellowGreen;
            reservationIDPanel.Show();
            UpdateView();
        }

        //updates view with date entered
        private void DateGetButtonClick(object sender, EventArgs e)
        {
            UpdateView();
        }

        //gets infos related to entered reservation ID when get button is clicked
        private void GetButtonClick(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("SELECT Reservations.ReservationID, Reservations.RoomNumber, Guests.FirstName, Guests.LastName, Reservations.CheckInDate, Reservations.CheckOutDate, Reservations.Notes, Guests.Notes, Reservations.CheckedInBy, Reservations.GuestID FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE ReservationID=@reservationid", con);
            com.Parameters.AddWithValue("@reservationid", reservationIDBox.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                reservationIDBox.Text = dr.GetValue(0).ToString();
                roomNumberBox.Text = dr.GetValue(1).ToString();
                guestNameBox.Text = dr.GetValue(2).ToString().TrimEnd() + " " + dr.GetValue(3).ToString();
                checkInDateBox.Text = dr.GetValue(4).ToString();
                checkOutDateBox.Text = dr.GetValue(5).ToString();
                notesBox.Text = "reservation notes: " + dr.GetValue(6).ToString().TrimEnd() + "\nguest notes: " + dr.GetValue(7).ToString();
                checkedInCheck = dr.GetValue(8).ToString();
                guestID = int.Parse(dr.GetValue(9).ToString());
            }
            con.Close();
            SetConfirmButton();
            infosPanel.Show();
        }

        //sets confirm button tag depending on user's role
        private void SetConfirmButton()
        {
            if (mp.GetRole().Equals("Cleaning"))
            {
                confirmButton.Text = "Cleaned";
            }
            else if (mp.GetRole().Equals("Desk"))
            {
                if (checkedInCheck.IsNullOrEmpty())
                {
                    confirmButton.Text = "Check In";
                }
                else
                {
                    confirmButton.Text = "Check Out";
                }
            } else
            {
                confirmButton.Text = "Confirm";
                selectionPanel.Show();
            }
        }

        //confirms selected action with infos entered when Confirm button is clicked
        private void ConfirmButtonClick(object sender, EventArgs e)
        {
            switch (confirmButton.Text)
            {
                case "Check In":
                    CheckInReservation(mp.GetEmployeeID());
                    ClearFields();
                    confirmButton.Text = "Done";
                    break;
                case "Check Out":
                    CheckOutReservation(mp.GetEmployeeID());
                    ClearFields();
                    confirmButton.Text = "Done";
                    break;
                case "Cleaned":
                    RoomCleaned(mp.GetEmployeeID());
                    ClearFields();
                    confirmButton.Text = "Done";
                    break;
                default:
                    if (checkInBox.Checked)
                    {
                        CheckInReservation(int.Parse(EmployeeIDBox.Text));
                        ClearFields();
                        confirmButton.Text = "Done";
                    }
                    else if (checkOutBox.Checked)
                    {
                        CheckOutReservation(int.Parse(EmployeeIDBox.Text));
                        ClearFields();
                        confirmButton.Text = "Done";
                    }
                    else if (cleanUpBox.Checked)
                    {
                        RoomCleaned(int.Parse(EmployeeIDBox.Text));
                        ClearFields();
                        confirmButton.Text = "Done";
                    }
                    break;
            }
        }

        //updates reservation and room as checked in
        private void CheckInReservation(int employeeID)
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET CheckedInBy=@employeeid WHERE ReservationID=@reservationid", con);
                com.Parameters.AddWithValue("@reservationid", int.Parse(reservationIDBox.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();
                com = new SqlCommand("UPDATE Rooms SET GuestID=@guestid WHERE RoomNumber=@roomnumber", con);
                com.Parameters.AddWithValue("@roomnumber", int.Parse(roomNumberBox.Text));
                com.Parameters.AddWithValue("@guestid", guestID);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //updates reservation and room as checked out
        private void CheckOutReservation(int employeeID)
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET CheckedOutBy=@employeeid WHERE ReservationID=@reservationid", con);
                com.Parameters.AddWithValue("@reservationid", int.Parse(reservationIDBox.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();
                com = new SqlCommand("UPDATE Rooms SET GuestID=@guestid WHERE RoomNumber=@roomnumber", con);
                com.Parameters.AddWithValue("@roomnumber", int.Parse(roomNumberBox.Text));
                com.Parameters.AddWithValue("@guestid", 0);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //updates reservation and room as cleaned up
        private void RoomCleaned(int employeeID)
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET CleanedBy=@employeeid WHERE ReservationID=@reservationid", con);
                com.Parameters.AddWithValue("@reservationid", int.Parse(reservationIDBox.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();
                com = new SqlCommand("UPDATE Rooms SET CleanedBy=@employeeid WHERE RoomNumber=@roomnumber", con);
                com.Parameters.AddWithValue("@roomnumber", int.Parse(roomNumberBox.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        //unchecks other checkboxes when checkInBox is clicked
        private void CheckInBoxCheckedChanged(object sender, EventArgs e)
        {
            checkOutBox.Checked = false;
            cleanUpBox.Checked = false;
        }

        //unchecks other checkboxes when checkOutBox is clicked
        private void CheckOutBoxCheckedChanged(object sender, EventArgs e)
        {
            checkInBox.Checked = false;
            cleanUpBox.Checked = false;
        }

        //unchecks other checkboxes when cleanUpBox is clicked
        private void CleanUpBoxCheckedChanged(object sender, EventArgs e)
        {
            checkInBox.Checked = false;
            checkOutBox.Checked = false;
        }
    }
}
