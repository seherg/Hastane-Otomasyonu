using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_center_management
{
    public partial class Frm_vaccination : Form
    {
        public Frm_vaccination()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Frm_vaccination_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Frm_vaccination_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biontech randevunuz kaydedilmiştir.");
        }

        private void gunaGradientButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinovac randevunuz kaydedilmiştir.");
        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turkovac randevunuz kaydedilmiştir.");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Frm_Edit_information.ActiveForm.Close();
            Frm_home form = new Frm_home();
            form.Show();
        }
    }
}
