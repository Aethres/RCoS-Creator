﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Components
{
    public partial class ProcessEventSender : UserControl
    {
        List<ComboBox> comboBoxes;
        List<Process> processList;
        private Point point;
        public ProcessEventSender(List<Process> processList)
        {
            InitializeComponent();
            SendToBack();
            comboBoxes = new List<ComboBox>();
            this.processList = processList;
            point = new Point(30, 50);
        }

        private void addProcess()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Text = "Process is not choosen";
            
            foreach (var item in processList)
            {
                comboBox.Items.Add(item.ProcessName);
            }
            comboBox.Location = newCompenentLocation();
            comboBox.SelectedIndex = 0;
            Controls.Add(comboBox);
            comboBox.Show();

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
