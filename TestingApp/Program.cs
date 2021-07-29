using System;
using System.Windows.Forms;

namespace ConwayGameOfLife
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
            Form mainForm = new mainForm();
            Application.Run(mainForm);
        }

        
    }
}
