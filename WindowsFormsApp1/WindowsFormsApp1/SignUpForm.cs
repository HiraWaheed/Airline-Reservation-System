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
    public partial class SignUpForm : Form
    {
        private SqlConnection DBConnection;
        public SignUpForm()
        {
            InitializeComponent();
            this.DBConnection = new SqlConnection("Data Source=EXODUS\\SQLEXPRESS;Initial Catalog=AirlineDB;Integrated Security=True");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_Us_Form form = new About_Us_Form();
            form.Show();
            this.Hide();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu();
            form.Show();
            this.Hide();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            Schedules_Form form = new Schedules_Form();
            form.Show();
            this.Hide();
        }

        private void BtnP_Click(object sender, EventArgs e)
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

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            string email = textBoxEl.Text;
            string pwd = textBoxPl.Text;
            if (adminCheck.Checked)//as admin login
            {
                DBConnection.Open();

                //SqlDataAdapter sda = new SqlDataAdapter("exec SignInAdmin @email,@pwd ",DBConnection);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AdminLogin WHERE(Admin_Email ='" + @email + "' AND Admin_Password ='" + @pwd + "')", DBConnection);
                //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main_Menu form = new Main_Menu();
                    form.Show();
                }
                else
                    MessageBox.Show("Invalid username or password");
                DBConnection.Close();
            }
            else
            {
                DBConnection.Open();

                //SqlDataAdapter sda = new SqlDataAdapter("exec SignInAdmin @email,@pwd ",DBConnection);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM PassengerLogin WHERE(P_Email ='" + @email + "' AND P_Password ='" + @pwd + "')", DBConnection);
                //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Main_Menu form = new Main_Menu();
                    form.Show();
                }
                else
                    MessageBox.Show("Invalid username or password");
                DBConnection.Close();
            }
        }

        private void btnSU_Click(object sender, EventArgs e)
        {
           // int custom_id = int.Parse(txtId.Text);
            string passenger_name = textBoxN.Text;
            string passenger_phone = textBoxPhn.Text;
            int passenger_age = 20;
            string passenger_address = textBoxA.Text;

            string passenger_email = textBoxEs.Text;
            string passenger_password = textBoxPs.Text;
            int passenger_pointsEarned = 0;
            
            //int custom_no = int.Parse(txtContact.Text);
            DBConnection.Open();
            //string customerbook_date = txt_date.Text;
            //int custom_room = int.Parse(txtRoom.Text);
            string InsertPassengerLoginQuery = "INSERT INTO PassengerLogin VALUES (@Email,@Password)";
            SqlCommand InsertPassengerLogin = new SqlCommand(InsertPassengerLoginQuery, DBConnection);
            InsertPassengerLogin.Parameters.AddWithValue("@Email", passenger_email);
            InsertPassengerLogin.Parameters.AddWithValue("@Password",passenger_password);
            InsertPassengerLogin.ExecuteNonQuery();

            string InsertPassengerQuery = "INSERT INTO Passengers VALUES (@Name,@Address,@Phone,@Age,@Email,@Points)";
            SqlCommand InsertPassenger = new SqlCommand(InsertPassengerQuery, DBConnection);
            InsertPassengerLogin.Parameters.AddWithValue("@Email", passenger_email);
            InsertPassengerLogin.Parameters.AddWithValue("@Password",passenger_password);
            InsertPassenger.Parameters.AddWithValue("@Name", passenger_name);
            InsertPassenger.Parameters.AddWithValue("@Address", passenger_address);
            InsertPassenger.Parameters.AddWithValue("@Phone", passenger_phone);
            InsertPassenger.Parameters.AddWithValue("@Age", passenger_age);
            InsertPassenger.Parameters.AddWithValue("@Email", passenger_email);
            InsertPassenger.Parameters.AddWithValue("@Points", passenger_pointsEarned);
            InsertPassenger.ExecuteNonQuery();
            MessageBox.Show("Sign Up successful");
            Login_Form form = new Login_Form();
            this.Hide();
            form.Show();
            DBConnection.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
