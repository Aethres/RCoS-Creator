using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Process> processList;
        Process process;
        public Form1(List<Process> processList)
        {
            this.processList = processList;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.generateFiles();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Program.processListUpdate( (int) numericUpDown1.Value);
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
            else if (numericUpDown2.Value == 0 && numericUpDown1.Value > 0)
            {
                numericUpDown2.Value = 1;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if ((int) numericUpDown1.Value == 0)
            {
                numericUpDown2.Value = 0;
                process = null;
            }
            else if ((int) numericUpDown2.Value == 0)
            {
                numericUpDown2.Value = 1;
                process = processList.ElementAt(0);
            }
            else if (numericUpDown2.Value > numericUpDown1.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
                process = processList.ElementAt( (int) numericUpDown1.Value - 1);
            }
            else
            {
                    process = processList.ElementAt(
                    numericUpDown1.Value < numericUpDown2.Value?
                    (int) numericUpDown1.Value - 1 : (int)numericUpDown2.Value - 1);
            }

            if (process == null)
            {
                debugName.Text = "";
                description.Text = "";
                author.Text = "";
                debugPorts.Text = "";

            }
            else
            {
                eventsCount.Text = process.Events.Count().ToString();
                timerEventsCount.Text = process.TimerEvents.Count().ToString();
                devIOCount.Text = process.DevIO.Count().ToString();
                devComCount.Text = process.DevCom.Count().ToString();
                debugName.Text = process.DebugName;
                description.Text = process.Description;
                author.Text = process.Author;
                debugPorts.Text = process.DebugPorts;
            }
            

        }

        private void eventsCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Program.listUpdate(process.Events, (int)eventsCount.Value, "Event");
            }
        }

        private void timerEventsCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Program.listUpdate(process.TimerEvents, (int)timerEventsCount.Value, "Timer Event");
            }
        }

        private void devIOCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Program.listUpdate(process.DevIO, (int)devIOCount.Value, "DevIO");
            }
        }

        private void devComCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Program.listUpdate(process.DevCom, (int)devComCount.Value, "DevCom");
            }
        }

        private void debugName_TextChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                process.DebugName = debugName.Text;
            }
        }

        private void author_TextChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                process.Author = author.Text;
            }
        }

        private void description_TextChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                process.Description = description.Text;
            }
        }

        private void debugPorts_TextChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                process.DebugPorts = debugPorts.Text;
            }
        }

        private void configureButton_Click(object sender, EventArgs e)
        {
            if (process != null)
            {
                ProcessWindow form = new ProcessWindow(process);
                form.Show();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (process != null)
            {
                DialogResult confirmResult = MessageBox.Show($"{process.ProcessName} will be reset!",
                                     $"Confirm {process.ProcessName} reset!",
                                     MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    process.resetProcess();
                    debugName.Text = "";
                    author.Text = "";
                    description.Text = "";
                    debugPorts.Text = "";
                    timerEventsCount.Value = 0;
                    eventsCount.Value = 0;
                    devIOCount.Value = 0;
                    devComCount.Value = 0;

                    //debugName_TextChanged(sender, e);
                    //author_TextChanged(sender, e);
                    //description_TextChanged(sender, e);
                    //debugPorts_TextChanged(sender, e);
                    //eventsCount_ValueChanged(sender, e);
                    //timerEventsCount_ValueChanged(sender, e);
                    //devIOCount_ValueChanged(sender, e);
                    //devComCount_ValueChanged(sender, e);

                }


            }
        }
    }
}
