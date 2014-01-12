using System;
using System.Windows.Forms;

namespace AVTTLoaderStandalone
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
            var app = new AVTTEditor(mw);
        }

    }

    public class AVTTEditor
    {
        public AVTTEditor(MainWindow mw)
        {
            
        }
    }
}
