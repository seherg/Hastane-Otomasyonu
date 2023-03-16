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
    public partial class Frm_Doctor : Form
    {
        
        public Frm_Doctor()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;


        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Doctor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'veritabani2DataSet5.ilac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ilacTableAdapter2.Fill(this.veritabani2DataSet5.ilac);
            griddoldur();
        }
        void griddoldur()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=veritabani2;Integrated Security=True");
            da = new SqlDataAdapter("Select *From ilac", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ilac");
            dataGridView1.DataSource = ds.Tables["ilac"];
            con.Close();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ilac(pt_name,pt_lastname,ilac_name,ilac_doz) values ('" + guna2TextBox1.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from ilac where pt_name='" + guna2TextBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guna2TextBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    } 
}
