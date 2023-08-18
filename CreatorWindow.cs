using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ookii.Dialogs.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.Components;
using WindowsFormsApp1.FileOperations;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class CreatorWindow : Form
    {
        List<Process> processList;
        Process process;
        ProcessConfig processConfig;
        ProcessEventSender eventSender;

        private const string DEBUG_LOST_FOCUS_TEXT = "Use \",\" for multiple entries";
        public CreatorWindow(List<Process> processList)
        {
            Icon = Resources.RCoSIcon;

            this.processList = processList;
            AutoScroll = true;

            InitializeComponent();
            ComponentLocker();
            UpdateEventSender();
            UpdateProcessConfig();
            debugPortsBehavior();
            pictureBox1.SendToBack();
            pictureBox2.SendToBack();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(0, 0);
            Logo.BackColor = Color.Transparent;

            foreach (var item in Program.platformNames)
            {
                comboBox1.Items.Add(item);
            }

            versionToolStripMenuItem1.Text = "v" + Program.APP_VERSION;
        }

        private void debugPortsBehavior()
        {
            debugPorts.GotFocus += (bs, be) =>
            {
                if (debugPorts.Text == DEBUG_LOST_FOCUS_TEXT)
                {
                    debugPorts.Text = "";
                    debugPorts.ForeColor = Color.Black;
                }
            };
            debugPorts.LostFocus += (bs, be) =>
            {
                if (debugPorts.Text == "")
                {
                    debugPorts.Text = DEBUG_LOST_FOCUS_TEXT;
                    debugPorts.ForeColor = Color.Gray;
                }
            };
        }
        private void UpdateEventSender()
        {
            if (process != null)
            {
                ProcessEventSender oldEventSender = null;
                if (eventSender != null)
                {
                    oldEventSender = eventSender;
                }

                eventSender = new ProcessEventSender(processList, process);
                eventSender.AutoScroll = true;
                eventSender.Location = new Point(445, 400);
                eventSender.Show();

                this.Controls.Add(eventSender);
                if (oldEventSender != null)
                {
                    oldEventSender.Hide();
                }
            }
            else
            {
                eventSender = new ProcessEventSender(processList, process);
                eventSender.AutoScroll = true;
                eventSender.Location = new Point(445, 400);
                eventSender.Hide();
                this.Controls.Add(eventSender);
            }
        }

        private void UpdateProcessConfig()
        {
            UpdateEventSender();
            if (process != null)
            {
                ProcessConfig oldProcessConfig = null;
                if (processConfig != null)
                {
                    oldProcessConfig = processConfig;
                }

                processConfig = new ProcessConfig(process);
                processConfig.AutoScroll = true;
                processConfig.Location = new Point(14, 400);
                processConfig.Show();

                this.Controls.Add(processConfig);
                if (oldProcessConfig != null)
                {
                    oldProcessConfig.Hide();
                }
            }
            else
            {
                processConfig = new ProcessConfig(process);
                processConfig.AutoScroll = true;
                processConfig.Location = new Point(14, 400);
                processConfig.Show();
                this.Controls.Add(processConfig);
            }
        }

        private void ComponentLocker()
        {
            if (process == null)
            {
                numericUpDown2.Enabled = false;
                eventsCount.Enabled = false;
                timerEventsCount.Enabled = false;
                devIOCount.Enabled = false;
                devComCount.Enabled = false;
                debugName.Enabled = false;
                author.Enabled = false;
                description.Enabled = false;
                debugPorts.Enabled = false;
                resetButton.Enabled = false;
                devCpxCount.Enabled = false;
                devMemCount.Enabled = false;
            }
            else
            {
                numericUpDown2.Enabled = true;
                eventsCount.Enabled = true;
                timerEventsCount.Enabled = true;
                devIOCount.Enabled = true;
                devComCount.Enabled = true;
                debugName.Enabled = true;
                author.Enabled = true;
                description.Enabled = true;
                debugPorts.Enabled = true;
                resetButton.Enabled = true;
                devCpxCount.Enabled = true;
                devMemCount.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog sf = new VistaFolderBrowserDialog();

            if (sf.ShowDialog() == DialogResult.OK)
            {
                Program.generateFiles(sf.SelectedPath, processList);
            }

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Process.processListUpdate(processList, (int) numericUpDown1.Value);
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                numericUpDown2.Value = numericUpDown1.Value;
            }
            else if (numericUpDown2.Value == 0 && numericUpDown1.Value > 0)
            {
                numericUpDown2.Value = 1;
            }
            //UpdateProcessConfig();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (processList.Count() > 0)
            {
                string earlierDesc = processList.First().Description;
                foreach (var item in processList)
                {
                    if (item.Description == "")
                    {
                        item.Description = earlierDesc;
                    }
                    earlierDesc = item.Description;

                }
            }
            if ((int) numericUpDown1.Value == 0 && (int) numericUpDown2.Value != 0)
            {
                numericUpDown2.Value = 0;
            }
            else if ((int)numericUpDown1.Value != 0 && (int) numericUpDown2.Value == 0)
            {
                process = processList.ElementAt(0);
                numericUpDown2.Value = 1;
            }
            else if ((int)numericUpDown1.Value != 0 && numericUpDown2.Value > numericUpDown1.Value)
            {
                process = processList.ElementAt((int)numericUpDown1.Value - 1);
                numericUpDown2.Value = numericUpDown1.Value;
            }
            else if ((int)numericUpDown1.Value != 0)
            {
                process = processList.ElementAt(
                    numericUpDown1.Value < numericUpDown2.Value ?
                    (int) numericUpDown1.Value - 1 : (int)numericUpDown2.Value - 1);
            }

            if ((int) numericUpDown2.Value == 0)
            {
                process = null;
            }

            if (process == null)
            {
                debugName.Text = "";
                description.Text = "";
                author.Text = "";
                debugPorts.Text = DEBUG_LOST_FOCUS_TEXT;

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
                debugPorts.Text = process.DebugPorts == DEBUG_LOST_FOCUS_TEXT || process.DebugPorts ==  "" ?
                                   DEBUG_LOST_FOCUS_TEXT : process.DebugPorts;
            }
            ComponentLocker();
            UpdateProcessConfig();


        }

        private void eventsCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Process.listUpdate(process.Events, (int)eventsCount.Value, "Event");
            }
            UpdateProcessConfig();
        }

        private void timerEventsCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Process.listUpdate(process.TimerEvents, (int)timerEventsCount.Value, "TimerEvent");
            }
            UpdateProcessConfig();
        }

        private void devIOCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Process.listUpdate(process.DevIO, (int)devIOCount.Value, "DevIO");
            }
            UpdateProcessConfig();
        }

        private void devComCount_ValueChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                Process.listUpdate(process.DevCom, (int)devComCount.Value, "DevCom");
            }
            UpdateProcessConfig();
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
                foreach (var item in processList)
                {
                    item.Author = author.Text;
                }
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
                process.DebugPorts = debugPorts.Text == DEBUG_LOST_FOCUS_TEXT || debugPorts.Text == "" ?
                                   "" : debugPorts.Text;
            }
            if (debugPorts.Text == DEBUG_LOST_FOCUS_TEXT)
            {
                debugPorts.ForeColor = Color.Gray;
            }
            else
            {
                debugPorts.ForeColor = Color.Black;
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
                    description.Text = "";
                    debugPorts.Text = DEBUG_LOST_FOCUS_TEXT;
                    timerEventsCount.Value = 0;
                    eventsCount.Value = 0;
                    devIOCount.Value = 0;
                    devComCount.Value = 0;
                }


            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    processList = SaveManager.ImportFiles(file);
                    process = null;
                    numericUpDown1.Value = processList.Count;
                    numericUpDown2_ValueChanged(sender, e);
                }
                catch (IOException)
                {
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "json";
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveManager.ExportFiles(saveFileDialog.FileName, processList);
            }
        }

        private void test3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.platformIndex = comboBox1.SelectedIndex;
        }

        private void test1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string file = ".\\Arcelik_RCoS_v6.pdf";
            File.WriteAllBytes(file, Properties.Resources.Arcelik_RCoS_v6);
            System.Diagnostics.Process.Start(file);
        }

        private void rCoSSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rcossdk.com");
        }

        private void FreeRTOSButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show($"This function will be addded later.",
                                     $"Work In Progress!",
                                     MessageBoxButtons.OK);
        }

        private void SecureButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show($"This function will be addded later.",
                                     $"Work In Progress!",
                                     MessageBoxButtons.OK);
        }

        private void ClassBButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show($"This function will be addded later.",
                                     $"Work In Progress!",
                                     MessageBoxButtons.OK);
        }

        private void AIButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show($"This function will be addded later.",
                                     $"Work In Progress!",
                                     MessageBoxButtons.OK);
        }

        private void ledBlinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rcossdk.com");
        }

        private void buzzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rcossdk.com");
        }

        private void encoderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rcossdk.com");
        }

        private void reflexGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.rcossdk.com");
        }

        private void CodeSizeButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show($"This function will be addded later.",
                         $"Work In Progress!",
                         MessageBoxButtons.OK);
        }
    }
}
