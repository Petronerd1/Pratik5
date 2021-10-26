using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    class Student
    {
        public string Name;
        public string Surname;
        public string Class;
        public string New;
        public void Edit()
        {
            New = "Öðrencinin Adý: " + Name + " Soyadý: " + Surname + " Dersi: " + Class;
        }

    }
}
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


