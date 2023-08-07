using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public class Process
    {
        string description;
        string author;
        string debugName;
        string debugPorts;
        string processName;
        List<Process> processList;
        List<string> events;
        List<string> timerEvents;
        List<string> devIO;
        List<string> devCom;
        public Process(string processName, List<Process> processList)
        {
            this.ProcessName = processName;
            this.ProcessList = processList;
            events = new List<string>();
            timerEvents = new List<string>();
            devIO = new List<string>();
            devCom = new List<string>();
            description = "";
            author = "";
            debugName = "";
            debugPorts = "";
        }

        public List<Process> ProcessList { get => processList; set => processList = value; }
        public List<string> Events { get => events; set => events = value; }
        public List<string> TimerEvents { get => timerEvents; set => timerEvents = value; }
        public List<string> DevIO { get => devIO; set => devIO = value; }
        public List<string> DevCom { get => devCom; set => devCom = value; }
        public string Description { get => description; set => description = value; }
        public string Author { get => author; set => author = value; }
        public string DebugName { get => debugName; set => debugName = value; }
        public string DebugPorts { get => debugPorts; set => debugPorts = value; }
        public string ProcessName { get => processName; set => processName = value; }

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
    }
}
