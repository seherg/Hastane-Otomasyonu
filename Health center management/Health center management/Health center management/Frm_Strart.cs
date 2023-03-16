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
    public partial class Frm_Strart : Form
    {
        public Frm_Strart()
        {
            InitializeComponent();
        }

        private void Frm_Strart_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Frm_login login = new Frm_login();
                login.Show();
                this.Hide();
            }
            else
            {
                progressBar1.Value++;
            }
        }
    }
}
