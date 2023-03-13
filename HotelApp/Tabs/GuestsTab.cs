using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                    firstNameLabel.Hide();
                    lastNameLabel.Hide();
                    countryCodeLabel.Hide();
                    firstNameBox.Hide();
                    lastNameBox.Hide();
                    countryCodeBox.Hide();
                    break;
                case "Desk":
                    removeButton.Hide();
                    break;
            }
        }

        //adds guest to table with entered attributes
        private void CreateGuest()
        {
            con.Open();
            try
            {
                com = new SqlCommand("INSERT INTO Guests VALUES(@firstname,@lastname,@countrycode,@notes)", con);
                com.Parameters.AddWithValue("@firstname", firstNameBox.Text);
                com.Parameters.AddWithValue("@lastname", lastNameBox.Text);
                com.Parameters.AddWithValue("@countrycode", countryCodeBox.Text);
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

        //updates in-app table view with relevant data
        private void UpdateView()
        {
            con.Open();
            com = new SqlCommand(("SELECT * FROM Guests ORDER BY GuestID"), con);
            da = new SqlDataAdapter(com);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }

        //updates guest selected by guest ID
        private void UpdateGuest()
        {
            con.Open();
            try
            {
                com = new SqlCommand("UPDATE Guests SET FirstName=@firstname, LastName=@lastname, CountryCode=@countrycode, Notes=@notes WHERE GuestID=@id", con);
                com.Parameters.AddWithValue("@id", int.Parse(GuestIDBox.Text));
                com.Parameters.AddWithValue("@firstname", firstNameBox.Text);
                com.Parameters.AddWithValue("@lastname", lastNameBox.Text);
                com.Parameters.AddWithValue("@countrycode", countryCodeBox.Text);
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

        //removes guest selected by guest ID
        private void DeleteGuest()
        {
            con.Open();
            try
            {
                com = new SqlCommand("DELETE FROM Guests WHERE GuestID=@id", con);
                com.Parameters.AddWithValue("@id", GuestIDBox.Text);
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
            GuestIDBox.Clear();
            firstNameBox.Clear();
            lastNameBox.Clear();
            countryCodeBox.Clear();
            notesBox.Clear();
        }

        //removes precedent selection state
        private void ResetView()
        {
            infosPanel.Hide();
            guestIDPanel.Hide();
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

        //opens new entry form when New button is clicked
        private void NewButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 1;
            newButton.BackColor = Color.Goldenrod;
            infosPanel.Show();
            UpdateView();
        }

        //opens update entry form when Update button is clicked
        private void UpdateButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 2;
            updateButton.BackColor = Color.Goldenrod;
            guestIDPanel.Show();
            UpdateView();
        }

        //opens remove entry form when Remove button is clicked
        private void RemoveButtonClick(object sender, EventArgs e)
        {
            ResetView();
            activeView = 3;
            removeButton.BackColor = Color.Goldenrod;
            guestIDPanel.Show();
            UpdateView();
        }

        //confirms selected action with infos entered when Confirm button is clicked
        private void ConfirmButtonClick(object sender, EventArgs e)
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
            com = new SqlCommand("SELECT * FROM guests WHERE GuestID=@id", con);
            com.Parameters.AddWithValue("@id", GuestIDBox.Text);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                GuestIDBox.Text = dr.GetValue(0).ToString();
                firstNameBox.Text = dr.GetValue(1).ToString();
                lastNameBox.Text = dr.GetValue(2).ToString();
                countryCodeBox.Text = dr.GetValue(3).ToString();
                notesBox.Text = dr.GetValue(4).ToString();
            }
            con.Close();
        }
    }
}
