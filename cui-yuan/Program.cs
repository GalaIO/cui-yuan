using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cui_yuan
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain form = new FormMain();
            while (!form.Init()) { }
            Application.Run(form);
        }
    }
}
