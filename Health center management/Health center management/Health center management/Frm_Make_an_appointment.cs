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

namespace Health_center_management
{
    public partial class Frm_Make_an_appointment : Form
    {
        public Frm_Make_an_appointment()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void signup_Click(object sender, EventArgs e)
        {
            bool validationResult = CheckFormValidation();
            if (validationResult == false)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cmd = new SqlCommand();
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into appointment(pt_tc,pt_name,pt_lastname,policlinic,time,doctor) values ('" + guna2TextBox4.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox1.Text + "','" + Preview.Text + "','" + time.Text + "','" + doctor.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private bool CheckFormValidation()
        {
            return !string.IsNullOrWhiteSpace(guna2TextBox4.Text) &&
                !string.IsNullOrWhiteSpace(guna2TextBox2.Text) &&
                !string.IsNullOrWhiteSpace(guna2TextBox1.Text) &&
                !string.IsNullOrWhiteSpace(Preview.Text) &&
                !string.IsNullOrWhiteSpace(time.Text) &&
                !string.IsNullOrWhiteSpace(doctor.Text);
        }

        void griddoldur()
        {
            
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
            da = new SqlDataAdapter("Select *From appointment", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "appointment");
            dataGridView1.DataSource = ds.Tables["appointment"];
            con.Close();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Make_an_appointment_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabani2DataSet7.appointment' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.appointmentTableAdapter.Fill(this.veritabani2DataSet7.appointment);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Frm_Make_an_appointment.ActiveForm.Close();
            Frm_home form = new Frm_home();
            form.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from appointment where PT_tc='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
