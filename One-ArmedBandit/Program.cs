using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_ArmedBandit
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
            LoginScreen LS = new LoginScreen();
            if(LS.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MachineScreen());

            }
        }
    }
}
