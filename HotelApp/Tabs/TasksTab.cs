using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                case "admin":
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

        //adds check ins to  table for the entered date
        private void FindCheckIns(DataTable table)
        {
            com = new SqlCommand(("SELECT Reservations.ReservationID, Reservations.RoomNumber, CONCAT(Guests.FirstName, Guests.LastName) AS 'Guest Name', Reservations.CheckInDate, Reservations.CheckOutDate FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE CheckInDate LIKE @date AND CheckedInBy IS NULL"), con);
            com.Parameters.AddWithValue("@date", textBox7.Text + "%");
            da = new SqlDataAdapter(com);
            da.Fill(table);
        }

        //adds check ins to  table for the entered date
        private void FindCheckOuts(DataTable table) 
        { 
            com = new SqlCommand(("SELECT Reservations.ReservationID, Reservations.RoomNumber, CONCAT(Guests.FirstName, Guests.LastName) AS 'Guest Name', Reservations.CheckInDate, Reservations.CheckOutDate FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE CheckOutDate LIKE @date AND CheckedOutBy IS NULL"), con);
            com.Parameters.AddWithValue("@date", textBox7.Text + "%");
            da = new SqlDataAdapter(com);
            da.Fill(table);
        }

        //adds check ins to  table for the entered date
        private void FindCleanUps(DataTable table)
        {
            com = new SqlCommand(("SELECT Reservations.ReservationID, Reservations.RoomNumber, Reservations.CheckOutDate FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE CheckOutDate=@date AND CleanedBy IS NULL"), con);
            com.Parameters.AddWithValue("@date", textBox7.Text);
            da = new SqlDataAdapter(com);
            da.Fill(table);
        }

        //removes precedent selection state
        private void ResetView()
        {
            panel2.Hide();
            panel3.Hide();
            viewButton.BackColor = Color.Gainsboro;
            completeButton.BackColor = Color.Gainsboro;
        }

        //clears textboxes
        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
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

        private void CompleteButtonClick(object sender, EventArgs e)
        {
            ResetView();
            completeButton.BackColor = Color.YellowGreen;
            panel3.Show();
            UpdateView();
        }

        //updates view with date entered
        private void DateGetButtonClick(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void GetButtonClick(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("SELECT Reservations.ReservationID, Reservations.RoomNumber, Guests.FirstName, Guests.LastName, Reservations.CheckInDate, Reservations.CheckOutDate, Reservations.Notes, Guests.Notes, Reservations.CheckedInBy, Reservations.GuestID FROM Reservations INNER JOIN Guests ON Reservations.GuestID=Guests.GuestID WHERE ReservationID=@reservationid", con);
            com.Parameters.AddWithValue("@reservationid", textBox1.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();
                textBox2.Text = dr.GetValue(1).ToString();
                textBox3.Text = dr.GetValue(2).ToString().TrimEnd() + " " + dr.GetValue(3).ToString();
                textBox4.Text = dr.GetValue(4).ToString();
                textBox5.Text = dr.GetValue(5).ToString();
                textBox6.Text = "reservation notes: " + dr.GetValue(6).ToString().TrimEnd() + "\nguest notes: " + dr.GetValue(7).ToString();
                checkedInCheck = dr.GetValue(8).ToString();
                guestID = int.Parse(dr.GetValue(9).ToString());
            }
            con.Close();
            SetConfirmButton();
            panel2.Show();
        }

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
                panel1.Show();
            }
        }

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
                        CheckInReservation(int.Parse(textBox8.Text));
                        ClearFields();
                        confirmButton.Text = "Done";
                    }
                    else if (checkOutBox.Checked)
                    {
                        CheckOutReservation(int.Parse(textBox8.Text));
                        ClearFields();
                        confirmButton.Text = "Done";
                    }
                    else if (cleanUpBox.Checked)
                    {
                        RoomCleaned(int.Parse(textBox8.Text));
                        ClearFields();
                        confirmButton.Text = "Done";
                    }
                    break;
            }
        }

        private void CheckInReservation(int employeeID)
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET CheckedInBy=@employeeid WHERE ReservationID=@reservationid", con);
                com.Parameters.AddWithValue("@reservationid", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();

                com = new SqlCommand("UPDATE Rooms SET GuestID=@guestid WHERE RoomNumber=@roomnumber", con);
                com.Parameters.AddWithValue("@roomnumber", int.Parse(textBox2.Text));
                com.Parameters.AddWithValue("@guestid", guestID);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CheckOutReservation(int employeeID)
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET CheckedOutBy=@employeeid WHERE ReservationID=@reservationid", con);
                com.Parameters.AddWithValue("@reservationid", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();

                com = new SqlCommand("UPDATE Rooms SET GuestID=@guestid WHERE RoomNumber=@roomnumber", con);
                com.Parameters.AddWithValue("@roomnumber", int.Parse(textBox2.Text));
                com.Parameters.AddWithValue("@guestid", 0);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void RoomCleaned(int employeeID)
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Reservations SET CleanedBy=@employeeid WHERE ReservationID=@reservationid", con);
                com.Parameters.AddWithValue("@reservationid", int.Parse(textBox1.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();

                com = new SqlCommand("UPDATE Rooms SET CleanedBy=@employeeid WHERE RoomNumber=@roomnumber", con);
                com.Parameters.AddWithValue("@roomnumber", int.Parse(textBox2.Text));
                com.Parameters.AddWithValue("@employeeid", employeeID);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void CheckInBoxCheckedChanged(object sender, EventArgs e)
        {
            checkOutBox.Checked = false;
            cleanUpBox.Checked = false;
        }

        private void CheckOutBoxCheckedChanged(object sender, EventArgs e)
        {
            checkInBox.Checked = false;
            cleanUpBox.Checked = false;
        }

        private void CleanUpBoxCheckedChanged(object sender, EventArgs e)
        {
            checkInBox.Checked = false;
            checkOutBox.Checked = false;
        }
    }
}
