using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FileGenerators;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        private static List<Process> processList;
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            processList = new List<Process>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1(processList);
            form.WindowState = FormWindowState.Maximized;
            form.Text = "RCos+ Creator";

            Application.Run(form);

        }
        public static void generateFiles()
        {
            foreach (var item in processList)
            {
                if (item.IsActive)
                {
                    item.generateFiles();
                }
            }
            System.IO.Directory.CreateDirectory("RCosHelper");
            File.WriteAllText($".\\RCosHelper\\ReadMe.txt", Process.rcosHelper(processList));
        }

    }
}
