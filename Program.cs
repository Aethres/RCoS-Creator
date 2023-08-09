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

            Application.Run(form);

        }

        public static void processListUpdate(int count)
        {
            int diff = Math.Abs(count - processList.Count);
            if (processList.Count > count)
            {
                foreach (var item in processList.GetRange(count, diff))
                {
                    item.IsActive = false;
                }
            }
            else if(processList.Count < count)
            {
                string name;
                for (int i = 0; i < diff; i++)
                {
                    name = "Process" + (processList.Count + 1).ToString();
                    processList.Add(new Process(name, processList));
                }
            }
            for (int i = 0; i < count; i++)
            {
                processList.ElementAt(i).IsActive = true;
            }
        }

        public static void listUpdate(List<ProcessItem> list, int count, string name)
        {
            int diff = Math.Abs(count - list.Count);
            if (list.Count > count && list.Any())
            {
                foreach (var item in list.GetRange(count, diff))
                {
                    item.IsActive = false;
                }
            }
            else if (list.Count < count)
            {
                for (int i = 0; i < diff; i++)
                {
                    list.Add(new ProcessItem(name + (list.Count + 1).ToString()));
                }
            }

            for (int i = 0; i < count; i++)
            {
                list.ElementAt(i).IsActive = true;
            }
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

        public static List<Process> getProcessList()
        {
            return processList;
        }

    }
}
