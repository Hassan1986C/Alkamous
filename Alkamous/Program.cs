using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Alkamous
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // to check if program is already open before start
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("Software already open ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.Frm_Main());
        }
    }
}
