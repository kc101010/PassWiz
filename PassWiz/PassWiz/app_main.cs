﻿using System;
using System.Windows.Forms;


namespace PassWiz
{
    static class App_main
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new passwiz_form());
        }

      
    }
}
