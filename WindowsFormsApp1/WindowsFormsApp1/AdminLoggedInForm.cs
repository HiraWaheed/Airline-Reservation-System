using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class AdminLoggedInForm : Form
    {
        private SqlConnection DBConnection;
        public AdminLoggedInForm()
        {
            InitializeComponent();
            this.DBConnection = new SqlConnection("Data Source=EXODUS\\SQLEXPRESS;Initial Catalog=AirlineDB;Integrated Security=True");
        }

        private void button5_Click(object sender, EventArgs e)//Exit button
        {
            Application.Exit();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu();
            form.Show();
            this.Hide();
        }

        private void btnA_Click(object sender, EventArgs e)
        {

            About_Us_Form form = new About_Us_Form();
            form.Show();
            this.Hide();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Schedules_Form form = new Schedules_Form();
            form.Show();
            this.Hide();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            Pricing_Form form = new Pricing_Form();
            form.Show();
            this.Hide();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Contact_Us_Form form = new Contact_Us_Form();
            form.Show();
            this.Hide();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            form.Show();
            this.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminLoggedInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCFA_Click(object sender, EventArgs e)
        {
            int ticket_no = int.Parse(textBoxTicket.Text);
            DBConnection.Open();
            string DeleteReservationQuery = "DELETE FROM Reservation WHERE Ticket_No =@ticket_no;";
            SqlCommand DeleteReservation = new SqlCommand(DeleteReservationQuery, DBConnection);
            DeleteReservation.Parameters.AddWithValue("@Ticket_No", ticket_no);

            DeleteReservation.ExecuteNonQuery();
            MessageBox.Show("Reservation Cancelled Successfully");
            DBConnection.Close();
        }
    }
}
