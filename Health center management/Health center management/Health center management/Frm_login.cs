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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
            doktor.Checked = true;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            Image a = guna2ImageButton1.PressedState.Image;
            guna2ImageButton1.PressedState.Image = guna2ImageButton1.Image;
            guna2ImageButton1.Image = a;
            if (i == 0)
            {
                password.UseSystemPasswordChar = true;
                i++;

            }
            else
            {
                password.UseSystemPasswordChar = false;
                i--;

            }
        }

        private void signup_Click(object sender, EventArgs e)
        {
            Frm_login.ActiveForm.Hide();
            Frm_Signup form = new Frm_Signup();
            form.Show();
        }

        private void signin_Click(object sender, EventArgs e)
        {
            //Patient

            if (Patient.Checked == true)
            {
                Database db = new Database();
                DataTable tbl = new DataTable();

                tbl.Clear();
                tbl = db.readData("select PT_id,PT_name,PT_lastname,username,password,PT_tc from Patient", "");

                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    if (tbl.Rows[i][3].ToString() == username.Text && tbl.Rows[i][4].ToString() == password.Text)
                    {
                        SessionManager.IdentityNumber = tbl.Rows[i][5].ToString();
                        MessageBox.Show("Seher GÜMÜŞAY ");

                        Frm_login.ActiveForm.Hide();
                        Frm_home form = new Frm_home();
                        form.Controls["name"].Text = tbl.Rows[i][1].ToString() + " " + tbl.Rows[i][2].ToString();
                        form.Show();

                        return;
                    }

                }

                if (password.Text == "" || username.Text == "")
                {
                    MessageBox.Show("Please enter a username and password", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Your name is not in the Patient names ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

            //Doctor

            else if (doktor.Checked == true)
            {

                Database db = new Database();
                DataTable tbl = new DataTable();

                tbl.Clear();
                tbl = db.readData("select Dr_id,Dr_name,Dr_lastname,username,password,Dr_tc from Doctor", "");

                for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                {
                    if (tbl.Rows[i][3].ToString() == username.Text && tbl.Rows[i][4].ToString() == password.Text)
                    {
                        SessionManager.IdentityNumber = tbl.Rows[i][5].ToString();
                        MessageBox.Show("welcome " + tbl.Rows[i][1].ToString() + " " + tbl.Rows[i][2].ToString() + "", "welcome", MessageBoxButtons.OK, MessageBoxIcon.None);

                        Frm_login.ActiveForm.Hide();
                        Frm_Doctor form = new Frm_Doctor();
                        form.Controls["name"].Text = tbl.Rows[i][1].ToString() + " " + tbl.Rows[i][2].ToString();


                        form.Show();


                        return;
                    }

                }

                if (password.Text == "" || username.Text == "")
                {
                    MessageBox.Show("Please enter a username and password", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Your name is not in the Doctors names ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Seher Gümüşay");
        }
    }
}
