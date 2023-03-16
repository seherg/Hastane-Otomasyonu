using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_center_management
{
    public partial class Frm_home : Form
    {
        public Frm_home()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Frm_home.ActiveForm.Close();
                Frm_login form = new Frm_login();
                form.Show();
            }
            else
            {

            }
        }



        private void Exit_Click_1(object sender, EventArgs e)
        {
            Frm_home.ActiveForm.Close();
            Frm_login form = new Frm_login();
            form.Show();
        }

        private void Editinformation_Click(object sender, EventArgs e)
        {
            Frm_home.ActiveForm.Close();
            Frm_Edit_information form = new Frm_Edit_information();
            form.Show();
        }

        private void Makeanappointment_Click(object sender, EventArgs e)
        {
            Frm_home.ActiveForm.Close();
            Frm_Make_an_appointment form = new Frm_Make_an_appointment();
            form.Show();
        }

        private void Vaccination_Click(object sender, EventArgs e)
        {
            Frm_home.ActiveForm.Close();
            Frm_vaccination form = new Frm_vaccination();
            form.Show();
        }

       

        private void Frm_home_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
