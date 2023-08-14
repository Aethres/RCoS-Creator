using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace WindowsFormsApp1.FileOperations
{
    public static class SaveManager
    {
        public static List<Process> ImportFiles(string path, List<Process> processList)
        {
            string str = File.ReadAllText(Path.GetFullPath(path));
            processList = JsonConvert.DeserializeObject<List<Process>>(str);
            return processList;
        }

        public static void ExportFiles(string path, List<Process> processList)
        {
            if (processList.Any())
            {
                string jsonString = JsonConvert.SerializeObject(processList);
                File.WriteAllText(path, jsonString);
            }
        }
    }
}
