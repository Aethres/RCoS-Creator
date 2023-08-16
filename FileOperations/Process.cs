using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
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
        static Dictionary<string, int> itemDict= new Dictionary<string, int>();
        public enum TextType
        {
            EVENTS,
            TIMER_EVENTS_PARAMS,
            TIMER_EVENTS_INIT,
            DEVIO_CONSTS,
            DEVCOM_CONSTS,
            FUNC_PARAMS,
            FUNC_CREATE_PARAMS,
            PARAMS_INIT,
        }
        

        public Process()
        {
        }

        public Process(string processName, List<Process> processList)
        {
            ProcessName = processName;
            ProcessList = processList;
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

        [JsonIgnore]
        public List<Process> ProcessList { get => processList; set => processList = value; }
        public string Description { get => description; set => description = value; }
        public string Author { get => author; set => author = value; }
        public string DebugName { get => debugName; set => debugName = value; }
        public string DebugPorts { get => debugPorts; set => debugPorts = value; }
        public string ProcessName { get => processName; set => processName = value; }
        public bool IsActive { get => isActive; set => isActive = value; }
        [JsonProperty]
        public List<ProcessItem> Events { get => events; set => events = value; }
        [JsonProperty]
        public List<ProcessItem> TimerEvents { get => timerEvents; set => timerEvents = value; }
        [JsonProperty]
        public List<ProcessItem> DevIO { get => devIO; set => devIO = value; }
        [JsonProperty]
        public List<ProcessItem> DevCom { get => devCom; set => devCom = value; }
        [JsonProperty]
        public static Dictionary<string, int> ItemDict { get => itemDict; set => itemDict = value; }

        public void generateFiles(string path)
        {
            string appPath = path + "\\app";
            System.IO.Directory.CreateDirectory(appPath);

            File.WriteAllText($"{appPath}\\{ProcessName.ToLowerInvariant()}.c", replace(Resources.tempApp_c));
            File.WriteAllText($"{appPath}\\{ProcessName.ToLowerInvariant()}.h", replace(Resources.tempApp_h));
        }

        public string replace(string template)
        {
            StringBuilder sb = new StringBuilder(template);
            sb.Replace("%FILENAMELC%", ProcessName.ToLowerInvariant());
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
            sb.Replace("%EVENTS%", arrangeText(TextType.EVENTS, events));
            sb.Replace("%TIMER_EVENTS%", arrangeText(TextType.EVENTS, timerEvents));
            sb.Replace("%TIMER_EVENTS_PARAMETERS%", arrangeText(TextType.TIMER_EVENTS_PARAMS, timerEvents));
            sb.Replace("%TIMER_EVENTS_INIT%", arrangeText(TextType.TIMER_EVENTS_INIT, timerEvents));
            sb.Replace("%DEVIO%", arrangeText(TextType.DEVIO_CONSTS, devIO));
            sb.Replace("%DEVCOM%", arrangeText(TextType.DEVCOM_CONSTS, devCom));
            sb.Replace("%DEVIO_FUNC_PARAMS%", arrangeText(TextType.FUNC_PARAMS, devIO));
            sb.Replace("%DEVCOM_FUNC_PARAMS%", arrangeText(TextType.FUNC_PARAMS, devCom));
            sb.Replace("%DEVIO_INIT%", arrangeText(TextType.PARAMS_INIT, devIO));
            sb.Replace("%DEVCOM_INIT%", arrangeText(TextType.PARAMS_INIT, devCom));

            return sb.ToString();
        }

        public static string arrangeText(TextType textType, List<ProcessItem> list)
        {
            string str = string.Empty;
            foreach (var item in list)
            {
                if (item.IsActive)
                {
                    switch (textType)
                    {
                        case TextType.EVENTS:
                            str += $"\n\te{item.Name},";
                            break;
                        case TextType.TIMER_EVENTS_PARAMS:
                            str += $"\n\ttsTimerEvent {item.Name}Timer,";
                            break;
                        case TextType.TIMER_EVENTS_INIT:
                            str += $"\\\n\t .{item.Name}Timer =" +
                                $" TIMER_EVENT_INIT(_enum, _enum, e{item.Name}),";
                            break;
                        case TextType.DEVIO_CONSTS:
                            str += $"\n\t const tsDevIo *{item.Name},";
                            break;
                        case TextType.DEVCOM_CONSTS:
                            str += $"\n\t const tsDevCom *{item.Name},";
                            break;
                        case TextType.FUNC_PARAMS:
                            str += $", _{item.Name}";
                            break;
                        case TextType.FUNC_CREATE_PARAMS:
                            str += $", {item.Name}";
                            break;
                        case TextType.PARAMS_INIT:
                            str += $"\\\n\t .{item.Name} = &_{item.Name},";
                            break;
                        default:
                            break;
                    }
                    
                }
            }
            return str;
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

        public void resetProcess()
        {
            ProcessName = ("Process" + (processList.IndexOf(this) + 1).ToString());
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

        public static void processListUpdate(List<Process> processList, int count)
        {
            int diff = Math.Abs(count - processList.Count);
            if (processList.Count > count)
            {
                foreach (var item in processList.GetRange(count, diff))
                {
                    item.IsActive = false;
                }
            }
            else if (processList.Count < count)
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
                if (ItemDict.ContainsKey(name))
                {
                    ItemDict[name]++;
                }
                else
                {
                    ItemDict.Add(name, 1);
                }

                for (int i = 0; i < diff; i++)
                {
                    list.Add(new ProcessItem(name + (ItemDict[name]).ToString()));
                }
            }

            for (int i = 0; i < count; i++)
            {
                list.ElementAt(i).IsActive = true;
            }
        }

    }
}
