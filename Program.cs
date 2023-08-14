﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FileGenerators;
using WindowsFormsApp1.FileOperations;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public const string APP_VERSION = "1.0";
        public static List<string> platformNames = new List<string> ()
        {
                "CyPress PSOC4",
                "CyPress PSOC6",
                "NXP ke02",
                "NXP ke04",
                "NXP ke14",
                "NXP ke15",
                "NXP ke16",
                "AVR",
                "Sinowealth",
        };


        public static int platformIndex;
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

            CreatorWindow creatorWindow = new CreatorWindow(processList);
            creatorWindow.Text = "RCoS+ Creator";

            Application.Run(creatorWindow);
        }

        public static void generateFiles(string path)
        {
            foreach (var item in processList)
            {
                if (item.IsActive)
                {
                    item.generateFiles(path);
                }
            }
            string rCoSHelperPath = $"{path}\\RCoSHelper";
            System.IO.Directory.CreateDirectory(rCoSHelperPath);
            File.WriteAllText($"{rCoSHelperPath}\\rcos.c", rcosHelper(processList, Resources.tempRCoS_c));
            File.WriteAllText($"{rCoSHelperPath}\\rcos.h", rcosHelper(processList, Resources.tempRCoS_h));
            SaveManager.ExportFiles($"{rCoSHelperPath}\\AutoExport.json", processList);
        }

        public static string rcosHelper(List<Process> processes, string template)
        {
            StringBuilder sb = new StringBuilder(template);
            string processCreate = "";
            string processStart = "";

            foreach (var item in processes)
            {
                if (item.IsActive)
                {
                    processCreate += $"PROCESS_UI_CREATE({item.ProcessName}, e{item.ProcessName})\n";
                    processStart += $"\tprocessStart(&{item.ProcessName})\n";
                }
            }

            //might be added
            sb.Replace("%EVENTQUEUE_SIZE%", "");
            sb.Replace("%DEBUG_DEV_LINE%", "");
            sb.Replace("%TICK_ARGS%", "");
            sb.Replace("%WDT_ARGS%", "");
            sb.Replace("%OBJECTS_CREATE%", "");
            sb.Replace("%OBJECTS_INIT%", "");

            sb.Replace("%PLATFORM%", platformNames[platformIndex].ToUpperInvariant().Replace(" ", "_"));

            sb.Replace("%PROCESS_CREATE%", processCreate);
            sb.Replace("%PROCESS_START%", processStart);

            if (processes.Any())
            {
                sb.Replace("%AUTHOR%", processes.First().Author);
            }
            sb.Replace("%DATE%", DateTime.Today.ToString("d/MM/yyyy"));

            return sb.ToString();
        }

    }
}
