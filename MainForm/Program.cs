using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Pipes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace UI_Example
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthForm());
        }
    }
}
