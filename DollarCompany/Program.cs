using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompany
{
    public static class Program
    {
        public static StartForm startForm;
        public static SplashScreenForm splashForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            startForm = new StartForm();
            splashForm = new SplashScreenForm();

            Application.Run(splashForm);
        }
    }
}
