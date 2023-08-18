using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using WindowsFormsApp1.FileGenerators;

namespace WindowsFormsApp1.Components
{
    public partial class ProcessEventSender : UserControl
    {
        List<EventSenderBox> comboBoxes;
        List<Process> processList;
        private Point point;
        Process process;
        public ProcessEventSender(List<Process> processList, Process process)
        {
            InitializeComponent();
            SendToBack();
            
            if (process != null)
            {
                this.process = process;
                comboBoxes = new List<EventSenderBox>();
                this.processList = processList;
                point = new Point(30, 50);
                addComponents();
                numericUpDown1.Value = comboBoxes.Count;
            }
            else
            {
                numericUpDown1.Hide();
            }

        }

        private void addComponents()
        {
            foreach (Process item in process.GoingEvents)
            {
                addProcess(item);
            }
        }
        private void addProcess(Process choosenProcess = null)
        {
            EventSenderBox comboBox = new EventSenderBox(processList, process);
            if (choosenProcess != null)
            {
                comboBox.ChoosenProcess = choosenProcess;
                comboBox.UpdateItems();
            }
            
            comboBox.Location = newCompenentLocation();
            Controls.Add(comboBox);
            comboBox.Show();
            comboBoxes.Add(comboBox);

        }

        private Point newCompenentLocation()
        {
            point.Y += 30;
            return new Point(point.X, point.Y);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            addProcess();
        }
    }
}
