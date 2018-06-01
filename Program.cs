using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Snow
{
    static class Program
    {
        //51aspx.com测试
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
