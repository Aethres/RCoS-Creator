using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WindowsFormsApp1.FileGenerators;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public class Process
    {
        bool isActive;
        string description;
        string author;
        string debugName;
        string debugPorts;
        string processName;
        List<Process> processList;
        List<ProcessItem> events;
        List<ProcessItem> timerEvents;
        List<ProcessItem> devIO;
        List<ProcessItem> devCom;
        public Process(string processName, List<Process> processList)
        {
            this.ProcessName = processName;
            this.ProcessList = processList;
            IsActive = true;
            Events = new List<ProcessItem>();
            TimerEvents = new List<ProcessItem>();
            DevIO = new List<ProcessItem>();
            DevCom = new List<ProcessItem>();
            description = "";
            author = "";
            debugName = "";
            debugPorts = "";
        }

        public List<Process> ProcessList { get => processList; set => processList = value; }
        public string Description { get => description; set => description = value; }
        public string Author { get => author; set => author = value; }
        public string DebugName { get => debugName; set => debugName = value; }
        public string DebugPorts { get => debugPorts; set => debugPorts = value; }
        public string ProcessName { get => processName; set => processName = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        internal List<ProcessItem> Events { get => events; set => events = value; }
        internal List<ProcessItem> TimerEvents { get => timerEvents; set => timerEvents = value; }
        internal List<ProcessItem> DevIO { get => devIO; set => devIO = value; }
        internal List<ProcessItem> DevCom { get => devCom; set => devCom = value; }

        public void generateFiles()
        {
            System.IO.Directory.CreateDirectory("app");

            File.WriteAllText($".\\app\\{ProcessName.ToLower()}.c", replace(Resources.tempApp_c));
            File.WriteAllText($".\\app\\{ProcessName.ToLower()}.h", replace(Resources.tempApp_h));

        }

        public string replace(string template)
        {
            StringBuilder sb = new StringBuilder(template);
            sb.Replace("%FILENAMELC%", ProcessName.ToLower());
            sb.Replace("%FILENAMEUC%", ProcessName.ToUpperInvariant());
            sb.Replace("%DEBUG_NAME%", DebugName);
            sb.Replace("%DEBUG_PORTS%", constructDebugPorts());
            sb.Replace("%APPNAME%", ProcessName.Replace("_", ""));
            sb.Replace("%APPNAMEPC%", char.ToUpperInvariant(ProcessName[0]) + ProcessName.Substring(1).Replace("_", ""));
            sb.Replace("%AUTHOR%", Author);
            sb.Replace("%BRIEF%", Description);
            sb.Replace("%YEAR%", DateTime.Today.Year.ToString());
            sb.Replace("%DATE%", DateTime.Today.ToString("d/MM/yyyy"));

            //header only
            string str = string.Empty;
            foreach (var item in events)
            {
                if (item.IsActive)
                {
                    str += $"\n\t{item.Name},";
                }
            }
            sb.Replace("%EVENTS%", str);

            return sb.ToString();
        }

        private string constructDebugPorts()
        {
            int index = 0;
            string ports = "";
            if (DebugPorts != null)
            {

                foreach (var item in debugPorts.Replace(" ", "").Split(','))
                {
                    if (item != string.Empty)
                    {
                        ports += "#define DEBUG_PORT_" + item.ToUpperInvariant() + " BIT(" + index + ")\n";
                        index++;
                    }

                }
                return ports;
            }

            return "";
        }

        public static string rcosHelper(List<Process> processes)
        {
            string str = "//Will be written in RcosmainLoop\n";
            str += "//start processes\n";
            foreach (var item in processes)
            {
                if (item.isActive)
                {
                    str += $"processStart(&{item.processName})\n";
                }
            }

            return str;
        }

        public void resetProcess()
        {
            ProcessName = ("Process" + (processList.IndexOf(this) + 1).ToString()) ;
            IsActive = true;
            Events = new List<ProcessItem>();
            TimerEvents = new List<ProcessItem>();
            DevIO = new List<ProcessItem>();
            DevCom = new List<ProcessItem>();
            description = "";
            author = "";
            debugName = "";
            debugPorts = "";
        }
    }
}
