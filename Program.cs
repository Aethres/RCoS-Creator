using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new Form1(processList));
        }

        public static void processListUpdate(int count)
        {
            int diff = Math.Abs(count - processList.Count);
            if (processList.Count > count)
            {
                processList.RemoveRange(count, diff);
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
        }

        public static void listUpdate(List<string> list, int count, string name)
        {
            int diff = Math.Abs(count - list.Count);
            if (list.Count > count && list.Any())
            {
                list.RemoveRange(count, diff);
            }
            else if (list.Count < count)
            {
                for (int i = 0; i < diff; i++)
                {
                    list.Add(name + (list.Count + 1).ToString());
                }
            }
        }

        public static void generateFiles()
        {
            foreach (var item in processList)
            {
                item.generateFiles();
            }
        }

        public static List<Process> getProcessList()
        {
            return processList;
        }
    }
}
