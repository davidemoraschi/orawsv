﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WS_HOLAMUNDO
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
            Application.Run(new frm_HolaMundo());
        }
    }
}