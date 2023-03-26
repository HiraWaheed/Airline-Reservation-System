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
    public partial class PassengerLoggedInForm : Form
    {
        private SqlConnection DBConnection;
        private string emailP;
        public PassengerLoggedInForm(string email)
        {
            InitializeComponent();
            this.DBConnection = new SqlConnection("Data Source=EXODUS\\SQLEXPRESS;Initial Catalog=AirlineDB;Integrated Security=True");
            emailP = email;
        }

        private void button5_Click(object sender, EventArgs e)//Exit button
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            form.Show();
            this.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PassengerLoggedInForm_Load(object sender, EventArgs e)
        {
           /* DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Departure_Time FROM Reservation", DBConnection);
            adapter.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["Departure_Time"] = "Select Departure time";
            dt.Rows.InsertAt(dr, 0);
            comboBoxDepTime.ValueMember = "Departure_Time";
            // comboBoxDepTime.DisplayMember = "EmpName";
            comboBoxDepTime.DataSource = dt;
           */
        }

        private void btnVPP_Click(object sender, EventArgs e)
        {
            string ViewPassengerQuery = "SELECT * FROM Passengers WHERE P_Email= '"+emailP+"'";
            DBConnection.Open();
            SqlCommand ViewPassenger = new SqlCommand(ViewPassengerQuery, DBConnection);
            SqlDataAdapter sda = new SqlDataAdapter(ViewPassenger);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvPassengerProfile.DataSource = dt;
            DBConnection.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBFP_Click(object sender, EventArgs e)
        {
           
            /* comboBoxDepTime.DataSource = dt;
             comboBoxDepTime.DataTextField = "name";
             comboBoxDepTime.DataValueField = "name";
             comboBoxDepTime.DataBindings();
             ddlTable.Items.Insert(0, new ListItem("-- Select Table --", "0"));*/
            int passportNo = int.Parse(textBoxPassport.Text);
            string seatNo = comboBoxSeat.Text;//
            int payment = 120;
            DateTime reservationdate = System.DateTime.Now;
            //DateTime depttime = comboBoxDepTime.SelectedItem;//
            //string arrivaltime = textBoxEs.Text;//
            //string origin = //
              //  string destination=//
            
        }

        private void btnCFP_Click(object sender, EventArgs e)
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
