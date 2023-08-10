using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Components;
using WindowsFormsApp1.FileGenerators;

namespace WindowsFormsApp1
{
    public partial class ProcessConfig : UserControl
    {
        private Process process;
        private List<TextBoxR> textBoxes;
        private Point point;

        public ProcessConfig(Process process)
        {
            InitializeComponent();
            if (process != null)
            {
                this.process = process;
                processName.Text = process.ProcessName;
                textBoxes = new List<TextBoxR>();
                point = new Point(20, 20);
                addComponents();
            }
            else
            {
                processName.Hide();
            }

        }

        private void addComponents()
        {
            addTextBoxes(process.Events);
            point.X += 120;
            point.Y = 20;
            addTextBoxes(process.TimerEvents);
            point.X += 120;
            point.Y = 20;
            addTextBoxes(process.DevIO);
            point.X += 120;
            point.Y = 20;
            addTextBoxes(process.DevCom);
        }

        private void addTextBoxes(List<ProcessItem> list)
        {
            foreach (var item in list)
            {
                if (item.IsActive)
                {
                    TextBoxR textBox = new TextBoxR(item);
                    textBox.Location = newCompenentLocation();
                    textBoxes.Add(textBox);
                    this.Controls.Add(textBox);
                    textBox.Show();
                }
            }
        }

        private Point newCompenentLocation()
        {
            point.Y += 30;
            return new Point(point.X, point.Y);
        }

        private void processName_TextChanged(object sender, EventArgs e)
        {
            if (process != null)
            {
                process.ProcessName = processName.Text;
            }
        }
    }
}
