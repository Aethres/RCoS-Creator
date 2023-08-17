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
        public static List<Process> ImportFiles(string path)
        {
            string str = File.ReadAllText(Path.GetFullPath(path));
            return JsonConvert.DeserializeObject<List<Process>>(str);
        }

        public static void ExportFiles(string path, List<Process> processList)
        {
            if (processList.Any())
            {
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                };
                string jsonString = JsonConvert.SerializeObject(processList, settings);
                File.WriteAllText(path, jsonString);
            }
        }
    }
}
