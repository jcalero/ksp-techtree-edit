using System;
using System.Windows.Forms;

namespace KSPTechTreeEditor
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
            var mw = new MainWindow();
            Application.Run(mw);
        }

    }
}
