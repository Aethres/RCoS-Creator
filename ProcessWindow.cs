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

namespace WindowsFormsApp1
{
    public partial class ProcessWindow : Form
    {
        private Process process;
        private List<TextBoxR> textBoxes;
        private Point point;
        public ProcessWindow(Process process)
        {
            InitializeComponent();
            this.process = process;
            processName.Text = process.ProcessName;
            textBoxes = new List<TextBoxR>();
            point = new Point(0, 20);
            addComponents();
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

        private void addTextBoxes(List<string> list)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                TextBoxR textBox = new TextBoxR(list, i);
                textBox.Location = newCompenentLocation();
                textBoxes.Add(textBox);
                this.Controls.Add(textBox);
                textBox.Show();
            }
        }

        private Point newCompenentLocation()
        {
            point.Y += 30;
            return new Point(point.X, point.Y);
        }

        private void processName_TextChanged(object sender, EventArgs e)
        {
            process.ProcessName = processName.Text;
        }
    }
}
