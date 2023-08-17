using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Components
{
    public class EventSenderBox : ComboBox
    {
        List<Process> processList;
        Dictionary<int, Process> keyValues;
        Process process;
        Process choosenProcess;
        private bool closeIndexChanged;

        public Process ChoosenProcess { get => choosenProcess; set => choosenProcess = value; }
        public Dictionary<int, Process> KeyValues { get => keyValues; set => keyValues = value; }

        public EventSenderBox(List<Process> processList, Process process)
        {
            this.processList = processList;
            this.process = process;
            closeIndexChanged = false;
            KeyValues = new Dictionary<int, Process>();
            Text = "Choose a process";
            SelectedIndexChanged += ComboBoxR_SelectedIndexChanged;
            DropDown += EventSenderBox_DropDown;
            UpdateItems();
        }

        private void EventSenderBox_DropDown(object sender, EventArgs e)
        {
            UpdateItems();
        }

        public void UpdateItems()
        {
            Items.Clear();
            KeyValues.Clear();
            int index = 0;
            foreach (var item in processList)
            {
                if ((!item.Equals(process) && !process.GoingEvents.Contains(item))
                    || item.Equals(ChoosenProcess) )
                {
                    Items.Add(item.ProcessName);
                    KeyValues.Add(index, item);
                    if (item.Equals(ChoosenProcess))
                    {
                        closeIndexChanged = true;
                        SelectedIndex = index;
                        closeIndexChanged = false;
                    }
                    index++;
                }

            }
        }

        private void ComboBoxR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (closeIndexChanged) return;

            if (ChoosenProcess != null)
            {
                process.removeGoingEvents(ChoosenProcess);
            }
            ChoosenProcess = KeyValues[SelectedIndex];
            process.addGoingEvents(ChoosenProcess);
        }
    }
}
