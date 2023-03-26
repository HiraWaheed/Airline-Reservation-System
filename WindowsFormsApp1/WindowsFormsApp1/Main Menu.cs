using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_Us_Form form = new About_Us_Form();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Menu form = new Main_Menu();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//schedules
        {
            Schedules_Form form = new Schedules_Form();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e) //pricing
        {
           Pricing_Form form = new Pricing_Form();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)//Contact us
        {
            Contact_Us_Form form = new Contact_Us_Form();
            form.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            form.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            this.Hide();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)//About Us
        {
            About_Us_Form form = new About_Us_Form();
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)//Where We fly
        {
            this.Hide();
            Where_We_Fly_Form form = new Where_We_Fly_Form();
            form.Show();
           
        }
    }
}
