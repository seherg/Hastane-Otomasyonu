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
    public partial class Frm_Edit_information : Form
    {
        public Frm_Edit_information()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void InitializeDefaultFormValues()
        {
            /*
                   ,[PT_tc]
      ,[PT_name]
      ,[PT_lastname]
      ,[PT_phone]
      ,[PT_tarih]
      ,[username]
      ,[password]
             */
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
            da = new SqlDataAdapter("Select * From Patient where PT_tc='" + SessionManager.IdentityNumber + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Patient");
            con.Close();

            guna2TextBox4.Text = ds.Tables[0].Rows[0]["PT_tc"].ToString();
            guna2TextBox2.Text = ds.Tables[0].Rows[0]["PT_name"].ToString();
            guna2TextBox1.Text = ds.Tables[0].Rows[0]["PT_lastname"].ToString();
            guna2TextBox3.Text = ds.Tables[0].Rows[0]["PT_phone"].ToString();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Frm_Edit_information.ActiveForm.Close();
            Frm_home form = new Frm_home();
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Frm_Edit_information.ActiveForm.Close();
            Frm_home form = new Frm_home();
            form.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void griddoldur()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
            da = new SqlDataAdapter("Select *From Patient", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Patient");
            con.Close();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update Patient set PT_name='" + guna2TextBox2.Text + "',PT_lastname='" + guna2TextBox1.Text + "',PT_phone='" + guna2TextBox3.Text + "',password='" + guna2TextBox6.Text + "' where PT_tc='" + guna2TextBox4.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            MessageBox.Show("Güncelleme işleminiz başarıyla tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Edit_information_Load(object sender, EventArgs e)
        {
            InitializeDefaultFormValues();
        }
    }
}
