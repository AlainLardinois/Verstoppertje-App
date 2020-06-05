using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verstoppertje_App.Forms;

namespace Verstoppertje_App
{
    static class Program
    {
        public static MainLayout form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form = new MainLayout();
            Application.Run(form);
        }
    }
}
