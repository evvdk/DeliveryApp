using System;
using System.Windows.Forms;

namespace DeliveryApp
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
            (new LoginForm()).Show();
            Application.Run();
        }
    }
}
