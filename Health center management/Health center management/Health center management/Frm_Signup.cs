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
    public partial class Frm_Signup : Form
    {
        public Frm_Signup()
        {
            InitializeComponent();
        }

        Database db = new Database();
        DataTable Table1 = new DataTable();

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (doktor.Checked == true)
            {
                Table1 = db.readData("select * from Doctor ", "");
                bool resul1 = db.exceuteData("insert into Doctor (Dr_id,Dr_tc,Dr_name,Dr_lastname,Dr_phone,Dr_tarih,username,password) values ('" + Convert.ToInt32(Table1.Rows.Count + 1) + "','" + tckimlik.Text + "','" + ad.Text + "','" + soyaad.Text + "','" + telefon.Text + "','" + tarih.Text + "','" + username.Text + "','" + password.Text + "')", " successfully registered");
               // bool result2 = db.exceuteData("updete doctor set password= '"+username.Text+"' (" + Convert.ToInt32(Table1.Rows.Count + 1) + ",'" + tckimlik.Text + "','" + ad.Text + "','" + soyaad.Text + "','" + telefon.Text + "','" + tarih.Text + "','" + username.Text + "','" + password.Text + "')", " successfully registered");

                Frm_Signup.ActiveForm?.Hide();
                Frm_login form = new Frm_login();
                form.Show();
            }
            else
            {
                Table1 = db.readData("select * from Patient ", "");
                bool result = db.exceuteData("insert into Patient (PT_id, PT_tc, PT_name,PT_lastname,PT_phone,PT_tarih,username, password) values ('" + Convert.ToInt32(Table1.Rows.Count + 1) + "','" + tckimlik.Text + "','" + ad.Text + "','" + soyaad.Text + "','" + telefon.Text + "','" + tarih.Text + "','" + username.Text + "','" + password.Text + "')", " successfully registered");

                Frm_Signup.ActiveForm?.Hide();
                Frm_login form = new Frm_login();
                form.Show();
            }


        }

        private void Frm_Signup_Load(object sender, EventArgs e)
        {
            Patient.Checked = true;
        }

        private void Frm_Signup_Load_1(object sender, EventArgs e)
        {

        }
    }
}
