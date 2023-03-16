using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_center_management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Thread t = new Thread(new ThreadStart(getstrat));
            //t.Start();
            //Thread.Sleep(5000);
            //t.Abort();

            Application.Run(new Frm_Strart());
        }
        static void getstrat()
        {
            Application.Run(new Frm_Doctor());

        }
    }
}
