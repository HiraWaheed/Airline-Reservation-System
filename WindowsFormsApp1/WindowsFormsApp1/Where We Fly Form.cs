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
    public partial class Where_We_Fly_Form : Form
    {
        public Where_We_Fly_Form()
        {
            InitializeComponent();
        }

        private void buttonX_Click(object sender, EventArgs e)
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

        private void Where_We_Fly_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineDBDataSet.WhereWeFly' table. You can move, or remove it, as needed.
            this.whereWeFlyTableAdapter.Fill(this.airlineDBDataSet.WhereWeFly);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_Form form = new Login_Form();
            form.Show();
            this.Hide();
        }
    }
}
