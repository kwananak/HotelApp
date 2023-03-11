using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HotelApp
{
    public partial class MainPage : Form
    {
        public MainPage(SqlConnection con, String role)
        {
            this.con = con;
            this.role = role;
            InitializeComponent();
        }

        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader da;
        private String role;
    }
}
