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
    public partial class Login_Form : Form
    {
        private SqlConnection DBConnection;
        public Login_Form()
        {
            InitializeComponent();
            this.DBConnection = new SqlConnection("Data Source=EXODUS\\SQLEXPRESS;Initial Catalog=AirlineDB;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu();
            form.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            About_Us_Form form = new About_Us_Form();
            form.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Schedules_Form form = new Schedules_Form();
            form.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Pricing_Form form = new Pricing_Form();
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string pwd = textBoxPassword.Text;
            if (adminCheck.Checked)//as admin login
            {
                DBConnection.Open();
               
                string PassengerLoginQuery = "exec SignInAdmin '" + textBoxEmail.Text + "', '" + textBoxPassword.Text + "'";
                SqlCommand PassengerLogin = new SqlCommand(PassengerLoginQuery, DBConnection);
                SqlDataAdapter sda = new SqlDataAdapter(PassengerLogin);
                DataTable dt = new DataTable();   
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    AdminLoggedInForm form = new AdminLoggedInForm();
                    form.Show();
                }
                else
                    MessageBox.Show("Invalid username or password");
                DBConnection.Close();
            }
            else
            {
                DBConnection.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM PassengerLogin WHERE(P_Email ='" + @email + "' AND P_Password ='" + @pwd + "')", DBConnection);
                
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    PassengerLoggedInForm form = new PassengerLoggedInForm(email);
                    form.Show();
                }
                else
                    MessageBox.Show("Invalid username or password");
                DBConnection.Close();
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
