using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AshishT.Tools.TfptWrapper
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
            TfptWrapperController controller = new TfptWrapperController();
            controller.StartUI();
        }
    }
}